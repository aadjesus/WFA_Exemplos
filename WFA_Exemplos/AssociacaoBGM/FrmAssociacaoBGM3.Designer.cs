namespace WFA_Workflow.AssociacaoBGM
{
    partial class FrmAssociacaoBGM3
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
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM1 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM2 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM3 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM4 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM5 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM6 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM colunaAssociacaoBGM7 = new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM();
            this.button1 = new System.Windows.Forms.Button();
            this.associacaoBGM1 = new FGlobus.Componentes.WinForms.AssociacaoBGM();
            this.cmbBxEdtTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCtrZona = new FGlobus.Componentes.WinForms.LabelControlBGM(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBxEdtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(901, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // associacaoBGM1
            // 
            colunaAssociacaoBGM1.Banda = "Emp\\Fil\\Gar";
            colunaAssociacaoBGM1.Caption = "Empresa";
            colunaAssociacaoBGM1.FieldName = "Empresa";
            colunaAssociacaoBGM2.Banda = "Emp\\Fil\\Gar";
            colunaAssociacaoBGM2.Caption = "Filial";
            colunaAssociacaoBGM2.FieldName = "Filial";
            colunaAssociacaoBGM3.Banda = "Emp\\Fil\\Gar";
            colunaAssociacaoBGM3.Caption = "Garagem";
            colunaAssociacaoBGM3.FieldName = "Garagem";
            colunaAssociacaoBGM4.Caption = "Placa";
            colunaAssociacaoBGM4.FieldName = "Placa";
            colunaAssociacaoBGM5.Caption = "Prefixo";
            colunaAssociacaoBGM5.FieldName = "Prefixo";
            colunaAssociacaoBGM5.FieldNameAssociado = "Prefixo";
            colunaAssociacaoBGM6.Caption = "Condicao";
            colunaAssociacaoBGM6.FieldName = "Condicao";
            colunaAssociacaoBGM7.Caption = "MyEnum";
            colunaAssociacaoBGM7.FieldName = "MyEnum";
            this.associacaoBGM1.Colunas.AddRange(new FGlobus.Componentes.WinForms.AssociacaoBGM.ColunaAssociacaoBGM[] {
            colunaAssociacaoBGM1,
            colunaAssociacaoBGM2,
            colunaAssociacaoBGM3,
            colunaAssociacaoBGM4,
            colunaAssociacaoBGM5,
            colunaAssociacaoBGM6,
            colunaAssociacaoBGM7});
            this.associacaoBGM1.LayOut = FGlobus.Componentes.WinForms.AssociacaoBGM.eLayOut.Horizontal;
            this.associacaoBGM1.Location = new System.Drawing.Point(12, 12);
            this.associacaoBGM1.Name = "associacaoBGM1";
            this.associacaoBGM1.Size = new System.Drawing.Size(865, 433);
            this.associacaoBGM1.TabIndex = 0;
            this.associacaoBGM1.TipoCondicaoItemAssociado = FGlobus.Componentes.WinForms.AssociacaoBGM.eTipoCondicaoItemAssociado.Bloquear;
            this.associacaoBGM1.Titulo = "Veículos";
            // 
            // cmbBxEdtTipo
            // 
            this.cmbBxEdtTipo.EditValue = "";
            this.cmbBxEdtTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBxEdtTipo.Location = new System.Drawing.Point(901, 34);
            this.cmbBxEdtTipo.Name = "cmbBxEdtTipo";
            this.cmbBxEdtTipo.Properties.AutoComplete = false;
            this.cmbBxEdtTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBxEdtTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBxEdtTipo.ShowToolTips = false;
            this.cmbBxEdtTipo.Size = new System.Drawing.Size(122, 20);
            this.cmbBxEdtTipo.TabIndex = 4;
            // 
            // lblCtrZona
            // 
            this.lblCtrZona.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblCtrZona.Controle = this.cmbBxEdtTipo;
            this.lblCtrZona.Location = new System.Drawing.Point(901, 15);
            this.lblCtrZona.Name = "lblCtrZona";
            this.lblCtrZona.Size = new System.Drawing.Size(44, 13);
            this.lblCtrZona.TabIndex = 11;
            this.lblCtrZona.Text = "Condição";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(901, 149);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(362, 232);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FrmAssociacaoBGM3
            // 
            this.ClientSize = new System.Drawing.Size(1331, 473);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lblCtrZona);
            this.Controls.Add(this.cmbBxEdtTipo);
            this.Controls.Add(this.associacaoBGM1);
            this.Controls.Add(this.button1);
            this.Name = "FrmAssociacaoBGM3";
            this.Shown += new System.EventHandler(this.FrmAssociacaoBGM3_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBxEdtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private FGlobus.Componentes.WinForms.AssociacaoBGM associacaoBGM1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBxEdtTipo;
        private FGlobus.Componentes.WinForms.LabelControlBGM lblCtrZona;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;











    }
}