namespace QuanLySinhVien.GUI
{
    partial class LopHocGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LopHocGUI));
            this.label4 = new System.Windows.Forms.Label();
            this.lstLop = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxHeDaoTao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.ptbSua = new System.Windows.Forms.PictureBox();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Thông tin lớp học";
            // 
            // lstLop
            // 
            this.lstLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstLop.FullRowSelect = true;
            this.lstLop.HideSelection = false;
            this.lstLop.Location = new System.Drawing.Point(12, 250);
            this.lstLop.MultiSelect = false;
            this.lstLop.Name = "lstLop";
            this.lstLop.Size = new System.Drawing.Size(707, 145);
            this.lstLop.TabIndex = 1;
            this.lstLop.UseCompatibleStateImageBehavior = false;
            this.lstLop.View = System.Windows.Forms.View.Details;
            this.lstLop.SelectedIndexChanged += new System.EventHandler(this.lstLop_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Lớp";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khoa";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hệ đào tạo";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "sĩ số";
            // 
            // cbxHeDaoTao
            // 
            this.cbxHeDaoTao.FormattingEnabled = true;
            this.cbxHeDaoTao.Items.AddRange(new object[] {
            "Đại Học",
            "Cao Đẳng"});
            this.cbxHeDaoTao.Location = new System.Drawing.Point(124, 73);
            this.cbxHeDaoTao.Name = "cbxHeDaoTao";
            this.cbxHeDaoTao.Size = new System.Drawing.Size(110, 24);
            this.cbxHeDaoTao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bậc đào tạo";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.Items.AddRange(new object[] {
            "Công Nghệ Thôn Tin",
            "Quản Trị Kinh Doanh",
            "Công Nghệ Thực Phẩm",
            "Điện Điện Tử",
            "Design",
            "Cơ Khí",
            "Kỹ thuật công trình"});
            this.cbxKhoa.Location = new System.Drawing.Point(124, 43);
            this.cbxKhoa.MaxLength = 3;
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(172, 24);
            this.cbxKhoa.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(124, 15);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(172, 22);
            this.txtMaLop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ptbExit);
            this.groupBox1.Controls.Add(this.ptbDelete);
            this.groupBox1.Controls.Add(this.ptbSua);
            this.groupBox1.Controls.Add(this.ptbAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstLop);
            this.groupBox1.Controls.Add(this.cbxHeDaoTao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxKhoa);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 402);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // ptbExit
            // 
            this.ptbExit.Image = ((System.Drawing.Image)(resources.GetObject("ptbExit.Image")));
            this.ptbExit.Location = new System.Drawing.Point(502, 174);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(216, 48);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 40;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // ptbDelete
            // 
            this.ptbDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbDelete.Image")));
            this.ptbDelete.Location = new System.Drawing.Point(501, 120);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(217, 48);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDelete.TabIndex = 39;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // ptbSua
            // 
            this.ptbSua.Image = ((System.Drawing.Image)(resources.GetObject("ptbSua.Image")));
            this.ptbSua.Location = new System.Drawing.Point(501, 66);
            this.ptbSua.Name = "ptbSua";
            this.ptbSua.Size = new System.Drawing.Size(218, 48);
            this.ptbSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSua.TabIndex = 38;
            this.ptbSua.TabStop = false;
            this.ptbSua.Click += new System.EventHandler(this.ptbSua_Click);
            // 
            // ptbAdd
            // 
            this.ptbAdd.Image = ((System.Drawing.Image)(resources.GetObject("ptbAdd.Image")));
            this.ptbAdd.Location = new System.Drawing.Point(502, 12);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(217, 48);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAdd.TabIndex = 37;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LopHocGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LopHocGUI";
            this.Text = "LopHocGUI";
            this.Load += new System.EventHandler(this.LopHocGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstLop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cbxHeDaoTao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbDelete;
        private System.Windows.Forms.PictureBox ptbSua;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}