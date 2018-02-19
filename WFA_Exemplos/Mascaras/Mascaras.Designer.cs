namespace WFA_Workflow.Mascaras
{
    partial class Mascaras
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdCtrlMascaras = new DevExpress.XtraGrid.GridControl();
            this.grdVwMascaras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdClmDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdClmExemplo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlMascaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwMascaras)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrlMascaras
            // 
            this.grdCtrlMascaras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlMascaras.Location = new System.Drawing.Point(0, 0);
            this.grdCtrlMascaras.MainView = this.grdVwMascaras;
            this.grdCtrlMascaras.Name = "grdCtrlMascaras";
            this.grdCtrlMascaras.Size = new System.Drawing.Size(605, 206);
            this.grdCtrlMascaras.TabIndex = 0;
            this.grdCtrlMascaras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwMascaras});
            // 
            // grdVwMascaras
            // 
            this.grdVwMascaras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdClmDescricao,
            this.grdClmExemplo});
            this.grdVwMascaras.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdVwMascaras.GridControl = this.grdCtrlMascaras;
            this.grdVwMascaras.Name = "grdVwMascaras";
            this.grdVwMascaras.OptionsBehavior.Editable = false;
            this.grdVwMascaras.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdVwMascaras.OptionsView.ShowGroupPanel = false;
            // 
            // grdClmDescricao
            // 
            this.grdClmDescricao.Caption = "Tipo";
            this.grdClmDescricao.FieldName = "Descricao";
            this.grdClmDescricao.Name = "grdClmDescricao";
            this.grdClmDescricao.Visible = true;
            this.grdClmDescricao.VisibleIndex = 0;
            // 
            // grdClmExemplo
            // 
            this.grdClmExemplo.Caption = "Exemplo";
            this.grdClmExemplo.FieldName = "Exemplo";
            this.grdClmExemplo.Name = "grdClmExemplo";
            this.grdClmExemplo.Visible = true;
            this.grdClmExemplo.VisibleIndex = 1;
            // 
            // Mascaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdCtrlMascaras);
            this.Name = "Mascaras";
            this.Size = new System.Drawing.Size(605, 206);
            this.Load += new System.EventHandler(this.Mascaras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlMascaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwMascaras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn grdClmDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn grdClmExemplo;
        internal DevExpress.XtraGrid.GridControl grdCtrlMascaras;
        internal DevExpress.XtraGrid.Views.Grid.GridView grdVwMascaras;
    }
}
