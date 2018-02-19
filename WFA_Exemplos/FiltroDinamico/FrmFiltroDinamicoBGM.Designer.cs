namespace Globus5.WPF.Comum.Cadastros
{
    partial class FrmFiltroDinamicoBGM
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
            this.filtroDinamicoBGM1 = new FGlobus.Componentes.WinForms.FiltroDinamicoBGM();
            this.repositoryItem1 = new DevExpress.XtraEditors.Repository.RepositoryItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // filtroDinamicoBGM1
            // 
            this.filtroDinamicoBGM1.Formulario.Cadastro = "Cargas.Estados";
            this.filtroDinamicoBGM1.Formulario.ColunaRetorno = "CodigoUf";
            this.filtroDinamicoBGM1.Formulario.Pesquisa = "Cargas.Estado";
            this.filtroDinamicoBGM1.Location = new System.Drawing.Point(353, 50);
            this.filtroDinamicoBGM1.Name = "filtroDinamicoBGM1";
            this.filtroDinamicoBGM1.Size = new System.Drawing.Size(305, 68);
            this.filtroDinamicoBGM1.TabIndex = 12;
            this.filtroDinamicoBGM1.Titulo = "[Informe o título]";
            // 
            // repositoryItem1
            // 
            this.repositoryItem1.Name = "repositoryItem1";
            // 
            // FrmFiltroDinamicoBGM
            // 
            this.ClientSize = new System.Drawing.Size(1230, 559);
            this.Controls.Add(this.filtroDinamicoBGM1);
            this.KeyPreview = true;
            this.Name = "FrmFiltroDinamicoBGM";
            this.Text = "FrmFiltroDinamicoBGM";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FGlobus.Componentes.WinForms.ButtonEditBGM buttonEditBGM1;
        private FGlobus.Componentes.WinForms.FiltroDinamicoBGM filtroDinamicoBGM1;
        private DevExpress.XtraEditors.Repository.RepositoryItem repositoryItem1;

    }
}
