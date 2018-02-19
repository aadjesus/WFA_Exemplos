namespace WFA_Workflow
{
    partial class FrmWorkflow
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
            this.trVwTela = new System.Windows.Forms.TreeView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WFA_Workflow.Workflow.uCtrlWorkflow();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trVwTela
            // 
            this.trVwTela.Dock = System.Windows.Forms.DockStyle.Left;
            this.trVwTela.Location = new System.Drawing.Point(0, 0);
            this.trVwTela.Name = "trVwTela";
            this.trVwTela.Size = new System.Drawing.Size(404, 557);
            this.trVwTela.TabIndex = 1;
            this.trVwTela.DoubleClick += new System.EventHandler(this.trVwTela_DoubleClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.elementHost1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(404, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(638, 557);
            this.panelControl1.TabIndex = 2;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(53, 32);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(556, 490);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl11;
            // 
            // FrmWorkflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 557);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.trVwTela);
            this.Name = "FrmWorkflow";
            this.Text = "FrmWorkflow";
            this.Load += new System.EventHandler(this.FrmWorkflow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trVwTela;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Workflow.uCtrlWorkflow userControl11;
    }
}