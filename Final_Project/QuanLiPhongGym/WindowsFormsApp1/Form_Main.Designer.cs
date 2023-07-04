namespace WindowsFormsApp1
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_tapthu = new WindowsFormsApp1.RJButton();
            this.b_hoadon = new WindowsFormsApp1.RJButton();
            this.b_phong = new WindowsFormsApp1.RJButton();
            this.b_comeback = new WindowsFormsApp1.RJButton();
            this.b_profile = new WindowsFormsApp1.RJButton();
            this.b_dichvu = new WindowsFormsApp1.RJButton();
            this.b_thietbi = new WindowsFormsApp1.RJButton();
            this.b_khachhang = new WindowsFormsApp1.RJButton();
            this.b_nhanvien = new WindowsFormsApp1.RJButton();
            this.b_thongke = new WindowsFormsApp1.RJButton();
            this.lb_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pnMain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1587, 859);
            this.panel1.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Location = new System.Drawing.Point(289, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1293, 852);
            this.pnMain.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panel2.Controls.Add(this.b_tapthu);
            this.panel2.Controls.Add(this.b_hoadon);
            this.panel2.Controls.Add(this.b_phong);
            this.panel2.Controls.Add(this.b_comeback);
            this.panel2.Controls.Add(this.b_profile);
            this.panel2.Controls.Add(this.b_dichvu);
            this.panel2.Controls.Add(this.b_thietbi);
            this.panel2.Controls.Add(this.b_khachhang);
            this.panel2.Controls.Add(this.b_nhanvien);
            this.panel2.Controls.Add(this.b_thongke);
            this.panel2.Controls.Add(this.lb_logo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-11, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 857);
            this.panel2.TabIndex = 0;
            // 
            // b_tapthu
            // 
            this.b_tapthu.BackColor = System.Drawing.Color.White;
            this.b_tapthu.BackgroundColor = System.Drawing.Color.White;
            this.b_tapthu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_tapthu.BorderRadius = 5;
            this.b_tapthu.BorderSize = 0;
            this.b_tapthu.FlatAppearance.BorderSize = 0;
            this.b_tapthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_tapthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_tapthu.ForeColor = System.Drawing.Color.Black;
            this.b_tapthu.Image = global::WindowsFormsApp1.Properties.Resources.time_left_1;
            this.b_tapthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_tapthu.Location = new System.Drawing.Point(37, 311);
            this.b_tapthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_tapthu.Name = "b_tapthu";
            this.b_tapthu.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_tapthu.Size = new System.Drawing.Size(240, 42);
            this.b_tapthu.TabIndex = 120;
            this.b_tapthu.Text = "Tập thử";
            this.b_tapthu.TextColor = System.Drawing.Color.Black;
            this.b_tapthu.UseVisualStyleBackColor = false;
            this.b_tapthu.Click += new System.EventHandler(this.b_tapthu_Click);
            // 
            // b_hoadon
            // 
            this.b_hoadon.BackColor = System.Drawing.Color.White;
            this.b_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.b_hoadon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_hoadon.BorderRadius = 5;
            this.b_hoadon.BorderSize = 0;
            this.b_hoadon.FlatAppearance.BorderSize = 0;
            this.b_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_hoadon.ForeColor = System.Drawing.Color.Black;
            this.b_hoadon.Image = global::WindowsFormsApp1.Properties.Resources._2278049_1;
            this.b_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_hoadon.Location = new System.Drawing.Point(37, 255);
            this.b_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_hoadon.Name = "b_hoadon";
            this.b_hoadon.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_hoadon.Size = new System.Drawing.Size(240, 42);
            this.b_hoadon.TabIndex = 119;
            this.b_hoadon.Text = "Hóa đơn";
            this.b_hoadon.TextColor = System.Drawing.Color.Black;
            this.b_hoadon.UseVisualStyleBackColor = false;
            this.b_hoadon.Click += new System.EventHandler(this.b_hoadon_Click);
            // 
            // b_phong
            // 
            this.b_phong.BackColor = System.Drawing.Color.White;
            this.b_phong.BackgroundColor = System.Drawing.Color.White;
            this.b_phong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_phong.BorderRadius = 5;
            this.b_phong.BorderSize = 0;
            this.b_phong.FlatAppearance.BorderSize = 0;
            this.b_phong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_phong.ForeColor = System.Drawing.Color.Black;
            this.b_phong.Image = global::WindowsFormsApp1.Properties.Resources.home_1;
            this.b_phong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_phong.Location = new System.Drawing.Point(37, 423);
            this.b_phong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_phong.Name = "b_phong";
            this.b_phong.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_phong.Size = new System.Drawing.Size(240, 42);
            this.b_phong.TabIndex = 118;
            this.b_phong.Text = "Phòng";
            this.b_phong.TextColor = System.Drawing.Color.Black;
            this.b_phong.UseVisualStyleBackColor = false;
            // 
            // b_comeback
            // 
            this.b_comeback.BackColor = System.Drawing.Color.Black;
            this.b_comeback.BackgroundColor = System.Drawing.Color.Black;
            this.b_comeback.BorderColor = System.Drawing.Color.White;
            this.b_comeback.BorderRadius = 2;
            this.b_comeback.BorderSize = 1;
            this.b_comeback.FlatAppearance.BorderSize = 0;
            this.b_comeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_comeback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_comeback.ForeColor = System.Drawing.Color.White;
            this.b_comeback.Location = new System.Drawing.Point(37, 721);
            this.b_comeback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_comeback.Name = "b_comeback";
            this.b_comeback.Size = new System.Drawing.Size(240, 39);
            this.b_comeback.TabIndex = 117;
            this.b_comeback.Text = "Đăng xuất";
            this.b_comeback.TextColor = System.Drawing.Color.White;
            this.b_comeback.UseVisualStyleBackColor = false;
            // 
            // b_profile
            // 
            this.b_profile.BackColor = System.Drawing.Color.White;
            this.b_profile.BackgroundColor = System.Drawing.Color.White;
            this.b_profile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_profile.BorderRadius = 5;
            this.b_profile.BorderSize = 0;
            this.b_profile.FlatAppearance.BorderSize = 0;
            this.b_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_profile.ForeColor = System.Drawing.Color.Black;
            this.b_profile.Image = global::WindowsFormsApp1.Properties.Resources.profile_1;
            this.b_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_profile.Location = new System.Drawing.Point(37, 143);
            this.b_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_profile.Name = "b_profile";
            this.b_profile.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_profile.Size = new System.Drawing.Size(240, 42);
            this.b_profile.TabIndex = 47;
            this.b_profile.Text = "Trang cá nhân";
            this.b_profile.TextColor = System.Drawing.Color.Black;
            this.b_profile.UseVisualStyleBackColor = false;
            this.b_profile.Click += new System.EventHandler(this.b_profile_Click);
            // 
            // b_dichvu
            // 
            this.b_dichvu.BackColor = System.Drawing.Color.White;
            this.b_dichvu.BackgroundColor = System.Drawing.Color.White;
            this.b_dichvu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_dichvu.BorderRadius = 5;
            this.b_dichvu.BorderSize = 0;
            this.b_dichvu.FlatAppearance.BorderSize = 0;
            this.b_dichvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_dichvu.ForeColor = System.Drawing.Color.Black;
            this.b_dichvu.Image = global::WindowsFormsApp1.Properties.Resources.support_1;
            this.b_dichvu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_dichvu.Location = new System.Drawing.Point(37, 199);
            this.b_dichvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_dichvu.Name = "b_dichvu";
            this.b_dichvu.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_dichvu.Size = new System.Drawing.Size(240, 42);
            this.b_dichvu.TabIndex = 45;
            this.b_dichvu.Text = "Dịch vụ";
            this.b_dichvu.TextColor = System.Drawing.Color.Black;
            this.b_dichvu.UseVisualStyleBackColor = false;
            this.b_dichvu.Click += new System.EventHandler(this.b_dichvu_Click);
            // 
            // b_thietbi
            // 
            this.b_thietbi.BackColor = System.Drawing.Color.White;
            this.b_thietbi.BackgroundColor = System.Drawing.Color.White;
            this.b_thietbi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_thietbi.BorderRadius = 5;
            this.b_thietbi.BorderSize = 0;
            this.b_thietbi.FlatAppearance.BorderSize = 0;
            this.b_thietbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_thietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_thietbi.ForeColor = System.Drawing.Color.Black;
            this.b_thietbi.Image = global::WindowsFormsApp1.Properties.Resources.thietbi_1;
            this.b_thietbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_thietbi.Location = new System.Drawing.Point(37, 367);
            this.b_thietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_thietbi.Name = "b_thietbi";
            this.b_thietbi.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_thietbi.Size = new System.Drawing.Size(240, 42);
            this.b_thietbi.TabIndex = 44;
            this.b_thietbi.Text = "Thiết bị";
            this.b_thietbi.TextColor = System.Drawing.Color.Black;
            this.b_thietbi.UseVisualStyleBackColor = false;
            this.b_thietbi.Click += new System.EventHandler(this.b_thietbi_Click);
            // 
            // b_khachhang
            // 
            this.b_khachhang.BackColor = System.Drawing.Color.White;
            this.b_khachhang.BackgroundColor = System.Drawing.Color.White;
            this.b_khachhang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_khachhang.BorderRadius = 5;
            this.b_khachhang.BorderSize = 0;
            this.b_khachhang.FlatAppearance.BorderSize = 0;
            this.b_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_khachhang.ForeColor = System.Drawing.Color.Black;
            this.b_khachhang.Image = global::WindowsFormsApp1.Properties.Resources.user_2_1;
            this.b_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_khachhang.Location = new System.Drawing.Point(37, 480);
            this.b_khachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_khachhang.Name = "b_khachhang";
            this.b_khachhang.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_khachhang.Size = new System.Drawing.Size(240, 42);
            this.b_khachhang.TabIndex = 43;
            this.b_khachhang.Text = "Khách hàng";
            this.b_khachhang.TextColor = System.Drawing.Color.Black;
            this.b_khachhang.UseVisualStyleBackColor = false;
            this.b_khachhang.Click += new System.EventHandler(this.b_khachhang_Click);
            // 
            // b_nhanvien
            // 
            this.b_nhanvien.BackColor = System.Drawing.Color.White;
            this.b_nhanvien.BackgroundColor = System.Drawing.Color.White;
            this.b_nhanvien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_nhanvien.BorderRadius = 5;
            this.b_nhanvien.BorderSize = 0;
            this.b_nhanvien.FlatAppearance.BorderSize = 0;
            this.b_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_nhanvien.ForeColor = System.Drawing.Color.Black;
            this.b_nhanvien.Image = global::WindowsFormsApp1.Properties.Resources.user_1;
            this.b_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_nhanvien.Location = new System.Drawing.Point(37, 537);
            this.b_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_nhanvien.Name = "b_nhanvien";
            this.b_nhanvien.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_nhanvien.Size = new System.Drawing.Size(240, 42);
            this.b_nhanvien.TabIndex = 42;
            this.b_nhanvien.Text = "Nhân viên";
            this.b_nhanvien.TextColor = System.Drawing.Color.Black;
            this.b_nhanvien.UseVisualStyleBackColor = false;
            this.b_nhanvien.Click += new System.EventHandler(this.b_nhanvien_Click);
            // 
            // b_thongke
            // 
            this.b_thongke.BackColor = System.Drawing.Color.White;
            this.b_thongke.BackgroundColor = System.Drawing.Color.White;
            this.b_thongke.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.b_thongke.BorderRadius = 5;
            this.b_thongke.BorderSize = 0;
            this.b_thongke.FlatAppearance.BorderSize = 0;
            this.b_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_thongke.ForeColor = System.Drawing.Color.Black;
            this.b_thongke.Image = global::WindowsFormsApp1.Properties.Resources.thongke_11;
            this.b_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_thongke.Location = new System.Drawing.Point(37, 593);
            this.b_thongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_thongke.Name = "b_thongke";
            this.b_thongke.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.b_thongke.Size = new System.Drawing.Size(240, 42);
            this.b_thongke.TabIndex = 41;
            this.b_thongke.Text = "Thống kê";
            this.b_thongke.TextColor = System.Drawing.Color.Black;
            this.b_thongke.UseVisualStyleBackColor = false;
            this.b_thongke.Click += new System.EventHandler(this.b_thongke_Click);
            // 
            // lb_logo
            // 
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.lb_logo.Location = new System.Drawing.Point(32, 36);
            this.lb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(261, 89);
            this.lb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lb_logo.TabIndex = 40;
            this.lb_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(192, 825);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "V 0.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.KIWITECH;
            this.pictureBox1.Location = new System.Drawing.Point(85, 782);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(28, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1581, 853);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton bt_signout;
        private RJButton bt_dichvu;
        private RJButton bt_thietbi;
        private RJButton bt_thongke;
        private RJButton bt_khachhang;
        private RJButton bt_nhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton bt_lichtap;
        private RJButton bt_profile;
        private RJButton b_profile;
        private RJButton b_dichvu;
        private RJButton b_thietbi;
        private RJButton b_khachhang;
        private RJButton b_nhanvien;
        private RJButton b_thongke;
        private System.Windows.Forms.PictureBox lb_logo;
        private RJButton b_comeback;
        private RJButton b_phong;
        private RJButton b_hoadon;
        private System.Windows.Forms.Panel pnMain;
        private RJButton b_tapthu;
    }
}