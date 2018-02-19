namespace WFA_Workflow.RadioGroupBGM
{
    partial class FrmRadioGroupBGM
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
            this.radioGroupBGM1 = new WFA_Workflow.RadioGroupBGM.RadioGroupBGMDemo(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupBGM1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGroupBGM1
            // 
            this.radioGroupBGM1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "asdas"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "aswe"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "werwe")});
            this.radioGroupBGM1.Location = new System.Drawing.Point(103, 30);
            this.radioGroupBGM1.Name = "radioGroupBGM1";
            this.radioGroupBGM1.QtdeColunas = 0;
            this.radioGroupBGM1.Size = new System.Drawing.Size(169, 155);
            this.radioGroupBGM1.TabIndex = 0;
            this.radioGroupBGM1.Text = "radioGroupBGM1";
            // 
            // FrmRadioGroupBGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radioGroupBGM1);
            this.Name = "FrmRadioGroupBGM";
            this.Text = "FrmRadioGroupBGM";
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupBGM1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioGroupBGMDemo radioGroupBGM1;




    }
}