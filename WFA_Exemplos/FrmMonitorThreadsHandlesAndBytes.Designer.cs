namespace WFA_Workflow
{
    partial class FrmMonitorThreadsHandlesAndBytes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ssStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsCPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRAM = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.ssStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatusBar
            // 
            this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCPU,
            this.tsRAM,
            this.tsPage});
            this.ssStatusBar.Location = new System.Drawing.Point(0, 240);
            this.ssStatusBar.Name = "ssStatusBar";
            this.ssStatusBar.ShowItemToolTips = true;
            this.ssStatusBar.Size = new System.Drawing.Size(530, 22);
            this.ssStatusBar.SizingGrip = false;
            this.ssStatusBar.TabIndex = 3;
            this.ssStatusBar.Text = "statusStrip1";
            // 
            // tsCPU
            // 
            this.tsCPU.AutoSize = false;
            this.tsCPU.AutoToolTip = true;
            this.tsCPU.BackColor = System.Drawing.SystemColors.Control;
            this.tsCPU.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsCPU.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsCPU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsCPU.Name = "tsCPU";
            this.tsCPU.Size = new System.Drawing.Size(40, 17);
            this.tsCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsCPU.ToolTipText = "CPU Utilization";
            // 
            // tsRAM
            // 
            this.tsRAM.AutoSize = false;
            this.tsRAM.AutoToolTip = true;
            this.tsRAM.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsRAM.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsRAM.Name = "tsRAM";
            this.tsRAM.Size = new System.Drawing.Size(40, 17);
            this.tsRAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsRAM.ToolTipText = "Commit Charge";
            // 
            // tsPage
            // 
            this.tsPage.AutoSize = false;
            this.tsPage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsPage.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsPage.Name = "tsPage";
            this.tsPage.Size = new System.Drawing.Size(40, 17);
            this.tsPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsPage.ToolTipText = "Page File Usage";
            // 
            // tTimer
            // 
            this.tTimer.Interval = 2000;
            this.tTimer.Tick += new System.EventHandler(this.tTimer_Tick);
            // 
            // FrmMonitorThreadsHandlesAndBytes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 262);
            this.Controls.Add(this.ssStatusBar);
            this.Name = "FrmMonitorThreadsHandlesAndBytes";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ssStatusBar.ResumeLayout(false);
            this.ssStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsCPU;
        private System.Windows.Forms.ToolStripStatusLabel tsRAM;
        private System.Windows.Forms.ToolStripStatusLabel tsPage;
        private System.Windows.Forms.Timer tTimer;

    }
}