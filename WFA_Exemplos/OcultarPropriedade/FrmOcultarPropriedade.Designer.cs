namespace WFA_Workflow
{
    partial class FrmOcultarPropriedade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOcultarPropriedade));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.calcEditBGM1 = new FGlobus.Componentes.WinForms.CalcEditBGM(this.components);
            this.textEditBGM1 = new FGlobus.Componentes.WinForms.TextEditBGM(this.components);
            this.cmpOcultarPropriedade1 = new WFA_Workflow.OcultarPropriedade.CmpOcultarPropriedade(this.components);
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditBGM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // calcEditBGM1
            // 
            this.calcEditBGM1.Location = new System.Drawing.Point(488, 171);
            this.calcEditBGM1.Name = "calcEditBGM1";
            toolTipTitleItem2.Text = "Calculadora";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.calcEditBGM1.Properties.Mask.EditMask = "f2";
            this.calcEditBGM1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.calcEditBGM1.Properties.MaxLength = 999;
            this.calcEditBGM1.Size = new System.Drawing.Size(100, 20);
            this.calcEditBGM1.TabIndex = 2;
            this.calcEditBGM1.ValorMaximo = new decimal(new int[] {
            999,
            0,
            0,
            0});          
            // 
            // textEditBGM1
            // 
            this.textEditBGM1.Location = new System.Drawing.Point(488, 197);
            this.textEditBGM1.Name = "textEditBGM1";
            this.textEditBGM1.Properties.Mask.EditMask = "\\d{0,3}";
            this.textEditBGM1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditBGM1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEditBGM1.Properties.MaxLength = 3;
          
            // 
            // cmpOcultarPropriedade1
            // 
            this.cmpOcultarPropriedade1.Location = new System.Drawing.Point(355, 90);
            this.cmpOcultarPropriedade1.Name = "cmpOcultarPropriedade1";
            this.cmpOcultarPropriedade1.Size = new System.Drawing.Size(75, 23);
            this.cmpOcultarPropriedade1.TabIndex = 1;
            this.cmpOcultarPropriedade1.Teste = true;
            this.cmpOcultarPropriedade1.Text = "cmpOcultarPropriedade1";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.cmpOcultarPropriedade1;
            this.propertyGrid1.Size = new System.Drawing.Size(330, 535);
            this.propertyGrid1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(428, 296);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(524, 268);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 100);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(356, 173);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 6;
            // 
            // FrmOcultarPropriedade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 535);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEditBGM1);
            this.Controls.Add(this.calcEditBGM1);
            this.Controls.Add(this.cmpOcultarPropriedade1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "FrmOcultarPropriedade";
            this.Text = "FrmOcultarPropriedade";
            ((System.ComponentModel.ISupportInitialize)(this.calcEditBGM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private OcultarPropriedade.CmpOcultarPropriedade cmpOcultarPropriedade1;
        private FGlobus.Componentes.WinForms.CalcEditBGM calcEditBGM1;
        private FGlobus.Componentes.WinForms.TextEditBGM textEditBGM1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}