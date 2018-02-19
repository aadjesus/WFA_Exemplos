namespace WFA_Workflow
{
    partial class SelecionaDescricaoBGMDemo
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
            this.lblCtrlColunaDefault = new DevExpress.XtraEditors.LabelControl();
            this.dtStSelecionaColuna = new System.Data.DataSet();
            this.dtTblSelecionaColuna = new System.Data.DataTable();
            this.dtClmCaption = new System.Data.DataColumn();
            this.dtClmnFieldName = new System.Data.DataColumn();
            this.grdLkUpEdtColunaDefault = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtStSelecionaColuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTblSelecionaColuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLkUpEdtColunaDefault.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCtrlColunaDefault
            // 
            this.lblCtrlColunaDefault.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCtrlColunaDefault.Location = new System.Drawing.Point(0, 0);
            this.lblCtrlColunaDefault.Name = "lblCtrlColunaDefault";
            this.lblCtrlColunaDefault.Size = new System.Drawing.Size(70, 13);
            this.lblCtrlColunaDefault.TabIndex = 0;
            this.lblCtrlColunaDefault.Tag = "";
            this.lblCtrlColunaDefault.Text = "Coluna default";
            // 
            // dtStSelecionaColuna
            // 
            this.dtStSelecionaColuna.DataSetName = "NewDataSet";
            this.dtStSelecionaColuna.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTblSelecionaColuna});
            // 
            // dtTblSelecionaColuna
            // 
            this.dtTblSelecionaColuna.Columns.AddRange(new System.Data.DataColumn[] {
            this.dtClmCaption,
            this.dtClmnFieldName});
            this.dtTblSelecionaColuna.TableName = "TblSelecionaColuna";
            // 
            // dtClmCaption
            // 
            this.dtClmCaption.Caption = "Titulo";
            this.dtClmCaption.ColumnName = "Caption";
            // 
            // dtClmnFieldName
            // 
            this.dtClmnFieldName.Caption = "Valor";
            this.dtClmnFieldName.ColumnName = "FieldName";
            // 
            // grdLkUpEdtColunaDefault
            // 
            this.grdLkUpEdtColunaDefault.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdLkUpEdtColunaDefault.EditValue = " ";
            this.grdLkUpEdtColunaDefault.Location = new System.Drawing.Point(0, 19);
            this.grdLkUpEdtColunaDefault.Name = "grdLkUpEdtColunaDefault";
            this.grdLkUpEdtColunaDefault.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdLkUpEdtColunaDefault.Properties.DataSource = this.dtStSelecionaColuna;
            this.grdLkUpEdtColunaDefault.Properties.DisplayMember = "FieldName";
            this.grdLkUpEdtColunaDefault.Properties.ValueMember = "Caption";
            this.grdLkUpEdtColunaDefault.Properties.View = this.gridLookUpEdit1View;
            this.grdLkUpEdtColunaDefault.Size = new System.Drawing.Size(272, 20);
            this.grdLkUpEdtColunaDefault.TabIndex = 1;
            this.grdLkUpEdtColunaDefault.TabStop = false;
            this.grdLkUpEdtColunaDefault.EditValueChanged += new System.EventHandler(this.grdLkUpEdtColunaDefault_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            this.gridLookUpEdit1View.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Titulo";
            this.gridColumn1.FieldName = "Caption";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Valor";
            this.gridColumn2.FieldName = "FieldName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // SelecionaDescricaoBGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdLkUpEdtColunaDefault);
            this.Controls.Add(this.lblCtrlColunaDefault);
            this.MinimumSize = new System.Drawing.Size(100, 39);
            this.Name = "SelecionaDescricaoBGM";
            this.Size = new System.Drawing.Size(272, 39);
            this.Load += new System.EventHandler(this.SelecionaColunaBGM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtStSelecionaColuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTblSelecionaColuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLkUpEdtColunaDefault.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCtrlColunaDefault;
        private System.Data.DataSet dtStSelecionaColuna;
        private System.Data.DataTable dtTblSelecionaColuna;
        private System.Data.DataColumn dtClmCaption;
        private System.Data.DataColumn dtClmnFieldName;
        private DevExpress.XtraEditors.GridLookUpEdit grdLkUpEdtColunaDefault;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
