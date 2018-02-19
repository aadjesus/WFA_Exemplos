namespace WFA_Workflow.Shortcut
{
    partial class FrmSimpleButtonComShortcut
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
            this.simpleButtonComShortcut1 = new WFA_Workflow.Shortcut.SimpleButtonComShortcut(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.simpleButtonComShortcut2 = new WFA_Workflow.Shortcut.SimpleButtonComShortcut(this.components);
            this.simpleButtonComShortcut3 = new WFA_Workflow.Shortcut.SimpleButtonComShortcut(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonComShortcut1
            // 
            this.simpleButtonComShortcut1.BaraManager = this.barManager1;
            this.simpleButtonComShortcut1.Location = new System.Drawing.Point(19, 65);
            this.simpleButtonComShortcut1.Name = "simpleButtonComShortcut1";
            this.simpleButtonComShortcut1.Shortcut = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.simpleButtonComShortcut1.Size = new System.Drawing.Size(165, 23);
            this.simpleButtonComShortcut1.TabIndex = 0;
            this.simpleButtonComShortcut1.Text = "Ctrl+0";
            this.simpleButtonComShortcut1.Click += new System.EventHandler(this.simpleButtonComShortcut1_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(284, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 262);
            this.barDockControlBottom.Size = new System.Drawing.Size(284, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 262);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(284, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 262);
            // 
            // simpleButtonComShortcut2
            // 
            this.simpleButtonComShortcut2.BaraManager = this.barManager1;
            this.simpleButtonComShortcut2.Location = new System.Drawing.Point(19, 94);
            this.simpleButtonComShortcut2.Name = "simpleButtonComShortcut2";
            this.simpleButtonComShortcut2.Shortcut = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.simpleButtonComShortcut2.Size = new System.Drawing.Size(165, 23);
            this.simpleButtonComShortcut2.TabIndex = 1;
            this.simpleButtonComShortcut2.Text = "Ctrl+Shift+1";
            this.simpleButtonComShortcut2.Click += new System.EventHandler(this.simpleButtonComShortcut1_Click);
            // 
            // simpleButtonComShortcut3
            // 
            this.simpleButtonComShortcut3.BaraManager = this.barManager1;
            this.simpleButtonComShortcut3.Location = new System.Drawing.Point(19, 123);
            this.simpleButtonComShortcut3.Name = "simpleButtonComShortcut3";
            this.simpleButtonComShortcut3.Shortcut = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.D2)));
            this.simpleButtonComShortcut3.Size = new System.Drawing.Size(165, 23);
            this.simpleButtonComShortcut3.TabIndex = 2;
            this.simpleButtonComShortcut3.Text = "Shift+2";
            this.simpleButtonComShortcut3.Click += new System.EventHandler(this.simpleButtonComShortcut1_Click);
            // 
            // FrmSimpleButtonComShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.simpleButtonComShortcut3);
            this.Controls.Add(this.simpleButtonComShortcut2);
            this.Controls.Add(this.simpleButtonComShortcut1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSimpleButtonComShortcut";
            this.Text = "FrmSimpleButtonComShortcut";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButtonComShortcut simpleButtonComShortcut1;
        private SimpleButtonComShortcut simpleButtonComShortcut2;
        private SimpleButtonComShortcut simpleButtonComShortcut3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}