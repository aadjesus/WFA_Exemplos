namespace WFA_Workflow.Workflow
{
    partial class Form1
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
            FGlobus.Componentes.WinForms.ClassDateEditBGM classDateEditBGM1 = new FGlobus.Componentes.WinForms.ClassDateEditBGM();
            FGlobus.Componentes.WinForms.ClassDateEditBGM classDateEditBGM2 = new FGlobus.Componentes.WinForms.ClassDateEditBGM();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.dateEditBGM1 = new FGlobus.Componentes.WinForms.DateEditBGM(this.components);
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.calcEditBGM1 = new FGlobus.Componentes.WinForms.CalcEditBGM(this.components);
            this.textEditBGM1 = new FGlobus.Componentes.WinForms.TextEditBGM(this.components);
            this.buttonEditBGM1 = new FGlobus.Componentes.WinForms.ButtonEditBGM(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBGM1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBGM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditBGM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGM1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditBGM1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditBGM1
            // 
            this.dateEditBGM1.EditValue = new System.DateTime(2013, 3, 15, 0, 0, 0, 0);
            this.dateEditBGM1.Location = new System.Drawing.Point(342, 59);
            this.dateEditBGM1.Name = "dateEditBGM1";
            this.dateEditBGM1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("dateEditBGM1.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4), serializableAppearanceObject1, "", null, superToolTip1, true)});
            this.dateEditBGM1.Properties.Mask.EditMask = "99/99/0000";
            this.dateEditBGM1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.dateEditBGM1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditBGM1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditBGM1.Size = new System.Drawing.Size(100, 20);
            this.dateEditBGM1.SuperTip = superToolTip2;
            this.dateEditBGM1.TabIndex = 0;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(342, 85);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // calcEditBGM1
            // 
            this.calcEditBGM1.Location = new System.Drawing.Point(216, 160);
            this.calcEditBGM1.Name = "calcEditBGM1";
            this.calcEditBGM1.Size = new System.Drawing.Size(100, 20);
            this.calcEditBGM1.TabIndex = 2;
            this.calcEditBGM1.ValorMaximo = new decimal(new int[] {
            0,
            0,
            0,
            0});           
            // 
            // textEditBGM1
            // 
            this.textEditBGM1.Location = new System.Drawing.Point(207, 203);
            this.textEditBGM1.Name = "textEditBGM1";
            this.textEditBGM1.Size = new System.Drawing.Size(100, 20);
            this.textEditBGM1.TabIndex = 3;
         
            // 
            // buttonEditBGM1
            // 
            this.buttonEditBGM1.EditValue = "buttonEditBGM1";
            this.buttonEditBGM1.ExecutarPesquisa = true;
            this.buttonEditBGM1.Location = new System.Drawing.Point(216, 352);
            this.buttonEditBGM1.Name = "buttonEditBGM1";
            this.buttonEditBGM1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditBGM1.Size = new System.Drawing.Size(100, 20);
            this.buttonEditBGM1.TabIndex = 4;
            this.buttonEditBGM1.TamanhoCampo = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 449);
            this.Controls.Add(this.buttonEditBGM1);
            this.Controls.Add(this.textEditBGM1);
            this.Controls.Add(this.calcEditBGM1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.dateEditBGM1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBGM1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBGM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditBGM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBGM1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditBGM1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FGlobus.Componentes.WinForms.DateEditBGM dateEditBGM1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private FGlobus.Componentes.WinForms.CalcEditBGM calcEditBGM1;
        private FGlobus.Componentes.WinForms.TextEditBGM textEditBGM1;
        private FGlobus.Componentes.WinForms.ButtonEditBGM buttonEditBGM1;

    }
}   