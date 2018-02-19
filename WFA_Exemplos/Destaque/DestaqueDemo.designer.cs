namespace FGlobus.Componentes.WinForms
{
    partial class DestaqueDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestaqueDemo));
            this.lblCtrlTitulo = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.lblCtrlValor = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCtrlTitulo
            // 
            this.lblCtrlTitulo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrlTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblCtrlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCtrlTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblCtrlTitulo.Name = "lblCtrlTitulo";
            this.lblCtrlTitulo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCtrlTitulo.Size = new System.Drawing.Size(81, 31);
            this.lblCtrlTitulo.TabIndex = 2;
            this.lblCtrlTitulo.Text = "Titulo";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(70, 70);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "DestaqueX_Moeda.png");
            this.imageCollection1.Images.SetKeyName(1, "DestaqueX_Data.jpg");
            this.imageCollection1.Images.SetKeyName(2, "calendario2.png");
            this.imageCollection1.Images.SetKeyName(3, "calendario1.gif");
            this.imageCollection1.Images.SetKeyName(4, "calendar-icon (1).png");
            this.imageCollection1.Images.SetKeyName(5, "calendar-icon (2).png");
            this.imageCollection1.Images.SetKeyName(6, "Calendar-icon.png");
            this.imageCollection1.Images.SetKeyName(7, "DestaqueX_Moeda.png");
            this.imageCollection1.Images.SetKeyName(8, "Destaque_Text.png");
            this.imageCollection1.Images.SetKeyName(9, "Destaque_Data.png");
            this.imageCollection1.Images.SetKeyName(10, "Destaque_Moeda.png");
            this.imageCollection1.Images.SetKeyName(11, "Destaque_percentage.png");
            this.imageCollection1.Images.SetKeyName(12, "Destaque_Text.png");
            // 
            // lblCtrlValor
            // 
            this.lblCtrlValor.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrlValor.Appearance.Font = new System.Drawing.Font("Tahoma", 31F, System.Drawing.FontStyle.Bold);
            this.lblCtrlValor.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCtrlValor.Appearance.ImageIndex = 11;
            this.lblCtrlValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCtrlValor.Location = new System.Drawing.Point(0, 31);
            this.lblCtrlValor.Name = "lblCtrlValor";
            this.lblCtrlValor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCtrlValor.Size = new System.Drawing.Size(113, 49);
            this.lblCtrlValor.TabIndex = 3;
            this.lblCtrlValor.Text = "Valor";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lblCtrlValor);
            this.panelControl2.Controls.Add(this.lblCtrlTitulo);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(85, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(127, 85);
            this.panelControl2.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(85, 85);
            this.pictureEdit1.TabIndex = 7;
            // 
            // DestaqueX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.pictureEdit1);
            this.DoubleBuffered = true;
            this.Name = "DestaqueX";
            this.Size = new System.Drawing.Size(212, 85);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.LabelControl lblCtrlValor;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public DevExpress.XtraEditors.LabelControl lblCtrlTitulo;

    }
}
