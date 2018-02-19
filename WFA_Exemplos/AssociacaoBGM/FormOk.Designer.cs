namespace WFA_Exemplos.AssociacaoBGM
{
    partial class FormOk
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
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM1 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM2 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOk));
            this.associacaoBGM1 = new FGlobus.Componentes.WinForms.AssociacaoBGM();
            this.SuspendLayout();
            // 
            // associacaoBGM1
            // 
            colunaAssociacaoBGM1.Caption = "ColunaAssociacaoBGM1";
            colunaAssociacaoBGM1.FieldName = "ColunaAssociacaoBGM1";
            colunaAssociacaoBGM2.Caption = "ColunaAssociacaoBGM2";
            colunaAssociacaoBGM2.FieldName = "ColunaAssociacaoBGM2";
            this.associacaoBGM1.Colunas.AddRange(new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM[] {
            colunaAssociacaoBGM1,
            colunaAssociacaoBGM2});
            resources.ApplyResources(this.associacaoBGM1, "associacaoBGM1");
            this.associacaoBGM1.Name = "associacaoBGM1";
            this.associacaoBGM1.Titulo = "[AssociacaoBGM]";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.associacaoBGM1);
            this.Name = "Form1";
            this.Controls.SetChildIndex(this.associacaoBGM1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private FGlobus.Componentes.WinForms.AssociacaoBGM associacaoBGM1;







    }
}