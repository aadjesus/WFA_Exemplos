namespace WFA_Workflow.AutorizaGridsBGMx
{
    partial class FrmAssociacaoBGMDemo2
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
            ClassLibrary1.AssociacaoBGMDemo.ColunaAutorizaBGM colunaAutorizaBGM1 = new ClassLibrary1.AssociacaoBGMDemo.ColunaAutorizaBGM();
            ClassLibrary1.AssociacaoBGMDemo.ColunaAutorizaBGM colunaAutorizaBGM2 = new ClassLibrary1.AssociacaoBGMDemo.ColunaAutorizaBGM();
            ClassLibrary1.AssociacaoBGMDemo.ColunaAutorizaBGM colunaAutorizaBGM3 = new ClassLibrary1.AssociacaoBGMDemo.ColunaAutorizaBGM();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.autorizaGridBGMx21 = new ClassLibrary1.AssociacaoBGMDemo();
            this.gridControllistaCadastrados = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControllistaAssociacao = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelContainer2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControllistaCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControllistaAssociacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.panelContainer2.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.dockPanel4.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroup1.Location = new System.Drawing.Point(0, 0);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 4;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Disponíveis"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Associados"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Disponíveis com associados"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Associados  com disponíveis")});
            this.radioGroup1.Size = new System.Drawing.Size(580, 30);
            this.radioGroup1.TabIndex = 7;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // autorizaGridBGMx21
            // 
            colunaAutorizaBGM1.Caption = "Código";
            colunaAutorizaBGM1.FieldName = "Cod";
            colunaAutorizaBGM1.FieldNameAssociado = "CodMyClass";
            colunaAutorizaBGM1.Tamanho = 50;
            colunaAutorizaBGM2.Caption = "Descrição";
            colunaAutorizaBGM2.FieldName = "Desc";
            colunaAutorizaBGM3.Caption = "Condição";
            colunaAutorizaBGM3.FieldName = "Cond";
            colunaAutorizaBGM3.FieldNameAssociado = "CondMyClass";
            this.autorizaGridBGMx21.Colunas.AddRange(new ClassLibrary1.AssociacaoBGMDemo.ColunaAutorizaBGM[] {
            colunaAutorizaBGM1,
            colunaAutorizaBGM2,
            colunaAutorizaBGM3});
            this.autorizaGridBGMx21.Dock = System.Windows.Forms.DockStyle.Top;
            this.autorizaGridBGMx21.MinimumSize = new System.Drawing.Size(500, 300);
            this.autorizaGridBGMx21.Name = "autorizaGridBGMx21";
            this.autorizaGridBGMx21.OrdenacaoAutomatica = false;
            this.autorizaGridBGMx21.Size = new System.Drawing.Size(580, 379);
            this.autorizaGridBGMx21.TabIndex = 4;
            this.autorizaGridBGMx21.Titulo = "[AutorizaGridBGMx2]";
            // 
            // gridControllistaCadastrados
            // 
            this.gridControllistaCadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControllistaCadastrados.Location = new System.Drawing.Point(0, 0);
            this.gridControllistaCadastrados.MainView = this.gridView1;
            this.gridControllistaCadastrados.Name = "gridControllistaCadastrados";
            this.gridControllistaCadastrados.Size = new System.Drawing.Size(437, 147);
            this.gridControllistaCadastrados.TabIndex = 0;
            this.gridControllistaCadastrados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControllistaCadastrados;
            this.gridView1.Name = "gridView1";
            // 
            // gridControllistaAssociacao
            // 
            this.gridControllistaAssociacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControllistaAssociacao.Location = new System.Drawing.Point(0, 0);
            this.gridControllistaAssociacao.MainView = this.gridView2;
            this.gridControllistaAssociacao.Name = "gridControllistaAssociacao";
            this.gridControllistaAssociacao.Size = new System.Drawing.Size(437, 147);
            this.gridControllistaAssociacao.TabIndex = 0;
            this.gridControllistaAssociacao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControllistaAssociacao;
            this.gridView2.Name = "gridView2";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(437, 205);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.FloatOnDblClick = false;
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.panelContainer2,
            this.dockPanel4});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("5129c0a1-03cd-4438-8ff1-b4bbe4e82deb");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(586, 200);
            this.dockPanel1.Size = new System.Drawing.Size(586, 437);
            this.dockPanel1.Text = "Opçoes";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.autorizaGridBGMx21);
            this.dockPanel1_Container.Controls.Add(this.radioGroup1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(580, 405);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panelContainer2
            // 
            this.panelContainer2.ActiveChild = this.dockPanel2;
            this.panelContainer2.Controls.Add(this.dockPanel2);
            this.panelContainer2.Controls.Add(this.dockPanel3);
            this.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.panelContainer2.FloatVertical = true;
            this.panelContainer2.ID = new System.Guid("39a694f5-009b-4aaf-8d71-cf983a736ed0");
            this.panelContainer2.Location = new System.Drawing.Point(586, 0);
            this.panelContainer2.Name = "panelContainer2";
            this.panelContainer2.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer2.Size = new System.Drawing.Size(443, 200);
            this.panelContainer2.Tabbed = true;
            this.panelContainer2.Text = "panelContainer2";
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.FloatVertical = true;
            this.dockPanel2.ID = new System.Guid("f382bba6-d307-41c7-9180-c97d1a3b6b7e");
            this.dockPanel2.Location = new System.Drawing.Point(3, 29);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(437, 147);
            this.dockPanel2.Size = new System.Drawing.Size(437, 147);
            this.dockPanel2.Text = "Cadastrados";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.gridControllistaCadastrados);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(437, 147);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel3.FloatVertical = true;
            this.dockPanel3.ID = new System.Guid("289ce3dc-ad04-498e-9a82-905de603529d");
            this.dockPanel3.Location = new System.Drawing.Point(3, 29);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(437, 147);
            this.dockPanel3.Size = new System.Drawing.Size(437, 147);
            this.dockPanel3.Text = "Associados";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.gridControllistaAssociacao);
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(437, 147);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel4.ID = new System.Guid("ec294ebf-0e19-40f4-aecd-84772615c97b");
            this.dockPanel4.Location = new System.Drawing.Point(586, 200);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.OriginalSize = new System.Drawing.Size(200, 238);
            this.dockPanel4.Size = new System.Drawing.Size(443, 237);
            this.dockPanel4.Text = "Resultado";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Controls.Add(this.gridControl3);
            this.dockPanel4_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(437, 205);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "GlobusMais_BlackClean";
            // 
            // FrmAssociacaoBGMDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 437);
            this.Controls.Add(this.dockPanel4);
            this.Controls.Add(this.panelContainer2);
            this.Controls.Add(this.dockPanel1);
            this.Name = "FrmAssociacaoBGMDemo2";
            this.Text = "FrmAutorizaGridsBGMx";
            this.Shown += new System.EventHandler(this.FrmAutorizaGridsBGMx_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControllistaCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControllistaAssociacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.panelContainer2.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.dockPanel4.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.AssociacaoBGMDemo autorizaGridBGMx21;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraGrid.GridControl gridControllistaCadastrados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControllistaAssociacao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}