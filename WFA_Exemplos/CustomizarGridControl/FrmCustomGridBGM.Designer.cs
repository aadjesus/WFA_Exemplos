namespace WFA_Exemplos.CustomizarGridControl
{
    partial class FrmCustomGridBGM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomGridBGM));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.objectView1 = new FGlobus.Componentes.WinForms.ObjectView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customizarGridControlDemo1 = new WFA_Workflow.CustomizarGridControl.CustomizarGridControlDemo();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(42, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(954, 492);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.bandedGridView1;
            this.repositoryItemGridLookUpEdit1.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.BandedView;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView2;
            this.repositoryItemSearchLookUpEdit1.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name1", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name2", "Name2"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name3", "Name3"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name4", "Name4"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name5", "Name5"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name6", "Name6"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name7", "Name7")});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.customizarGridControlDemo1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(998, 496);
            this.panelControl1.TabIndex = 2;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(389, 524);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Size = new System.Drawing.Size(173, 20);
            this.spinEdit1.TabIndex = 3;
            this.spinEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spinEdit1_EditValueChanging);
            // 
            // objectView1
            // 
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("CodigoEmpresa", "CodigoEmpresa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("CodigoFl", "CodigoFl", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.CodigoGa", "Garagem_CodigoGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.CodigoUf", "Garagem_CodigoUf", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.NomeGa", "Garagem_NomeGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.EnderecoGa", "Garagem_EnderecoGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.NumeroEndGa", "Garagem_NumeroEndGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.ComplendGa", "Garagem_ComplendGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.CepGa", "Garagem_CepGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.CidadeGa", "Garagem_CidadeGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.BairroGa", "Garagem_BairroGa", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.CodMunic", "Garagem_CodMunic", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.MicroRegiao_1", "Garagem_MicroRegiao_1", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.MicroRegiao_2", "Garagem_MicroRegiao_2", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.MicroRegiao_3", "Garagem_MicroRegiao_3", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.MicroRegiao_4", "Garagem_MicroRegiao_4", false));
            this.objectView1.Columns.Add(new FGlobus.Componentes.WinForms.ObjectViewColumn("Garagem.AchouRegistro", "Garagem_AchouRegistro", false));
            this.objectView1.DataSource = ((System.Collections.ICollection)(resources.GetObject("objectView1.DataSource")));
            this.objectView1.Type = typeof(Globus5.WPF.Comum.ws.controle.eGaragemAutorizada);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "Codigo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "Descricao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "Grupo ";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "Valor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // customizarGridControlDemo1
            // 
            this.customizarGridControlDemo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.customizarGridControlDemo1.GridControl = this.gridControl1;
            this.customizarGridControlDemo1.Location = new System.Drawing.Point(2, 2);
            this.customizarGridControlDemo1.Name = "customizarGridControlDemo1";
            this.customizarGridControlDemo1.Size = new System.Drawing.Size(40, 492);
            this.customizarGridControlDemo1.TabIndex = 1;
            // 
            // FrmCustomGridBGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 556);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCustomGridBGM";
            this.Text = "FrmCustomizarGridControlBGM";
            this.Load += new System.EventHandler(this.FrmCustomGridBGM_Load);
            this.Shown += new System.EventHandler(this.FrmCustomGridBGM_Shown);
            this.Enter += new System.EventHandler(this.FrmCustomGridBGM_Enter);
            this.Leave += new System.EventHandler(this.FrmCustomGridBGM_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private FGlobus.Componentes.WinForms.ObjectView objectView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private WFA_Workflow.CustomizarGridControl.CustomizarGridControlDemo customizarGridControlDemo1;
    }
}