using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmMonitorThreadsHandlesAndBytes : Form
    {
        public FrmMonitorThreadsHandlesAndBytes()
        {
            InitializeComponent();

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomain_UnhandledException);

            GetMachineName();
            LoadSettings();

        }

        private string machineName = System.Environment.MachineName;
        private int smallLabelWidth = 40;
        private int bigLabelWidth = 60;

        private PerformanceCounter cpuCounter = null;
        private PerformanceCounter ramCounter = null;
        private PerformanceCounter pageCounter = null;
        private PerformanceCounter[] nicCounters = null;


        #region config settings
        // Load and save last window position
        // simple way to do it so that we can run multiple instances (one per machine) and still have them all save their position
        private void LoadSettings()
        {
            int iLeft = 0;
            int iTop = 0;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            try
            {
                // TryParse will default to zero on an invalid value
                int.TryParse(ConfigurationManager.AppSettings[String.Format("{0}-Left", this.machineName)], out iLeft);
                int.TryParse(ConfigurationManager.AppSettings[String.Format("{0}-Top", this.machineName)], out iTop);
            }
            finally
            {
                this.Left = iLeft;
                this.Top = iTop;
                config = null;
            }
        }

        private void SaveSettings()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            try
            {
                // remove the previously saved values
                config.AppSettings.Settings.Remove(String.Format("{0}-Left", this.machineName));
                config.AppSettings.Settings.Remove(String.Format("{0}-Top", this.machineName));
                // save our current values
                // this saves to app.config so it may be a permissions issue for non-admin users
                config.AppSettings.Settings.Add(String.Format("{0}-Left", this.machineName), this.Left.ToString());
                config.AppSettings.Settings.Add(String.Format("{0}-Top", this.machineName), this.Top.ToString());
                config.Save(ConfigurationSaveMode.Modified);
            }
            finally
            { config = null; }
        }
        #endregion


        private void InitCounters()
        {
            try
            {
                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", machineName);
                //ramCounter = new PerformanceCounter("Memory", "Available MBytes", String.Empty, machineName);
                ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use", String.Empty, machineName);
                pageCounter = new PerformanceCounter("Paging File", "% Usage", "_Total", machineName);
                
                // there can be multiple network interfaces
                nicCounters = GetNICCounters();
                
                // for each nic card, create a corresponding status bar label
                for (int i = 0; i < nicCounters.Length; i++)
                    ssStatusBar.Items.Add(GetNICLabel(nicCounters[i], i));
            }
            catch (Exception ex)
            {
                HandleException(String.Format("Unable to access computer '{0}'\r\nPlease check spelling and verify this computer is connected to the network", this.machineName));
                Close();
            }
        }

        private void DisposeCounters()
        {
            try
            {
                // dispose of the counters
                if (cpuCounter != null)
                { cpuCounter.Dispose(); }
                if (ramCounter != null)
                { ramCounter.Dispose(); }
                if (pageCounter != null)
                { pageCounter.Dispose(); }
                if (nicCounters != null)
                {
                    foreach (PerformanceCounter counter in nicCounters)
                    { counter.Dispose(); }
                }
            }
            finally
            { PerformanceCounter.CloseSharedResources(); }
        }

        // machinename defaults to local computer, but we can 
        // specify remote computer to monitor as well via command line param
        private void GetMachineName()
        {
            string[] cmdArgs = System.Environment.GetCommandLineArgs();
            if ((cmdArgs != null) && (cmdArgs.Length > 1))
            { this.machineName = cmdArgs[1]; }
        }

        // ping the remote computer 
        private bool VerifyRemoteMachineStatus(string machineName)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(machineName);
                    if (reply.Status == IPStatus.Success)
                    { return true; }
                }
            }
            catch (Exception ex)
            {
                // return false for any exception encountered
                // we'll probably want to just shut down anyway
            }
            return false;
        }

        // machine can have multiple nic cards (and laptops usually have wifi & wired) 
        // don't want to get into figuring out which one to show, just get all
        // can enumerate network card other ways (System.Net.NetworkInformation) 

        // PerformanceCounters can return string[] of available network interfaces
        private string[] GetNICInstances(string machineName)
        {
            string filter = "MS TCP Loopback interface";
            List<string> nics = new List<string>();
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface", machineName);
            if (category.GetInstanceNames() != null)
            {
                foreach (string nic in category.GetInstanceNames())
                {
                    if (!nic.Equals(filter, StringComparison.InvariantCultureIgnoreCase))
                    {
                        nics.Add(nic);
                    }
                }
            }
            return nics.ToArray();
        }

        // create a Performance Counter for each network interface
        private PerformanceCounter[] GetNICCounters()
        {
            string[] nics = GetNICInstances(this.machineName);
            List<PerformanceCounter> nicCounters = new List<PerformanceCounter>();
            foreach (string nicInstance in nics)
            {
                nicCounters.Add(new PerformanceCounter("Network Interface", "Bytes Total/sec", nicInstance, this.machineName));
            }
            return nicCounters.ToArray();
        }

        // create a ToolStripStatusLabel for each network interface
        private ToolStripStatusLabel GetNICLabel(PerformanceCounter counter, int index)
        {
            ToolStripStatusLabel newLabel = new ToolStripStatusLabel();

            newLabel.AutoSize = false;
            newLabel.Width = bigLabelWidth;
            newLabel.ToolTipText = counter.InstanceName;
            newLabel.Text = string.Empty;
            newLabel.Name = String.Format("tsNIC{0}", index);
            newLabel.TextAlign = ContentAlignment.MiddleRight;
            newLabel.BorderSides = ToolStripStatusLabelBorderSides.All;
            newLabel.BorderStyle = Border3DStyle.SunkenInner;
            newLabel.Height = ssStatusBar.Items[0].Height;

            return newLabel;
        }

        // adjust form width based on number of statusbar labels
        private void SetFormWidth()
        {
            //this.Width = (tsCPU.Width + tsRAM.Width + tsPage.Width);
            int width = 0;
            foreach (ToolStripStatusLabel label in ssStatusBar.Items)
            { width += label.Width + label.Padding.Right; }

            if (ssStatusBar.Padding.Horizontal > 0)
            { width += (ssStatusBar.Padding.Horizontal / 2); }
            this.Width = width;
        }


        public static void HandleException(Exception ex)
        {
            MessageBox.Show(String.Format("{0}:{1}", ex.ToString(), ex.Message),
                String.Format("{0} : Exception", Application.ProductName));
        }

        public static void HandleException(string exMessage)
        {
            MessageBox.Show(exMessage, String.Format("{0} : Exception", Application.ProductName));
        }

        //both of these need to be handled so the default Windows exception dialog isn't shown instead
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            //MessageDlg.Error(e.Exception.Message, "Error: Application.ThreadException");
            HandleException(e.Exception.Message);
            Application.Exit();
        }

        private static void AppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //MessageDlg.Error(e.ExceptionObject.ToString(), "Error: Application.ThreadException");
            HandleException(e.ExceptionObject.ToString());
            Application.Exit();
        }

        #region form events
        private void tTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                tsCPU.Text = String.Format("{0:##0}%", cpuCounter.NextValue());
                //tsRAM.Text = String.Format("{0} MB", ramCounter.NextValue());
                tsRAM.Text = String.Format("{0:##0}%", ramCounter.NextValue());
                tsPage.Text = String.Format("{0:##0}%", pageCounter.NextValue());

                for (int i = 0; i < nicCounters.Length; i++)
                {
                    ssStatusBar.Items[String.Format("tsNIC{0}", i)].Text = String.Format("{0:####0KB/s}", nicCounters[i].NextValue() / 1024);
                }
            }
            catch (Exception ex)
            {
                // remote computer might have become unavailable; 
                // show exception and close this application
                tTimer.Enabled = false;
                HandleException(ex);
                //Close();
            }
        }


        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save our window position
            SaveSettings();
            // dispose of the counters
            DisposeCounters();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            // do our safety checks here
            // if we're trying to monitor a remote computer
            if (!this.machineName.Equals(System.Environment.MachineName))
            {
                // if it doesn't respond to ping (machine name mispelled, computer is 
                // unavailable, etc), show the error message and close 
                if (!VerifyRemoteMachineStatus(this.machineName))
                {
                    HandleException(String.Format("Unable to access computer '{0}'\r\nPlease check spelling and verify this computer is connected to the network", this.machineName));
                    Close();
                    return;
                }
            }
            // do our initialization
            InitCounters();
            SetFormWidth();
            this.Text = String.Format("{0} [{1}]", Application.ProductName, this.machineName);
            // our Timer starts out Enabled==false, so if we get an exception while initializing counters
            // we don't get *more* from each Timer.Tick
            tTimer.Enabled = true;
        }
        #endregion
    }
}
