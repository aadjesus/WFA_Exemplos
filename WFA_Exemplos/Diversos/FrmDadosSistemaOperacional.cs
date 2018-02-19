using System;
using System.IO;
using System.Management;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace WFA_Workflow
{
    public partial class FrmDadosSistemaOperacional : Form
    {
        int n = 0;
        public FrmDadosSistemaOperacional()
        {
            InitializeComponent();


        }

        public void Traco()
        {
            //listBox1.Items.Add((n++).ToString() +") "+ String.Join("-", Enumerable.Range(0, 50).Select(s => "-").ToArray()));

            listBox1.Items.Add(String.Concat(n++, ")", String.Empty.PadLeft(100, '-')));
        }

        public class SystemInfo
        {

            public void getOperatingSystemInfo(ListBox listBox1)
            {

                listBox1.Items.Add("Displaying operating system info....\n");

                //Create an object of ManagementObjectSearcher class and pass query as parameter.

                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

                foreach (ManagementObject managementObject in mos.Get())
                {

                    if (managementObject["Caption"] != null)
                    {

                        listBox1.Items.Add("Operating System Name  :  " + managementObject["Caption"].ToString());   //Display operating system caption

                    }

                    if (managementObject["OSArchitecture"] != null)
                    {

                        listBox1.Items.Add("Operating System Architecture  :  " + managementObject["OSArchitecture"].ToString());   //Display operating system architecture.

                    }

                    if (managementObject["CSDVersion"] != null)
                    {

                        listBox1.Items.Add("Operating System Service Pack   :  " + managementObject["CSDVersion"].ToString());     //Display operating system version.

                    }

                }

            }

            public void getProcessorInfo(ListBox listBox1)
            {

                Console.WriteLine("\n\nDisplaying Processor Name....");

                RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

                if (processor_name != null)
                {

                    if (processor_name.GetValue("ProcessorNameString") != null)
                    {

                        listBox1.Items.Add(processor_name.GetValue("ProcessorNameString"));   //Display processor ingo.

                    }

                }

            }
        }

        public void WriteKey(RegistryKey hk, string relPath, ListBox listBox1)
        {
            if (relPath != "")
                relPath += "/";

            foreach (var keyname in hk.GetSubKeyNames())
            {
                var key = hk.OpenSubKey(keyname, false);

                var keySP = key.GetValue("SP");
                var keyVersion = key.GetValue("Version");

                if (keyVersion != null)
                    listBox1.Items.Add(relPath + keyname +
                      ": Version " + keyVersion.ToString() +
                      ((keySP != null) ? " SP " + keySP.ToString() : "") +
                      (1.Equals(key.GetValue("Install")) ? " installed" : ""));

                WriteKey(key, relPath + keyname, listBox1);

                key.Close();
            }
        }

        private void FrmDadosSistemaOperacional_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            #region 0

            this.Traco();

            ComputerInfo computerInfo = new ComputerInfo();
            string fullName = computerInfo.OSFullName;

            ManagementClass mgt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection procs = mgt.GetInstances();
            foreach (ManagementObject item in procs)
                listBox1.Items.Add(item.Properties["Name"].Value.ToString());

            listBox1.Items.Add(fullName);


            #endregion

            #region 1

            this.Traco();

            listBox1.Items.Add("Operating System Detaiils");
            OperatingSystem os = Environment.OSVersion;
            listBox1.Items.Add("OS Version: " + os.Version.ToString());
            listBox1.Items.Add("OS Platoform: " + os.Platform.ToString());
            listBox1.Items.Add("OS SP: " + os.ServicePack.ToString());
            listBox1.Items.Add("OS Version String: " + os.VersionString.ToString());

            Version ver = os.Version;
            listBox1.Items.Add("");
            listBox1.Items.Add("Major version: " + ver.Major);
            listBox1.Items.Add("Major Revision: " + ver.MajorRevision);
            listBox1.Items.Add("Minor version: " + ver.Minor);
            listBox1.Items.Add("Minor Revision: " + ver.MinorRevision);
            listBox1.Items.Add("Build: " + ver.Build);


            #endregion

            #region 2
            this.Traco();

            SystemInfo si = new SystemInfo();       //Create an object of SystemInfo class.
            si.getOperatingSystemInfo(listBox1);            //Call get operating system info method which will display operating system information.


            #endregion

            #region 3

            this.Traco();
            si.getProcessorInfo(listBox1);                  //Call get  processor info method which will display processor info.            

            #endregion

            #region 4

            this.Traco();

            ManagementClass wmiManagementProcessorClass = new ManagementClass("Win32_Processor");
            ManagementObjectCollection wmiProcessorCollection = wmiManagementProcessorClass.GetInstances();
            foreach (ManagementObject wmiProcessorObject in wmiProcessorCollection)
            {
                try
                {
                    listBox1.Items.Add(wmiProcessorObject.Properties["Name"].Value.ToString());
                }
                catch (ManagementException ex)
                {
                    // real error handling here
                    listBox1.Items.Add(ex.Message);
                }
            }


            #endregion

            #region 5

            this.Traco();
            listBox1.Items.Add(System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion().ToString());


            #endregion

            #region 6

            this.Traco();
            string componentsKeyName = "SOFTWARE\\Microsoft\\Active Setup\\Installed Components", friendlyName, version;

            // Find out in the registry anything under:
            //    HKLM\SOFTWARE\Microsoft\Active Setup\Installed Components
            // that has ".NET Framework" in the name
            RegistryKey componentsKey = Registry.LocalMachine.OpenSubKey(componentsKeyName);
            string[] instComps = componentsKey.GetSubKeyNames();
            foreach (string instComp in instComps)
            {
                RegistryKey key = componentsKey.OpenSubKey(instComp);
                friendlyName = (string)key.GetValue(null); // Gets the (Default) value from this key
                if (friendlyName != null && friendlyName.IndexOf(".NET Framework") >= 0)
                {
                    // Let's try to get any version information that's available
                    version = (string)key.GetValue("Version");
                    // If you want only the framework info with its SP level and not the
                    // other hotfix and service pack detail, uncomment this if:
                    //    if(version!=null && version.Split(',').Length>=4)
                    listBox1.Items.Add(friendlyName + (version != null ? (" (" + version + ")") : ""));
                }
            }


            #endregion

            #region 7

            this.Traco();
            //O seguinte código de programação determina as versões do Framework. NET que estão instalados em um computador. Você deve ter credenciais de administrador para executar este exemplo.
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {

                        RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                        string name = (string)versionKey.GetValue("Version", "");
                        string sp = versionKey.GetValue("SP", "").ToString();
                        string install = versionKey.GetValue("Install", "").ToString();
                        if (install == "") //no install info, ust be later
                            listBox1.Items.Add(versionKeyName + "  " + name);
                        else
                        {
                            if (sp != "" && install == "1")
                            {
                                listBox1.Items.Add(versionKeyName + "  " + name + "  SP" + sp);
                            }

                        }
                        if (name != "")
                        {
                            continue;
                        }
                        foreach (string subKeyName in versionKey.GetSubKeyNames())
                        {
                            RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                            name = (string)subKey.GetValue("Version", "");
                            if (name != "")
                                sp = subKey.GetValue("SP", "").ToString();
                            install = subKey.GetValue("Install", "").ToString();
                            if (install == "") //no install info, ust be later
                                listBox1.Items.Add(versionKeyName + "  " + name);
                            else
                            {
                                if (sp != "" && install == "1")
                                {
                                    listBox1.Items.Add("  " + subKeyName + "  " + name + "  SP" + sp);
                                }
                                else if (install == "1")
                                {
                                    listBox1.Items.Add("  " + subKeyName + "  " + name);
                                }

                            }

                        }

                    }
                }
            }
            #endregion

            #region 8

            this.Traco();
            listBox1.Items.Add(YourNameSpace.SystemInfo.FrameworkVersion);
            listBox1.Items.Add(YourNameSpace.SystemInfo.NetFrameworkInstallationPath);
            listBox1.Items.Add(YourNameSpace.SystemInfo.WindowsPath);

            #endregion

            #region 9

            this.Traco();

            listBox1.Items.Add(".Net Framework Versions");

            var hkNDP = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP", false);

            WriteKey(hkNDP, "", listBox1);
            hkNDP.Close();


            #endregion
        }
    }
}

namespace YourNameSpace
{
    public class SystemInfo
    {
        private const string FRAMEWORK_PATH = "\\Microsoft.NET\\Framework";
        private const string WINDIR1 = "windir";
        private const string WINDIR2 = "SystemRoot";

        public static string FrameworkVersion
        {
            get
            {
                try
                {
                    return getHighestVersion(NetFrameworkInstallationPath);
                }
                catch (SecurityException)
                {
                    return "Unknown";
                }
            }
        }

        private static string getHighestVersion(string installationPath)
        {
            string[] versions = Directory.GetDirectories(installationPath, "v*");
            string version = "Unknown";

            for (int i = versions.Length - 1; i >= 0; i--)
            {
                version = extractVersion(versions[i]);
                if (isNumber(version))
                    return version;
            }

            return version;
        }

        private static string extractVersion(string directory)
        {
            int startIndex = directory.LastIndexOf("\\") + 2;
            return directory.Substring(startIndex, directory.Length - startIndex);
        }

        private static bool isNumber(string str)
        {
            return new Regex(@"^[0-9]+\.?[0-9]*$").IsMatch(str);
        }

        public static string NetFrameworkInstallationPath
        {
            get { return WindowsPath + FRAMEWORK_PATH; }
        }

        public static string WindowsPath
        {
            get
            {
                string winDir = Environment.GetEnvironmentVariable(WINDIR1);
                if (String.IsNullOrEmpty(winDir))
                    winDir = Environment.GetEnvironmentVariable(WINDIR2);

                return winDir;
            }
        }
    }
}
