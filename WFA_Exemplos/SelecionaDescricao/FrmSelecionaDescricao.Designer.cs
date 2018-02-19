namespace WFA_Workflow
{
    partial class FrmSelecionaDescricao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionaDescricao));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.buttonEditBGM1 = new FGlobus.Componentes.WinForms.ButtonEditBGM(this.components);
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.selecionaDescricaoBGM1 = new FGlobus.Componentes.WinForms.SelecionaDescricaoBGM();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditBGM1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditBGM1
            // 
            this.buttonEditBGM1.BrowseDePesquisa = "BgmRodotec.Globus5.Pesquisas.Abastecimento.Bomba";
            this.buttonEditBGM1.EditValue = "buttonEditBGM1";
            this.buttonEditBGM1.ExecutarPesquisa = true;
            this.buttonEditBGM1.Location = new System.Drawing.Point(416, 161);
            this.buttonEditBGM1.Name = "buttonEditBGM1";
            this.buttonEditBGM1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("buttonEditBGM1.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "#CONTROLEINTERNO#", null, true)});
            this.buttonEditBGM1.Size = new System.Drawing.Size(211, 20);
            this.buttonEditBGM1.TabIndex = 4;
            this.buttonEditBGM1.TamanhoCampo = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 31);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(364, 421);
            this.propertyGrid1.TabIndex = 2;
            // 
            // selecionaDescricaoBGM1
            // 
            this.selecionaDescricaoBGM1.ButtonEditBGM = this.buttonEditBGM1;
            this.selecionaDescricaoBGM1.ColunaDefault = "Código;Codigo";
            this.selecionaDescricaoBGM1.Location = new System.Drawing.Point(416, 200);
            this.selecionaDescricaoBGM1.MinimumSize = new System.Drawing.Size(100, 39);
            this.selecionaDescricaoBGM1.Name = "selecionaDescricaoBGM1";
            this.selecionaDescricaoBGM1.Size = new System.Drawing.Size(338, 39);
            this.selecionaDescricaoBGM1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSelecionaDescricao
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selecionaDescricaoBGM1);
            this.Controls.Add(this.buttonEditBGM1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "FrmSelecionaDescricao";
            this.Text = "FrmSelecionaDescricao";
            this.Controls.SetChildIndex(this.propertyGrid1, 0);
            this.Controls.SetChildIndex(this.buttonEditBGM1, 0);
            this.Controls.SetChildIndex(this.selecionaDescricaoBGM1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditBGM1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private FGlobus.Componentes.WinForms.ButtonEditBGM buttonEditBGM1;
        private FGlobus.Componentes.WinForms.SelecionaDescricaoBGM selecionaDescricaoBGM1;
        private System.Windows.Forms.Button button1;

    }
}