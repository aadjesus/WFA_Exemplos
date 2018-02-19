namespace WFA_Workflow.Mascaras
{
    partial class FrmMascaras
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.textEditBGMX1 = new WFA_Workflow.Mascaras.TextEditBGMDemo(this.components);
            this.textEditBGM1 = new FGlobus.Componentes.WinForms.TextEditBGM(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGMX1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGM1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 117);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "\\p{L}";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.Validating += new System.ComponentModel.CancelEventHandler(this.textEdit1_Validating);
            this.textEdit1.Validated += new System.EventHandler(this.textEdit1_Validated);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 170);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "x";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 201);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(6, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "x";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(197, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(336, 498);
            this.propertyGrid1.TabIndex = 1;
            // 
            // textEditBGMX1
            // 
            this.textEditBGMX1.Location = new System.Drawing.Point(26, 60);
            this.textEditBGMX1.Mascara = WFA_Workflow.Mascaras.eMascara.Email;
            this.textEditBGMX1.Name = "textEditBGMX1";
            this.textEditBGMX1.Properties.Mask.SaveLiteral = false;
            this.textEditBGMX1.Size = new System.Drawing.Size(136, 20);
            this.textEditBGMX1.TabIndex = 6;
            this.textEditBGMX1.Validating += new System.ComponentModel.CancelEventHandler(this.textEditBGMX1_Validating_1);
            // 
            // textEditBGM1
            // 
            this.textEditBGM1.Location = new System.Drawing.Point(36, 274);
            this.textEditBGM1.Name = "textEditBGM1";
            this.textEditBGM1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditBGM1.Size = new System.Drawing.Size(100, 20);
            this.textEditBGM1.TabIndex = 7;
            this.textEditBGM1.TipoDeMascara = FGlobus.Componentes.WinForms.eTipoDeMascara.Email;            
            // 
            // FrmMascaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 498);
            this.Controls.Add(this.textEditBGM1);
            this.Controls.Add(this.textEditBGMX1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "FrmMascaras";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMascaras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGMX1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGM1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private TextEditBGMDemo textEditBGMX1;
        private FGlobus.Componentes.WinForms.TextEditBGM textEditBGM1;

    }
}