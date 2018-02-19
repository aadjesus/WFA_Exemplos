namespace WFA_Exemplos.GroupControlBGM
{
    partial class GroupControlBGMDemoXOcultar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupControlBGMDemoXOcultar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLeft = new DevExpress.XtraEditors.CheckButton();
            this.btnRight = new DevExpress.XtraEditors.CheckButton();
            this.btnTop = new DevExpress.XtraEditors.CheckButton();
            this.btnNenhum = new DevExpress.XtraEditors.CheckButton();
            this.btnBotton = new DevExpress.XtraEditors.CheckButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNenhum, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBotton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(500, 120);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(100, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(100, 120);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnLeft
            // 
            this.btnLeft.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLeft.Location = new System.Drawing.Point(0, 40);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeft.Name = "btnLeft";
            this.tableLayoutPanel1.SetRowSpan(this.btnLeft, 2);
            this.btnLeft.Size = new System.Drawing.Size(40, 60);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.TabStop = false;
            this.btnLeft.Click += new System.EventHandler(this.btnNenhum_Click);
            // 
            // btnRight
            // 
            this.btnRight.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRight.Location = new System.Drawing.Point(60, 0);
            this.btnRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnRight.Name = "btnRight";
            this.tableLayoutPanel1.SetRowSpan(this.btnRight, 2);
            this.btnRight.Size = new System.Drawing.Size(40, 60);
            this.btnRight.TabIndex = 7;
            this.btnRight.TabStop = false;
            this.btnRight.Click += new System.EventHandler(this.btnNenhum_Click);
            // 
            // btnTop
            // 
            this.btnTop.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tableLayoutPanel1.SetColumnSpan(this.btnTop, 2);
            this.btnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnTop.Image")));
            this.btnTop.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTop.Location = new System.Drawing.Point(0, 0);
            this.btnTop.Margin = new System.Windows.Forms.Padding(0);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(60, 40);
            this.btnTop.TabIndex = 8;
            this.btnTop.TabStop = false;
            this.btnTop.Click += new System.EventHandler(this.btnNenhum_Click);
            // 
            // btnNenhum
            // 
            this.btnNenhum.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnNenhum.Checked = true;
            this.tableLayoutPanel1.SetColumnSpan(this.btnNenhum, 3);
            this.btnNenhum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNenhum.Location = new System.Drawing.Point(0, 100);
            this.btnNenhum.Margin = new System.Windows.Forms.Padding(0);
            this.btnNenhum.Name = "btnNenhum";
            this.btnNenhum.Size = new System.Drawing.Size(100, 20);
            this.btnNenhum.TabIndex = 0;
            this.btnNenhum.TabStop = false;
            this.btnNenhum.Text = "Nenhum";
            this.btnNenhum.Click += new System.EventHandler(this.btnNenhum_Click);
            // 
            // btnBotton
            // 
            this.btnBotton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tableLayoutPanel1.SetColumnSpan(this.btnBotton, 2);
            this.btnBotton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBotton.Image = ((System.Drawing.Image)(resources.GetObject("btnBotton.Image")));
            this.btnBotton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBotton.Location = new System.Drawing.Point(40, 60);
            this.btnBotton.Margin = new System.Windows.Forms.Padding(0);
            this.btnBotton.Name = "btnBotton";
            this.btnBotton.Size = new System.Drawing.Size(60, 40);
            this.btnBotton.TabIndex = 5;
            this.btnBotton.TabStop = false;
            this.btnBotton.Click += new System.EventHandler(this.btnNenhum_Click);
            // 
            // GroupControlBGMDemoXOcultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GroupControlBGMDemoXOcultar";
            this.Size = new System.Drawing.Size(250, 120);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.CheckButton btnLeft;
        private DevExpress.XtraEditors.CheckButton btnRight;
        private DevExpress.XtraEditors.CheckButton btnTop;
        private DevExpress.XtraEditors.CheckButton btnNenhum;
        private DevExpress.XtraEditors.CheckButton btnBotton;
    }
}
