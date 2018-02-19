namespace WFA_Workflow.AutorizaGridsBGMx
{
    partial class FrmAssociacaoBGMDemo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssociacaoBGMDemo1));
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM1 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM2 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM3 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM4 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            this.associacaoBGM1 = new FGlobus.Componentes.WinForms.AssociacaoBGM();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlBotoesMFCadastro)).BeginInit();
            this.pnlCtrlBotoesMFCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlTelaMFCadastro)).BeginInit();
            this.pnlCtrlTelaMFCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCtrlBotoesMFCadastro
            // 
            this.pnlCtrlBotoesMFCadastro.Location = new System.Drawing.Point(0, 309);
            // 
            // pnlCtrlTelaMFCadastro
            // 
            this.pnlCtrlTelaMFCadastro.Controls.Add(this.associacaoBGM1);
            this.pnlCtrlTelaMFCadastro.Size = new System.Drawing.Size(494, 278);
            // 
            // smpBtnBGMExcluirMFCadastro
            // 
            this.smpBtnBGMExcluirMFCadastro.Image = ((System.Drawing.Image)(resources.GetObject("smpBtnBGMExcluirMFCadastro.Image")));
            this.smpBtnBGMExcluirMFCadastro.Location = new System.Drawing.Point(346, 6);
            // 
            // smpBtnBGMLimparMFCadastro
            // 
            this.smpBtnBGMLimparMFCadastro.Image = ((System.Drawing.Image)(resources.GetObject("smpBtnBGMLimparMFCadastro.Image")));
            this.smpBtnBGMLimparMFCadastro.Location = new System.Drawing.Point(198, 6);
            // 
            // smpBtnBGMGravarMFCadastro
            // 
            this.smpBtnBGMGravarMFCadastro.Image = ((System.Drawing.Image)(resources.GetObject("smpBtnBGMGravarMFCadastro.Image")));
            this.smpBtnBGMGravarMFCadastro.Location = new System.Drawing.Point(50, 6);
            // 
            // associacaoBGM1
            // 
            colunaAssociacaoBGM1.Caption = "ID";
            colunaAssociacaoBGM1.FieldName = "ID";
            colunaAssociacaoBGM1.VisualizarNosLayouts = "";
            colunaAssociacaoBGM2.Caption = "Código";
            colunaAssociacaoBGM2.FieldName = "Cod";
            colunaAssociacaoBGM3.Caption = "Descrição";
            colunaAssociacaoBGM3.FieldName = "Desc";
            colunaAssociacaoBGM4.Caption = "Apelido";
            colunaAssociacaoBGM4.FieldName = "Ape";
            colunaAssociacaoBGM4.VisualizarNosLayouts = "A;H";
            this.associacaoBGM1.Colunas.AddRange(new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM[] {
            colunaAssociacaoBGM1,
            colunaAssociacaoBGM2,
            colunaAssociacaoBGM3,
            colunaAssociacaoBGM4});
            this.associacaoBGM1.Location = new System.Drawing.Point(12, 6);
            this.associacaoBGM1.Name = "associacaoBGM1";
            this.associacaoBGM1.Obrigatorio = true;
            this.associacaoBGM1.Size = new System.Drawing.Size(470, 271);
            this.associacaoBGM1.TabIndex = 0;
            this.associacaoBGM1.Titulo = "Demonstração controle associação BGM";
            this.associacaoBGM1.ClickBotaoConsultar += new FGlobus.Componentes.WinForms.AssociacaoBGMConsultarEventHandler(this.associacaoBGM1_ClickBotaoConsultar);
            // 
            // FrmAssociacaoBGMDemo1
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 352);
            this.Name = "FrmAssociacaoBGMDemo1";
            this.Text = "Demonstração controle associação BGM";
            this.HabilitarBotoes += new FGlobus.Componentes.WinForms.MasterFormEventHandler(this.FrmAssociacaoBGMDemo1_HabilitarBotoes);
            this.Shown += new System.EventHandler(this.FrmAssociacaoBGMDemo1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlBotoesMFCadastro)).EndInit();
            this.pnlCtrlBotoesMFCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtrlTelaMFCadastro)).EndInit();
            this.pnlCtrlTelaMFCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FGlobus.Componentes.WinForms.AssociacaoBGM associacaoBGM1;

    }
}