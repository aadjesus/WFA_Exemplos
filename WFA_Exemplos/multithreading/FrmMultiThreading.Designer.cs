namespace WFA_Exemplos.multithreading
{
    partial class FrmMultiThreading
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBxArquivoFonte = new System.Windows.Forms.TextBox();
            this.txtBxComparaString = new System.Windows.Forms.TextBox();
            this.txtBxPalavrasContadas = new System.Windows.Forms.TextBox();
            this.txtBxLinhasContadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(10, 21);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 50);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBxArquivoFonte
            // 
            this.txtBxArquivoFonte.Location = new System.Drawing.Point(25, 150);
            this.txtBxArquivoFonte.Name = "txtBxArquivoFonte";
            this.txtBxArquivoFonte.Size = new System.Drawing.Size(100, 20);
            this.txtBxArquivoFonte.TabIndex = 2;
            // 
            // txtBxComparaString
            // 
            this.txtBxComparaString.Location = new System.Drawing.Point(131, 150);
            this.txtBxComparaString.Name = "txtBxComparaString";
            this.txtBxComparaString.Size = new System.Drawing.Size(100, 20);
            this.txtBxComparaString.TabIndex = 3;
            // 
            // txtBxPalavrasContadas
            // 
            this.txtBxPalavrasContadas.Location = new System.Drawing.Point(237, 150);
            this.txtBxPalavrasContadas.Name = "txtBxPalavrasContadas";
            this.txtBxPalavrasContadas.Size = new System.Drawing.Size(127, 20);
            this.txtBxPalavrasContadas.TabIndex = 4;
            this.txtBxPalavrasContadas.Text = "0";
            // 
            // txtBxLinhasContadas
            // 
            this.txtBxLinhasContadas.Location = new System.Drawing.Point(373, 150);
            this.txtBxLinhasContadas.Name = "txtBxLinhasContadas";
            this.txtBxLinhasContadas.Size = new System.Drawing.Size(100, 20);
            this.txtBxLinhasContadas.TabIndex = 5;
            this.txtBxLinhasContadas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comparar String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Palavras correspondentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Linhas Contadas";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmMultiThreading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLinhasContadas);
            this.Controls.Add(this.txtBxPalavrasContadas);
            this.Controls.Add(this.txtBxComparaString);
            this.Controls.Add(this.txtBxArquivoFonte);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FrmMultiThreading";
            this.Text = "FrmMultiThreading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBxArquivoFonte;
        private System.Windows.Forms.TextBox txtBxComparaString;
        private System.Windows.Forms.TextBox txtBxPalavrasContadas;
        private System.Windows.Forms.TextBox txtBxLinhasContadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}