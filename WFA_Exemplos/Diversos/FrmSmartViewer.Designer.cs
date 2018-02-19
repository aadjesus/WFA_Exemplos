namespace WFA_Workflow
{
    partial class FrmSmartViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // trVwTela
            // 
            this.trVwTela.Dock = System.Windows.Forms.DockStyle.Left;
            this.trVwTela.Location = new System.Drawing.Point(0, 26);
            this.trVwTela.Name = "trVwTela";
            this.trVwTela.Size = new System.Drawing.Size(328, 501);
            this.trVwTela.TabIndex = 0;
            this.trVwTela.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(328, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 501);
            this.panel1.TabIndex = 1;
            // 
            // FrmSmartViewer
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trVwTela);
            this.Name = "FrmSmartViewer";
            this.Text = "Smart Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FrmSmartViewer_Shown);
            this.Controls.SetChildIndex(this.trVwTela, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trVwTela;
        private System.Windows.Forms.Panel panel1;
    }
}