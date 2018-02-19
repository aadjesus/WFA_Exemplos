namespace WFA_Workflow.Destaque
{
    partial class FrmDestaque
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblCtrlValor = new DevExpress.XtraEditors.LabelControl();
            this.pctrEdtImagem = new DevExpress.XtraEditors.PictureEdit();
            this.lblCtrlTitulo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.destaqueBGM3 = new FGlobus.Componentes.WinForms.DestaqueBGM();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrEdtImagem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(702, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(254, 419);
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
            // 
            // lineShape2
            // 
         
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(297, 132);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(310, 20);
            this.comboBoxEdit1.TabIndex = 13;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.lblCtrlTitulo);
            this.panelControl1.Location = new System.Drawing.Point(471, 191);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(140, 39);
            this.panelControl1.TabIndex = 11;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lblCtrlValor);
            this.panelControl2.Controls.Add(this.pctrEdtImagem);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 15);
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(136, 22);
            this.panelControl2.TabIndex = 7;
            // 
            // lblCtrlValor
            // 
            this.lblCtrlValor.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrlValor.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtrlValor.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCtrlValor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCtrlValor.Location = new System.Drawing.Point(57, 0);
            this.lblCtrlValor.Name = "lblCtrlValor";
            this.lblCtrlValor.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCtrlValor.Size = new System.Drawing.Size(53, 23);
            this.lblCtrlValor.TabIndex = 7;
            this.lblCtrlValor.Text = "Valor";
            // 
            // pctrEdtImagem
            // 
            this.pctrEdtImagem.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctrEdtImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrEdtImagem.Name = "pctrEdtImagem";
            this.pctrEdtImagem.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pctrEdtImagem.Properties.Appearance.Options.UseBackColor = true;
            this.pctrEdtImagem.Size = new System.Drawing.Size(57, 22);
            this.pctrEdtImagem.TabIndex = 0;
            // 
            // lblCtrlTitulo
            // 
            this.lblCtrlTitulo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCtrlTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtrlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCtrlTitulo.Location = new System.Drawing.Point(2, 2);
            this.lblCtrlTitulo.Name = "lblCtrlTitulo";
            this.lblCtrlTitulo.Size = new System.Drawing.Size(32, 13);
            this.lblCtrlTitulo.TabIndex = 7;
            this.lblCtrlTitulo.Text = "Titulo";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(323, 266);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 15);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "labelControl2";
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(323, 210);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Size = new System.Drawing.Size(100, 20);
            this.spinEdit2.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(323, 191);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "labelControl1";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(395, 110);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(168, 20);
            this.textEdit1.TabIndex = 15;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // destaqueBGM3
            // 
            this.destaqueBGM3.BackColor = System.Drawing.Color.Transparent;
            this.destaqueBGM3.Location = new System.Drawing.Point(53, 22);
            this.destaqueBGM3.MinimumSize = new System.Drawing.Size(86, 86);
            this.destaqueBGM3.Name = "destaqueBGM3";
            this.destaqueBGM3.Size = new System.Drawing.Size(208, 86);
            this.destaqueBGM3.TabIndex = 16;
            // 
            // FrmDestaque
            // 
            this.ClientSize = new System.Drawing.Size(956, 419);
            this.Controls.Add(this.destaqueBGM3);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.spinEdit2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "FrmDestaque";
            this.Load += new System.EventHandler(this.FrmDestaque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrEdtImagem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private FGlobus.Componentes.WinForms.DestaqueBGM destaqueBGM1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblCtrlValor;
        private DevExpress.XtraEditors.PictureEdit pctrEdtImagem;
        private DevExpress.XtraEditors.LabelControl lblCtrlTitulo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private FGlobus.Componentes.WinForms.DestaqueBGM destaqueBGM2;
        private FGlobus.Componentes.WinForms.DestaqueBGM destaqueBGM3;


    }
}