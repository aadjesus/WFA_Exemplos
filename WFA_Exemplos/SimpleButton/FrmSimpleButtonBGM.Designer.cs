using FGlobus.Componentes.WinForms;
namespace WFA_Workflow.SimpleButton
{
    partial class FrmSimpleButtonBGM
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
            this.simpleButtonBGMX1 = new SimpleButtonBGM();
            this.SuspendLayout();
            // 
            // simpleButtonBGMX1
            // 
            this.simpleButtonBGMX1.Location = new System.Drawing.Point(43, 45);
            this.simpleButtonBGMX1.Name = "simpleButtonBGMX1";
            this.simpleButtonBGMX1.Size = new System.Drawing.Size(143, 60);
            this.simpleButtonBGMX1.TabIndex = 0;
            this.simpleButtonBGMX1.Text = "simpleButtonBGMX1";
            // 
            // FrmSimpleButtonBGMX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.simpleButtonBGMX1);
            this.Name = "FrmSimpleButtonBGMX";
            this.Text = "FrmSimpleButtonBGMX";
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButtonBGM simpleButtonBGMX1;
    }
}