namespace WFA_Workflow.SelecionaDescricao
{
    partial class ColunasSelecionaDescricaoDemo
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
            this.grdCtrlColunas = new DevExpress.XtraGrid.GridControl();
            this.grdVwColunas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCtrlColunas
            // 
            this.grdCtrlColunas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlColunas.Location = new System.Drawing.Point(0, 0);
            this.grdCtrlColunas.MainView = this.grdVwColunas;
            this.grdCtrlColunas.Name = "grdCtrlColunas";
            this.grdCtrlColunas.Size = new System.Drawing.Size(307, 220);
            this.grdCtrlColunas.TabIndex = 0;
            this.grdCtrlColunas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwColunas});
            // 
            // grdVwColunas
            // 
            this.grdVwColunas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grdVwColunas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdVwColunas.GridControl = this.grdCtrlColunas;
            this.grdVwColunas.Name = "grdVwColunas";
            this.grdVwColunas.OptionsBehavior.Editable = false;
            this.grdVwColunas.OptionsView.ShowGroupPanel = false;
            this.grdVwColunas.OptionsView.ShowIndicator = false;
            this.grdVwColunas.DoubleClick += new System.EventHandler(this.grdVwColunas_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Caption";
            this.gridColumn1.FieldName = "Caption";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FieldName";
            this.gridColumn2.FieldName = "FieldName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // ColunasSelecionaDescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdCtrlColunas);
            this.Name = "ColunasSelecionaDescricao";
            this.Size = new System.Drawing.Size(307, 220);
            this.Load += new System.EventHandler(this.ColunasSelecionaDescricao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwColunas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCtrlColunas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwColunas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;

    }
}
