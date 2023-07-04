using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Principal;
using System.Globalization;
using System.Resources;
using System.Threading;
using WindowsFormsApp1.Properties;

//File này v5 up git
namespace WindowsFormsApp1
{
    public partial class Form_DangKy : Form
    {
        private Controller ct = new Controller();
        public Form_DangKy()
        {
            InitializeComponent();
        }

        //Merge code

        //Mess err
        private string errorEmail = "Vui lòng nhập đúng định dạng email!";
        private string errorDateOfBirth = "Vui lòng nhập đúng năm sinh";
        private string errorAddress = "Vui lòng chọn quê quán!";
        private string errorPhoneNumber = "Vui lòng nhập lại sđt!";
        private string erroePassWord = "Vui lòng nhập mật khẩu dài từ 6-24 ký tự, với các chữ và số, chữ hoa và chữ thường!";
        private string errorConfirmPass = "Vui lòng xác nhận lại mật khẩu!";
        private string errorRegis = "Đăng ký thất bại";

        private void translateToEnglish()
        {
            ResourceManager resourceManager = new ResourceManager("WindowsFormsApp1.Resources", typeof(Resources).Assembly);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            lb_register.Text = resourceManager.GetString("Đăng ký tài khoản");
            lb_gender.Text = resourceManager.GetString("Giới tính");
            rd_nam.Text = resourceManager.GetString("Nam");
            rd_nu.Text = resourceManager.GetString("Nữ");
            lb_date.Text = resourceManager.GetString("Ngày sinh");
            lb_address.Text = resourceManager.GetString("Địa chỉ");
            b_delete.Text = resourceManager.GetString("Hủy");
            b_submit.Text = resourceManager.GetString("Xác nhận");
            lb_login.Text = resourceManager.GetString("Bạn đã có tài khoản?");
            b_login.Text = resourceManager.GetString("Đăng nhập");
        }

        //Merge code

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test translate
            translateToEnglish();
            //Test translate
            lb_gender.Parent = pictureBox2;
            lb_gender.BackColor = Color.Transparent;
            lb_gender.ForeColor = Color.White;

            lb_date.Parent = pictureBox2;
            lb_date.BackColor = Color.Transparent;
            lb_date.ForeColor = Color.White;

            lb_address.Parent = pictureBox2;
            lb_address.BackColor = Color.Transparent;
            lb_address.ForeColor = Color.White;

            rd_nam.Parent = pictureBox2;
            rd_nam.BackColor = Color.Transparent;
            rd_nam.ForeColor = Color.White;

            rd_nu.Parent = pictureBox2;
            rd_nu.BackColor = Color.Transparent;
            rd_nu.ForeColor = Color.White;

            lb_login.Parent = pictureBox2;
            lb_login.BackColor = Color.Transparent;
            lb_login.ForeColor = Color.White;

            lb_register.Parent = pictureBox2;
            lb_register.BackColor = Color.Transparent;
            lb_register.ForeColor = Color.White;

            lb_logo.Parent = pictureBox2;
            lb_register.BackColor = Color.Transparent;
            lb_register.ForeColor = Color.White;

        }
        public bool CheckSdt(string sdt)
        {
            return Regex.IsMatch(sdt, "^[0-9]{10,12}$");
        }

        public bool CheckMK(string mk)
        {
            return Regex.IsMatch(mk, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string e)
        {
            return Regex.IsMatch(e, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        void Clear()
        {
            txt_fullName.Text = "Full Name";
            txt_fullName.ForeColor = Color.Gray;
            txt_email.Text = "Email";
            txt_email.ForeColor = Color.Gray;
            txt_phone.Text = "Phone Number";
            txt_phone.ForeColor = Color.Gray;
            txt_password.Text= "Password";
            txt_password.ForeColor = Color.Gray;
            txt_checkpw.Text = "Confirm Password";
            txt_checkpw.ForeColor = Color.Gray;
            dtp_bd.ResetText();
            cb_address.Text = " ";

        }

        private void txt_fullName_Enter(object sender, EventArgs e)
        {
            if (txt_fullName.Text == "Họ và tên")
            {
                txt_fullName.Text = "";
                txt_fullName.ForeColor = Color.Black;
            }
        }

        private void txt_fullName_Leave(object sender, EventArgs e)
        {
            if (txt_fullName.Text == "")
            {
                txt_fullName.Text = "Họ và tên";
                txt_fullName.ForeColor = Color.Gray;
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.Gray;
            }
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

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Mật khẩu")
            {
                txt_password.Text = "";
                txt_password.PasswordChar = '*';
                txt_password.ForeColor = Color.Black;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Mật khẩu";
                txt_password.ForeColor = Color.Gray;
                txt_password.PasswordChar = '\0';
            }
        }

        private void txt_checkpw_Enter(object sender, EventArgs e)
        {
            if (txt_checkpw.Text == "Xác nhận mật khẩu")
            {
                txt_checkpw.Text = "";
                txt_checkpw.PasswordChar= '*';
                txt_checkpw.ForeColor = Color.Black;
            }
        }

        private void txt_checkpw_Leave(object sender, EventArgs e)
        {
            if (txt_checkpw.Text == "")
            {
                txt_checkpw.Text = "Xác nhận mật khẩu";
                txt_checkpw.ForeColor = Color.Gray;
                txt_checkpw.PasswordChar = '\0';
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            // Email
            if (!CheckEmail(txt_email.Text))
            {
                txt_email.ForeColor = Color.Red; // đổi màu chữ thành đỏ
                errorProvider1.SetError(txt_email, errorEmail);
                return;
            }
            else
            {
                // Nếu người dùng nhập đúng, xoá thông báo lỗi và đổi lại màu chữ về mặc định
                errorProvider1.SetError(txt_email, "");
                txt_email.ForeColor = SystemColors.WindowText; // hoặc gán thành Color.Black nếu muốn màu đen
            }
            
            // Ngay sinh
            if (dtp_bd.Value.Year < 1900 || dtp_bd.Value.Year > 2023)
            {
                errorProvider1.SetError(dtp_bd, errorDateOfBirth);
                return;
            }
            else
            {
                errorProvider1.SetError(dtp_bd, "");
            } 

            // Dia chi
            if (cb_address.SelectedItem == null)
            {
                errorProvider1.SetError(cb_address, errorAddress);
                return;
            } 
            else
            {
                errorProvider1.SetError(cb_address, "");
            }
            
            // So dien thoai
            if (!CheckSdt(txt_phone.Text))
            {

                txt_phone.ForeColor = Color.Red; // đổi màu chữ thành đỏ
                errorProvider1.SetError(txt_phone, errorPhoneNumber);
                return;
            } 
            else
            {
                // Nếu người dùng nhập đúng, xoá thông báo lỗi và đổi lại màu chữ về mặc định
                errorProvider1.SetError(txt_phone, "");
                txt_phone.ForeColor = SystemColors.WindowText; // hoặc gán thành Color.Black nếu muốn màu đen
            }

            // Mat khau
            if (!CheckMK(txt_password.Text))
            {
                txt_password.ForeColor = Color.Red; // đổi màu chữ thành đỏ
                errorProvider1.SetError(txt_password, erroePassWord);
                return;
            }
            else
            {
                // Nếu người dùng nhập đúng, xoá thông báo lỗi và đổi lại màu chữ về mặc định
                errorProvider1.SetError(txt_password, "");
                txt_password.ForeColor = SystemColors.WindowText; // hoặc gán thành Color.Black nếu muốn màu đen
            }

            if (txt_checkpw.Text != txt_password.Text)
            {
                txt_checkpw.ForeColor = Color.Red; // đổi màu chữ thành đỏ
                errorProvider1.SetError(txt_checkpw, errorConfirmPass);
                return;
            } 
            else
            {
                errorProvider1.SetError(txt_checkpw, "");
                txt_checkpw.ForeColor = SystemColors.WindowText; // hoặc gán thành Color.Black nếu muốn màu đen
            }


            if (CheckEmail(txt_email.Text) && (dtp_bd.Value.Year >= 1900 || dtp_bd.Value.Year <= 2023) && cb_address.SelectedItem != null && CheckSdt(txt_phone.Text) && CheckMK(txt_password.Text) && txt_checkpw.Text == txt_password.Text) {
                string tgender = "";
                if (rd_nam.Checked)
                {
                    tgender = rd_nam.Text;
                }
                if (rd_nu.Checked)
                {
                    tgender = rd_nu.Text;
                }
                try
                {
                    string noti = ct.Signup(txt_fullName.Text, txt_email.Text, tgender, dtp_bd.Value.Date, cb_address.Text, txt_phone.Text.Trim(), txt_password.Text, "");
                    MessageBox.Show(noti);
                    if(noti == "Đăng ký thành công")
                    {
                        this.Hide();
                        Form_Main form = new Form_Main();
                        form.setSDT(txt_phone.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show(errorRegis);
                }
            }
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap form= new Form_DangNhap();
            form.ShowDialog();
            this.Show();
                  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
