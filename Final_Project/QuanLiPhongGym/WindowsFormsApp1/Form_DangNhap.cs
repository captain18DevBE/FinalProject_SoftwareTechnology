using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

//file chỉnh để push

namespace WindowsFormsApp1
{
    public partial class Form_DangNhap : Form
    {
        private Controller ct = new Controller();
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        private bool traslate = false;
        //Merge code
        //Mess res
        private string resLoginSuccess = "Đăng nhập thành công";
        private string errorAccountNotExist = "Tài khoản không tồn tại";
        private string errorValid = "Tài khoản hoặc mật khẩu không đúng";
        private string errorException = "Đã có lỗi xảy ra";
        //Mess res
        private void translateToEnglish()
        {
            ResourceManager resourceManager = new ResourceManager("WindowsFormsApp1.Resources", typeof(Resources).Assembly);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            lb_signin.Text = resourceManager.GetString("Đăng nhập");
            b_submit.Text = resourceManager.GetString("Xác nhận");
            lb_register.Text = resourceManager.GetString("Bạn chưa đăng ký tài khoản?");
            b_signup.Text = resourceManager.GetString("Đăng ký");

            resLoginSuccess = "Login successful";
            errorAccountNotExist = "Account does not exist";
            errorValid = "Incorrect username or password";
            errorException = "An error has occurred";
        }

        //Merge code

        private void Form2_Load(object sender, EventArgs e)
        {
            lb_signin.Parent = pictureBox1;
            lb_signin.BackColor = Color.Transparent;
            lb_signin.ForeColor = Color.White;

            lb_register.Parent = pictureBox1;
            lb_register.BackColor = Color.Transparent;
            lb_register.ForeColor = Color.White;

            lb_logo.Parent = pictureBox1;
            lb_register.BackColor = Color.Transparent;
            lb_register.ForeColor = Color.White;


        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            if (txt_phone.Text == "Số điện thoại")
            {
                txt_phone.Text = "";
                txt_phone.ForeColor = Color.Black;
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                txt_phone.Text = "Số điện thoại";
                txt_phone.ForeColor = Color.Gray;
            }
        }

        private void txt_pw_Enter(object sender, EventArgs e)
        {
            if (txt_pw.Text == "Mật khẩu")
            {
                txt_pw.Text = "";
                txt_pw.PasswordChar = '*';
                txt_pw.ForeColor = Color.Black;
            }
        }

        private void txt_pw_Leave(object sender, EventArgs e)
        {
            if (txt_pw.Text == "")
            {
                txt_pw.Text = "Mật khẩu";
                txt_pw.ForeColor = Color.Gray;
                txt_pw.PasswordChar = '\0';
            }
        }
        private void b_submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo Form_ProgressBar và ẩn nó
                Form_ProgressBar progressBar = new Form_ProgressBar();
                progressBar.Visible = false;

                if (ct.Login(txt_phone.Text, txt_pw.Text) == "success")
                {
                    // Hiển thị Form_ProgressBar
                    progressBar.Show();

                    // Tăng giá trị của ProgressBar từ 0 đến 100%
                    for (int i = 0; i <= 100; i += 10)
                    {
                        progressBar.SetProgress(i);
                        System.Threading.Thread.Sleep(100);
                    }

                    // Đóng Form_ProgressBar và mở Form_Main
                    progressBar.Close();
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    Form_Main form = new Form_Main();
                    form.setSDT(txt_phone.Text);
                    form.setPassword(txt_pw.Text);
                    form.ShowDialog();
                    this.Close();
                }
                else if (ct.Login(txt_phone.Text, txt_pw.Text) == "notexist")
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void b_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangKy form = new Form_DangKy();
            form.ShowDialog();
            this.Close();
        }

        private void cb_member_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_translateToEnglish_Click(object sender, EventArgs e)
        {
            translateToEnglish();
            traslate = true;
            this.Refresh();
        }
    }
}
