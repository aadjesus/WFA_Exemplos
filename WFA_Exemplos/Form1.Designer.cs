namespace WFA_Exemplos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new FGlobus.Componentes.WinForms.LabelControlBGM(this.components);
            this.simpleButtonBGM1 = new FGlobus.Componentes.WinForms.SimpleButtonBGM(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.associacaoBGMDemo1 = new FGlobus.Componentes.WinForms.AssociacaoBGM();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // simpleButtonBGM1
            // 
            this.simpleButtonBGM1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonBGM1.Image")));
            this.simpleButtonBGM1.LimparTelaAposClick = false;
            this.simpleButtonBGM1.Location = new System.Drawing.Point(12, 31);
            this.simpleButtonBGM1.Name = "simpleButtonBGM1";
            this.simpleButtonBGM1.RegrasHabilita = FGlobus.Componentes.WinForms.SimpleButtonBGM.eRegrasHabilita.Nenhuma;
            this.simpleButtonBGM1.Size = new System.Drawing.Size(100, 30);
            this.simpleButtonBGM1.TabIndex = 1;
            this.simpleButtonBGM1.Text = "&Gravar";
            this.simpleButtonBGM1.TipoBotao = FGlobus.Componentes.WinForms.SimpleButtonBGM.eTipoBotao.Gravar;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // associacaoBGMDemo1
            // 
            this.associacaoBGMDemo1.Location = new System.Drawing.Point(103, 102);
            this.associacaoBGMDemo1.Name = "associacaoBGMDemo1";
            this.associacaoBGMDemo1.PrimeiroControle = null;
            this.associacaoBGMDemo1.Size = new System.Drawing.Size(500, 300);
            this.associacaoBGMDemo1.TabIndex = 4;
            this.associacaoBGMDemo1.Titulo = "[AssociacaoBGMDemo]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 475);
            this.Controls.Add(this.associacaoBGMDemo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButtonBGM1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FGlobus.Componentes.WinForms.LabelControlBGM label1;
        private FGlobus.Componentes.WinForms.SimpleButtonBGM simpleButtonBGM1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private FGlobus.Componentes.WinForms.AssociacaoBGM associacaoBGMDemo1;
    }
}