namespace WindowsFormsApp1
{
    partial class Form_DangKy
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
            this.lb_register = new System.Windows.Forms.Label();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_checkpw = new System.Windows.Forms.TextBox();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.cb_address = new System.Windows.Forms.ComboBox();
            this.dtp_bd = new System.Windows.Forms.DateTimePicker();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_logo = new System.Windows.Forms.PictureBox();
            this.b_delete = new WindowsFormsApp1.RJButton();
            this.b_submit = new WindowsFormsApp1.RJButton();
            this.b_login = new WindowsFormsApp1.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_register.Location = new System.Drawing.Point(748, 103);
            this.lb_register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(248, 31);
            this.lb_register.TabIndex = 0;
            this.lb_register.Text = "Đăng ký tài khoản";
            // 
            // txt_fullName
            // 
            this.txt_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullName.ForeColor = System.Drawing.Color.Gray;
            this.txt_fullName.Location = new System.Drawing.Point(664, 160);
            this.txt_fullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_fullName.Multiline = true;
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(395, 29);
            this.txt_fullName.TabIndex = 2;
            this.txt_fullName.Text = "Họ và tên";
            this.txt_fullName.Enter += new System.EventHandler(this.txt_fullName_Enter);
            this.txt_fullName.Leave += new System.EventHandler(this.txt_fullName_Leave);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Gray;
            this.txt_email.Location = new System.Drawing.Point(664, 210);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(395, 29);
            this.txt_email.TabIndex = 4;
            this.txt_email.Text = "Email";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.Gray;
            this.txt_phone.Location = new System.Drawing.Point(664, 345);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(395, 29);
            this.txt_phone.TabIndex = 5;
            this.txt_phone.Text = "Số điện thoại";
            this.txt_phone.Enter += new System.EventHandler(this.txt_phone_Enter);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_password.Location = new System.Drawing.Point(664, 396);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(395, 29);
            this.txt_password.TabIndex = 6;
            this.txt_password.Text = "Mật khẩu";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_checkpw
            // 
            this.txt_checkpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_checkpw.ForeColor = System.Drawing.Color.Gray;
            this.txt_checkpw.Location = new System.Drawing.Point(664, 448);
            this.txt_checkpw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_checkpw.Multiline = true;
            this.txt_checkpw.Name = "txt_checkpw";
            this.txt_checkpw.Size = new System.Drawing.Size(395, 29);
            this.txt_checkpw.TabIndex = 7;
            this.txt_checkpw.Text = "Xác nhận mật khẩu";
            this.txt_checkpw.Enter += new System.EventHandler(this.txt_checkpw_Enter);
            this.txt_checkpw.Leave += new System.EventHandler(this.txt_checkpw_Leave);
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.BackColor = System.Drawing.SystemColors.Control;
            this.rd_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nam.Location = new System.Drawing.Point(791, 258);
            this.rd_nam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(60, 24);
            this.rd_nam.TabIndex = 8;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam";
            this.rd_nam.UseVisualStyleBackColor = false;
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nu.Location = new System.Drawing.Point(910, 258);
            this.rd_nu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(47, 24);
            this.rd_nu.TabIndex = 9;
            this.rd_nu.TabStop = true;
            this.rd_nu.Text = "Nữ";
            this.rd_nu.UseVisualStyleBackColor = true;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(670, 263);
            this.lb_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(76, 20);
            this.lb_gender.TabIndex = 13;
            this.lb_gender.Text = "Giới tính";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(670, 504);
            this.lb_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(64, 20);
            this.lb_address.TabIndex = 17;
            this.lb_address.Text = "Địa chỉ";
            // 
            // cb_address
            // 
            this.cb_address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_address.FormattingEnabled = true;
            this.cb_address.Items.AddRange(new object[] {
            "Huế",
            "Quảng Nam",
            "Quảng Ngãi",
            "Thanh Hóa",
            "Hồ Chí Minh"});
            this.cb_address.Location = new System.Drawing.Point(764, 497);
            this.cb_address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_address.Name = "cb_address";
            this.cb_address.Size = new System.Drawing.Size(296, 28);
            this.cb_address.TabIndex = 21;
            // 
            // dtp_bd
            // 
            this.dtp_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_bd.Location = new System.Drawing.Point(791, 301);
            this.dtp_bd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_bd.Name = "dtp_bd";
            this.dtp_bd.Size = new System.Drawing.Size(268, 26);
            this.dtp_bd.TabIndex = 23;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(670, 305);
            this.lb_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(87, 20);
            this.lb_date.TabIndex = 24;
            this.lb_date.Text = "Ngày sinh";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(670, 615);
            this.lb_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(179, 20);
            this.lb_login.TabIndex = 28;
            this.lb_login.Text = "Bạn đã có tài khoản?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.main;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1208, 739);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lb_logo
            // 
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.lb_logo.Location = new System.Drawing.Point(970, 20);
            this.lb_logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(184, 69);
            this.lb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lb_logo.TabIndex = 39;
            this.lb_logo.TabStop = false;
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.Black;
            this.b_delete.BackgroundColor = System.Drawing.Color.Black;
            this.b_delete.BorderColor = System.Drawing.Color.White;
            this.b_delete.BorderRadius = 2;
            this.b_delete.BorderSize = 1;
            this.b_delete.FlatAppearance.BorderSize = 0;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_delete.ForeColor = System.Drawing.Color.White;
            this.b_delete.Location = new System.Drawing.Point(734, 556);
            this.b_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(101, 28);
            this.b_delete.TabIndex = 41;
            this.b_delete.Text = "Hủy";
            this.b_delete.TextColor = System.Drawing.Color.White;
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_submit
            // 
            this.b_submit.BackColor = System.Drawing.Color.Black;
            this.b_submit.BackgroundColor = System.Drawing.Color.Black;
            this.b_submit.BorderColor = System.Drawing.Color.White;
            this.b_submit.BorderRadius = 2;
            this.b_submit.BorderSize = 1;
            this.b_submit.FlatAppearance.BorderSize = 0;
            this.b_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_submit.ForeColor = System.Drawing.Color.White;
            this.b_submit.Location = new System.Drawing.Point(910, 556);
            this.b_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(101, 28);
            this.b_submit.TabIndex = 40;
            this.b_submit.Text = "Xác nhận";
            this.b_submit.TextColor = System.Drawing.Color.White;
            this.b_submit.UseVisualStyleBackColor = false;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.Black;
            this.b_login.BackgroundColor = System.Drawing.Color.Black;
            this.b_login.BorderColor = System.Drawing.Color.White;
            this.b_login.BorderRadius = 2;
            this.b_login.BorderSize = 1;
            this.b_login.FlatAppearance.BorderSize = 0;
            this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.Color.White;
            this.b_login.Location = new System.Drawing.Point(910, 611);
            this.b_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(101, 28);
            this.b_login.TabIndex = 40;
            this.b_login.Text = "Đăng nhập";
            this.b_login.TextColor = System.Drawing.Color.White;
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 731);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.lb_logo);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.dtp_bd);
            this.Controls.Add(this.cb_address);
            this.Controls.Add(this.rd_nu);
            this.Controls.Add(this.rd_nam);
            this.Controls.Add(this.txt_checkpw);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_DangKy";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_checkpw;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.ComboBox cb_address;
        private System.Windows.Forms.DateTimePicker dtp_bd;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton bt_login;
        private RJButton bt_delete;
        private RJButton bt_submit;
        private System.Windows.Forms.PictureBox lb_logo;
        private RJButton b_login;
        private RJButton b_delete;
        private RJButton b_submit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

