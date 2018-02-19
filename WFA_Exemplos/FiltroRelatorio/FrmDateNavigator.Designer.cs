namespace WFA_Workflow.WPFDateNavigator
{
    partial class FrmDateNavigator
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateNavigator1 = new WFA_Workflow.WPFDateNavigator.CustomDateNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.BoldAppointmentDates = false;
            this.dateNavigator1.DateTime = new System.DateTime(2013, 8, 21, 0, 0, 0, 0);
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.ShowTodayButton = false;
            this.dateNavigator1.ShowWeekNumbers = false;
            this.dateNavigator1.Size = new System.Drawing.Size(836, 461);
            this.dateNavigator1.TabIndex = 0;
            this.dateNavigator1.CustomDrawDayNumberCell += new DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventHandler(this.dateNavigator1_CustomDrawDayNumberCell);
            // 
            // FrmDateNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateNavigator1);
            this.Name = "FrmDateNavigator";
            this.Text = "FrmDateNavigator";
            this.Shown += new System.EventHandler(this.FrmDateNavigator_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDateNavigator dateNavigator1;
        private System.Windows.Forms.Button button1;


    }
}