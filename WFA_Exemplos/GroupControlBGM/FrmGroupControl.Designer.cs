namespace WFA_Workflow.GroupControlBGM
{
    partial class FrmGroupControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroupControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.groupControlBGMDemo1 = new WFA_Workflow.GroupControlBGM.GroupControlBGMDemo();
            this.SuspendLayout();
            // 
            // groupControlBGMDemo1
            // 
            toolTipTitleItem1.Text = "Consultar";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.groupControlBGMDemo1.Location = new System.Drawing.Point(101, 90);
            this.groupControlBGMDemo1.MinimumSize = new System.Drawing.Size(180, 60);
            this.groupControlBGMDemo1.Name = "groupControlBGMDemo1";
            this.groupControlBGMDemo1.Size = new System.Drawing.Size(280, 227);
            this.groupControlBGMDemo1.TabIndex = 0;
            // 
            // FrmGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 506);
            this.Controls.Add(this.groupControlBGMDemo1);
            this.Name = "FrmGroupControl";
            this.Text = "FrmGroupControl";
            this.ResumeLayout(false);

        }

        #endregion

        private GroupControlBGMDemo groupControlBGMDemo1;
































    }
}