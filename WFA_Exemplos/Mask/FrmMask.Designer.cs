namespace WFA_Workflow.Mask
{
    partial class FrmMask
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdoMask = new System.Windows.Forms.RadioButton();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoValue = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new MaskedTextBox.MaskedTextBox();
            this.maskedEdit1 = new MaskedEdit.MaskedEdit();
            this.MaskedEdit12 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaskCompleted = new System.Windows.Forms.Label();
            this.txtmskPromptChar = new System.Windows.Forms.MaskedTextBox();
            this.chkBeepErr = new System.Windows.Forms.CheckBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.chkIncludeLiteral = new System.Windows.Forms.CheckBox();
            this.chkIncludePrompt = new System.Windows.Forms.CheckBox();
            this.chkHideMsk = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radMask5 = new System.Windows.Forms.RadioButton();
            this.radMask4 = new System.Windows.Forms.RadioButton();
            this.radMask3 = new System.Windows.Forms.RadioButton();
            this.radMask2 = new System.Windows.Forms.RadioButton();
            this.radMask1 = new System.Windows.Forms.RadioButton();
            this.maskedInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MaskedEdit12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "MaskedEdit Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoMask
            // 
            this.rdoMask.Location = new System.Drawing.Point(156, 86);
            this.rdoMask.Name = "rdoMask";
            this.rdoMask.Size = new System.Drawing.Size(104, 24);
            this.rdoMask.TabIndex = 20;
            this.rdoMask.Text = "Mask";
            // 
            // rdoText
            // 
            this.rdoText.Location = new System.Drawing.Point(156, 62);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(104, 24);
            this.rdoText.TabIndex = 19;
            this.rdoText.Text = "Text";
            // 
            // rdoValue
            // 
            this.rdoValue.Location = new System.Drawing.Point(156, 38);
            this.rdoValue.Name = "rdoValue";
            this.rdoValue.Size = new System.Drawing.Size(104, 24);
            this.rdoValue.TabIndex = 18;
            this.rdoValue.Text = "Value";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Set";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Get";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "IsValid";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "TEXTBOX1";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(35, 40);
            this.maskedTextBox1.Masked = MaskedTextBox.Mask.DateOnly;
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // maskedEdit1
            // 
            this.maskedEdit1.ErrorInvalid = false;
            this.maskedEdit1.InputChar = '_';
            this.maskedEdit1.InputMask = "";
            this.maskedEdit1.Location = new System.Drawing.Point(28, 62);
            this.maskedEdit1.MaxLength = 0;
            this.maskedEdit1.Name = "maskedEdit1";
            this.maskedEdit1.Size = new System.Drawing.Size(104, 20);
            this.maskedEdit1.StdInputMask = MaskedEdit.MaskedEdit.InputMaskType.None;
            this.maskedEdit1.TabIndex = 17;
            // 
            // MaskedEdit12
            // 
            this.MaskedEdit12.Controls.Add(this.label1);
            this.MaskedEdit12.Controls.Add(this.textBox1);
            this.MaskedEdit12.Controls.Add(this.button1);
            this.MaskedEdit12.Controls.Add(this.button2);
            this.MaskedEdit12.Controls.Add(this.rdoMask);
            this.MaskedEdit12.Controls.Add(this.button3);
            this.MaskedEdit12.Controls.Add(this.rdoText);
            this.MaskedEdit12.Controls.Add(this.maskedEdit1);
            this.MaskedEdit12.Controls.Add(this.rdoValue);
            this.MaskedEdit12.Location = new System.Drawing.Point(12, 12);
            this.MaskedEdit12.Name = "MaskedEdit12";
            this.MaskedEdit12.Size = new System.Drawing.Size(399, 151);
            this.MaskedEdit12.TabIndex = 23;
            this.MaskedEdit12.TabStop = false;
            this.MaskedEdit12.Text = "MaskedEdit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaskCompleted);
            this.groupBox1.Controls.Add(this.txtmskPromptChar);
            this.groupBox1.Controls.Add(this.chkBeepErr);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.btnOutput);
            this.groupBox1.Controls.Add(this.chkIncludeLiteral);
            this.groupBox1.Controls.Add(this.chkIncludePrompt);
            this.groupBox1.Controls.Add(this.chkHideMsk);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.maskedInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 226);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MaskedTextBox";
            // 
            // lblMaskCompleted
            // 
            this.lblMaskCompleted.AutoSize = true;
            this.lblMaskCompleted.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaskCompleted.ForeColor = System.Drawing.Color.Black;
            this.lblMaskCompleted.Location = new System.Drawing.Point(111, 68);
            this.lblMaskCompleted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaskCompleted.Name = "lblMaskCompleted";
            this.lblMaskCompleted.Size = new System.Drawing.Size(119, 12);
            this.lblMaskCompleted.TabIndex = 29;
            this.lblMaskCompleted.Text = "MÁSCARA CONCLUÍDO";
            this.lblMaskCompleted.Visible = false;
            // 
            // txtmskPromptChar
            // 
            this.txtmskPromptChar.BeepOnError = true;
            this.txtmskPromptChar.Location = new System.Drawing.Point(191, 134);
            this.txtmskPromptChar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtmskPromptChar.Mask = "C";
            this.txtmskPromptChar.Name = "txtmskPromptChar";
            this.txtmskPromptChar.Size = new System.Drawing.Size(17, 20);
            this.txtmskPromptChar.TabIndex = 28;
            // 
            // chkBeepErr
            // 
            this.chkBeepErr.AutoSize = true;
            this.chkBeepErr.ForeColor = System.Drawing.Color.Black;
            this.chkBeepErr.Location = new System.Drawing.Point(178, 90);
            this.chkBeepErr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkBeepErr.Name = "chkBeepErr";
            this.chkBeepErr.Size = new System.Drawing.Size(89, 17);
            this.chkBeepErr.TabIndex = 27;
            this.chkBeepErr.Text = "Beep em erro";
            this.chkBeepErr.UseVisualStyleBackColor = true;
            this.chkBeepErr.CheckedChanged += new System.EventHandler(this.chkBeepErr_CheckedChanged);
            // 
            // btnSet
            // 
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.Location = new System.Drawing.Point(211, 134);
            this.btnSet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(28, 21);
            this.btnSet.TabIndex = 26;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(124, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Prompt Char:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(113, 168);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(132, 20);
            this.txtOutput.TabIndex = 24;
            // 
            // btnOutput
            // 
            this.btnOutput.ForeColor = System.Drawing.Color.Black;
            this.btnOutput.Location = new System.Drawing.Point(16, 168);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(86, 21);
            this.btnOutput.TabIndex = 23;
            this.btnOutput.Text = "Mostrar saída";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // chkIncludeLiteral
            // 
            this.chkIncludeLiteral.AutoSize = true;
            this.chkIncludeLiteral.ForeColor = System.Drawing.Color.Black;
            this.chkIncludeLiteral.Location = new System.Drawing.Point(16, 112);
            this.chkIncludeLiteral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkIncludeLiteral.Name = "chkIncludeLiteral";
            this.chkIncludeLiteral.Size = new System.Drawing.Size(92, 17);
            this.chkIncludeLiteral.TabIndex = 22;
            this.chkIncludeLiteral.Text = "Include Literal";
            this.chkIncludeLiteral.UseVisualStyleBackColor = true;
            this.chkIncludeLiteral.CheckedChanged += new System.EventHandler(this.chkIncludeLiteral_CheckedChanged);
            // 
            // chkIncludePrompt
            // 
            this.chkIncludePrompt.AutoSize = true;
            this.chkIncludePrompt.ForeColor = System.Drawing.Color.Black;
            this.chkIncludePrompt.Location = new System.Drawing.Point(16, 135);
            this.chkIncludePrompt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkIncludePrompt.Name = "chkIncludePrompt";
            this.chkIncludePrompt.Size = new System.Drawing.Size(90, 17);
            this.chkIncludePrompt.TabIndex = 21;
            this.chkIncludePrompt.Text = "Incluir Prompt";
            this.chkIncludePrompt.UseVisualStyleBackColor = true;
            this.chkIncludePrompt.CheckedChanged += new System.EventHandler(this.chkIncludePrompt_CheckedChanged);
            // 
            // chkHideMsk
            // 
            this.chkHideMsk.AutoSize = true;
            this.chkHideMsk.ForeColor = System.Drawing.Color.Black;
            this.chkHideMsk.Location = new System.Drawing.Point(16, 90);
            this.chkHideMsk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkHideMsk.Name = "chkHideMsk";
            this.chkHideMsk.Size = new System.Drawing.Size(158, 17);
            this.chkHideMsk.TabIndex = 20;
            this.chkHideMsk.Text = "Ocultar Máscara em licença";
            this.chkHideMsk.UseVisualStyleBackColor = true;
            this.chkHideMsk.CheckedChanged += new System.EventHandler(this.chkHideMsk_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radMask5);
            this.groupBox3.Controls.Add(this.radMask4);
            this.groupBox3.Controls.Add(this.radMask3);
            this.groupBox3.Controls.Add(this.radMask2);
            this.groupBox3.Controls.Add(this.radMask1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(266, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(116, 150);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Masks";
            // 
            // radMask5
            // 
            this.radMask5.AutoSize = true;
            this.radMask5.Location = new System.Drawing.Point(11, 123);
            this.radMask5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radMask5.Name = "radMask5";
            this.radMask5.Size = new System.Drawing.Size(92, 17);
            this.radMask5.TabIndex = 4;
            this.radMask5.TabStop = true;
            this.radMask5.Text = "LL.LaaaCCCC";
            this.radMask5.UseVisualStyleBackColor = true;
            this.radMask5.CheckedChanged += new System.EventHandler(this.radMask5_CheckedChanged);
            // 
            // radMask4
            // 
            this.radMask4.AutoSize = true;
            this.radMask4.Location = new System.Drawing.Point(11, 97);
            this.radMask4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radMask4.Name = "radMask4";
            this.radMask4.Size = new System.Drawing.Size(79, 17);
            this.radMask4.TabIndex = 3;
            this.radMask4.TabStop = true;
            this.radMask4.Text = "00 : 00 : 00";
            this.radMask4.UseVisualStyleBackColor = true;
            this.radMask4.CheckedChanged += new System.EventHandler(this.radMask4_CheckedChanged);
            // 
            // radMask3
            // 
            this.radMask3.AutoSize = true;
            this.radMask3.Location = new System.Drawing.Point(11, 71);
            this.radMask3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radMask3.Name = "radMask3";
            this.radMask3.Size = new System.Drawing.Size(64, 17);
            this.radMask3.TabIndex = 2;
            this.radMask3.TabStop = true;
            this.radMask3.Text = "$99,999";
            this.radMask3.UseVisualStyleBackColor = true;
            this.radMask3.CheckedChanged += new System.EventHandler(this.radMask3_CheckedChanged);
            // 
            // radMask2
            // 
            this.radMask2.AutoSize = true;
            this.radMask2.Location = new System.Drawing.Point(11, 44);
            this.radMask2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radMask2.Name = "radMask2";
            this.radMask2.Size = new System.Drawing.Size(56, 17);
            this.radMask2.TabIndex = 1;
            this.radMask2.TabStop = true;
            this.radMask2.Text = "Aaaaa";
            this.radMask2.UseVisualStyleBackColor = true;
            this.radMask2.CheckedChanged += new System.EventHandler(this.radMask2_CheckedChanged);
            // 
            // radMask1
            // 
            this.radMask1.AutoSize = true;
            this.radMask1.Location = new System.Drawing.Point(11, 19);
            this.radMask1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radMask1.Name = "radMask1";
            this.radMask1.Size = new System.Drawing.Size(77, 17);
            this.radMask1.TabIndex = 0;
            this.radMask1.TabStop = true;
            this.radMask1.Text = "#00 - (999)";
            this.radMask1.UseVisualStyleBackColor = true;
            this.radMask1.CheckedChanged += new System.EventHandler(this.radMask1_CheckedChanged);
            // 
            // maskedInput
            // 
            this.maskedInput.Location = new System.Drawing.Point(113, 45);
            this.maskedInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedInput.Name = "maskedInput";
            this.maskedInput.Size = new System.Drawing.Size(132, 20);
            this.maskedInput.TabIndex = 18;
            this.maskedInput.TextChanged += new System.EventHandler(this.maskedInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Masked Text Box";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 74);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MaskedTextBox";
            // 
            // FrmMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MaskedEdit12);
            this.Name = "FrmMask";
            this.Text = "FrmMask";
            this.MaskedEdit12.ResumeLayout(false);
            this.MaskedEdit12.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoMask;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoValue;
        private MaskedEdit.MaskedEdit maskedEdit1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private MaskedTextBox.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox MaskedEdit12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaskCompleted;
        private System.Windows.Forms.MaskedTextBox txtmskPromptChar;
        private System.Windows.Forms.CheckBox chkBeepErr;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.CheckBox chkIncludeLiteral;
        private System.Windows.Forms.CheckBox chkIncludePrompt;
        private System.Windows.Forms.CheckBox chkHideMsk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radMask5;
        private System.Windows.Forms.RadioButton radMask4;
        private System.Windows.Forms.RadioButton radMask3;
        private System.Windows.Forms.RadioButton radMask2;
        private System.Windows.Forms.RadioButton radMask1;
        private System.Windows.Forms.MaskedTextBox maskedInput;
        private System.Windows.Forms.Label label3;

    }
}