namespace WindowsFormsApp1
{
    partial class Form_DangNhap
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
            this.lb_signin = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_register = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_logo = new System.Windows.Forms.PictureBox();
            this.b_signup = new WindowsFormsApp1.RJButton();
            this.b_submit = new WindowsFormsApp1.RJButton();
            this.btn_translateToEnglish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_signin
            // 
            this.lb_signin.AutoSize = true;
            this.lb_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_signin.Location = new System.Drawing.Point(796, 184);
            this.lb_signin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_signin.Name = "lb_signin";
            this.lb_signin.Size = new System.Drawing.Size(155, 31);
            this.lb_signin.TabIndex = 0;
            this.lb_signin.Text = "Đăng nhập";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.Color.Gray;
            this.txt_phone.Location = new System.Drawing.Point(680, 249);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(395, 29);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.Text = "Số điện thoại";
            this.txt_phone.Enter += new System.EventHandler(this.txt_phone_Enter);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // txt_pw
            // 
            this.txt_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.ForeColor = System.Drawing.Color.Gray;
            this.txt_pw.Location = new System.Drawing.Point(680, 308);
            this.txt_pw.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pw.Multiline = true;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(395, 29);
            this.txt_pw.TabIndex = 4;
            this.txt_pw.Text = "Mật khẩu";
            this.txt_pw.UseWaitCursor = true;
            this.txt_pw.Enter += new System.EventHandler(this.txt_pw_Enter);
            this.txt_pw.Leave += new System.EventHandler(this.txt_pw_Leave);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_register.Location = new System.Drawing.Point(690, 474);
            this.lb_register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(241, 20);
            this.lb_register.TabIndex = 10;
            this.lb_register.Text = "Bạn chưa đăng ký tài khoản?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1190, 701);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_logo
            // 
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.lb_logo.Location = new System.Drawing.Point(950, 14);
            this.lb_logo.Margin = new System.Windows.Forms.Padding(2);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(184, 69);
            this.lb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lb_logo.TabIndex = 39;
            this.lb_logo.TabStop = false;
            // 
            // b_signup
            // 
            this.b_signup.BackColor = System.Drawing.Color.Black;
            this.b_signup.BackgroundColor = System.Drawing.Color.Black;
            this.b_signup.BorderColor = System.Drawing.Color.White;
            this.b_signup.BorderRadius = 2;
            this.b_signup.BorderSize = 1;
            this.b_signup.FlatAppearance.BorderSize = 0;
            this.b_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_signup.ForeColor = System.Drawing.Color.White;
            this.b_signup.Location = new System.Drawing.Point(972, 466);
            this.b_signup.Margin = new System.Windows.Forms.Padding(2);
            this.b_signup.Name = "b_signup";
            this.b_signup.Size = new System.Drawing.Size(101, 28);
            this.b_signup.TabIndex = 42;
            this.b_signup.Text = "Đăng ký";
            this.b_signup.TextColor = System.Drawing.Color.White;
            this.b_signup.UseVisualStyleBackColor = false;
            this.b_signup.Click += new System.EventHandler(this.b_signup_Click);
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
            this.b_submit.Location = new System.Drawing.Point(680, 392);
            this.b_submit.Margin = new System.Windows.Forms.Padding(2);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(394, 28);
            this.b_submit.TabIndex = 43;
            this.b_submit.Text = "Xác nhận";
            this.b_submit.TextColor = System.Drawing.Color.White;
            this.b_submit.UseVisualStyleBackColor = false;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // btn_translateToEnglish
            // 
            this.btn_translateToEnglish.Location = new System.Drawing.Point(1043, 112);
            this.btn_translateToEnglish.Name = "btn_translateToEnglish";
            this.btn_translateToEnglish.Size = new System.Drawing.Size(75, 23);
            this.btn_translateToEnglish.TabIndex = 44;
            this.btn_translateToEnglish.Text = "Tiếng Anh";
            this.btn_translateToEnglish.UseVisualStyleBackColor = true;
            this.btn_translateToEnglish.Click += new System.EventHandler(this.btn_translateToEnglish_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.btn_translateToEnglish);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.b_signup);
            this.Controls.Add(this.lb_logo);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lb_signin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_DangNhap";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_signin;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton bt_signup;
        private RJButton bt_submit;
        private System.Windows.Forms.PictureBox lb_logo;
        private RJButton b_signup;
        private RJButton b_submit;
        private System.Windows.Forms.Button btn_translateToEnglish;
    }
}