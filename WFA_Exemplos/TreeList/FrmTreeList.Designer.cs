namespace WFA_Exemplos.TreeList
{
    partial class FrmTreeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeList));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imgClctnSmartViewer = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClctnSmartViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Appearance.HideSelectionRow.Image = global::WFA_Exemplos.Properties.Resources.Agenda;
            this.treeList1.Appearance.HideSelectionRow.Options.UseImage = true;
            this.treeList1.Appearance.SelectedRow.Image = global::WFA_Exemplos.Properties.Resources.About_LogoGlobus_25x25;
            this.treeList1.Appearance.SelectedRow.Options.UseImage = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "Codigo";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.ParentFieldName = "ParentCodigo";
            this.treeList1.SelectImageList = this.imgClctnSmartViewer;
            this.treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treeList1.Size = new System.Drawing.Size(771, 598);
            this.treeList1.TabIndex = 0;
            this.treeList1.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.treeList1_GetSelectImage);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "Codigo";
            this.treeListColumn1.MinWidth = 53;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "ParentCodigo";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // imgClctnSmartViewer
            // 
            this.imgClctnSmartViewer.ImageSize = new System.Drawing.Size(18, 18);
            this.imgClctnSmartViewer.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgClctnSmartViewer.ImageStream")));
            this.imgClctnSmartViewer.Images.SetKeyName(0, "SmartViewer_PastaFechada.png");
            this.imgClctnSmartViewer.Images.SetKeyName(1, "SmartViewer_PastaAberta.png");
            this.imgClctnSmartViewer.Images.SetKeyName(2, "SmartViewer_Branco.png");
            // 
            // FrmTreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 598);
            this.Controls.Add(this.treeList1);
            this.Name = "FrmTreeList";
            this.Text = "FrmTreeList";
            this.Shown += new System.EventHandler(this.FrmTreeList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClctnSmartViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.Utils.ImageCollection imgClctnSmartViewer;
    }
}