﻿namespace WFA_Exemplos.ButtonEditBGM
{
    partial class FrmButtonEditBGM
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
            this.buttonEditBGM1 = new FGlobus.Componentes.WinForms.ButtonEditBGM(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditBGM1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditBGM1
            // 
            this.buttonEditBGM1.Location = new System.Drawing.Point(53, 78);
            this.buttonEditBGM1.Name = "buttonEditBGM1";
            this.buttonEditBGM1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditBGM1.Size = new System.Drawing.Size(163, 20);
            this.buttonEditBGM1.TabIndex = 0;
            // 
            // FrmButtonEditBGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 405);
            this.Controls.Add(this.buttonEditBGM1);
            this.KeyPreview = true;
            this.Name = "FrmButtonEditBGM";
            this.Text = "FrmButtonEditBGM";
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditBGM1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FGlobus.Componentes.WinForms.ButtonEditBGM buttonEditBGM1;






























    }
}