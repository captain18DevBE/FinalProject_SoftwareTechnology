using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_profile : Form
    {
        private Controller ct = new Controller();
        private string sdt;
        private string password;
        public Form_profile()
        {
            InitializeComponent();
        }
        public void setSDT(string sdt)
        {
            this.sdt = sdt;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        private void Form_profile_Load(object sender, EventArgs e)
        {
            disableField(false);
            ShowInfor();
            pnChangePw.Visible= false;
            b_submit.Enabled=false;
            txt_makh.Enabled = false;
            txt_sdt.Enabled=false;
            if (ct.showTypeAccount(sdt)=="Nhân viên")
            {
                label_ma.Text = "Mã nhân viên";
            }
            else
            {
                label_ma.Text = "Mã khách hàng";
            }    
        }
        private void b_comeback_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form_Main form = new Form_Main();
            form.setSDT(sdt);
            form.ShowDialog();*/
            this.Close();
        }
        public void disableField(bool b)
        {
            txt_hoten.Enabled = b;
            txt_email.Enabled = b;
            txt_diachi.Enabled = b;
            rd_nam.Enabled = b;
            rd_nu.Enabled = b;
            txt_chucvu.Enabled = b;
            time_bd.Enabled = b;
        }
        private void ShowInfor()
        {
            if (ct.showTypeAccount(sdt) == "Khách hàng")
            {
                KhachHang kh = ct.getInfoKH(sdt);
                txt_makh.Text = kh.MaKH;
                txt_hoten.Text = kh.TenKH;
                txt_email.Text = kh.Email;
                txt_diachi.Text = kh.DiaChi;
                txt_sdt.Text = kh.SDT;
                time_bd.Text = kh.NgaySinh.ToString();
                if (kh.GioiTinh == "Nam")
                {
                    rd_nam.Checked = true;
                }
                else
                {
                    rd_nu.Checked = true;
                }
                txt_chucvu.Enabled = false;
                /*load ảnh khách hàng*/
                if (kh.AnhKH.Length!=0)
                {
                    using (MemoryStream ms = new MemoryStream(kh.AnhKH))
                    {
                        Image image = Image.FromStream(ms); // Tạo đối tượng hình ảnh từ mảng byte[]

                        // Hiển thị hình ảnh trong một PictureBox
                        img_avt.Image = image;
                    }
                }
            }
            else
            {
                NhanVien nv = ct.getInfoNV(sdt);
                txt_makh.Text = nv.MaNV;
                txt_hoten.Text = nv.TenNV;
                txt_email.Text = nv.Email;
                txt_diachi.Text = nv.DiaChi;
                txt_sdt.Text = nv.SDT;
                time_bd.Text = nv.NgaySinh.ToString();
                if (nv.GioiTinh == "Nam")
                {
                    rd_nam.Checked = true;
                }
                else
                {
                    rd_nu.Checked = true;
                }
                txt_chucvu.Text = nv.ChucVu;
                /*load ảnh nhân viên*/
                if (nv.AnhNV.Length != 0)
                {
                    using (MemoryStream ms = new MemoryStream(nv.AnhNV))
                    {
                        Image image = Image.FromStream(ms); // Tạo đối tượng hình ảnh từ mảng byte[]

                        // Hiển thị hình ảnh trong một PictureBox
                        img_avt.Image = image;
                    }
                }
            }
        }

        private void bt_doimk_Click(object sender, EventArgs e)
        {
            pnChangePw.Visible = true;
            b_save.Enabled= true;
        }
        public bool checkvalid()
        {
            if (string.IsNullOrEmpty(txt_pw.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ");
                txt_pw.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_npw.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                txt_npw.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_cnpw.Text))
            {
                MessageBox.Show("Bạn chưa xác nhận mật khẩu mới");
                txt_cnpw.Focus();
                return false;
            }
            return true;
        }
        private void b_save_Click(object sender, EventArgs e)
        {
            if (checkvalid())
            {
                if (txt_pw.Text == password)
                {
                    if (txt_npw.Text == txt_cnpw.Text)
                    {
                        
                        try
                        {
                            ct.ChangePsd(txt_npw.Text, sdt, password);
                            MessageBox.Show("Đổi mật khẩu thành công");
                            txt_pw.Text = "";
                            txt_cnpw.Text = "";
                            txt_npw.Text = "";
                            pnChangePw.Visible = false;
                            b_submit.Enabled= false;
                        }
                        catch
                        {
                            MessageBox.Show("Đã có lỗi xảy ra");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                }
            }
        }

        private void b_can_Click(object sender, EventArgs e)
        {
            txt_pw.Text = "";
            txt_cnpw.Text = "";
            txt_npw.Text = "";
            pnChangePw.Visible = false;
        }

        private void b_change_Click(object sender, EventArgs e)
        {
            disableField(true);
            b_submit.Enabled = true;
            txt_chucvu.Enabled = false;
        }
        private void b_submit_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rd_nam.Checked == true)
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }
            if (ct.showTypeAccount(sdt) == "Khách hàng")
            {
                try
                {
                    ct.editKHInfo(txt_makh.Text, txt_hoten.Text, txt_sdt.Text, time_bd.Value.Date, gender, txt_email.Text, txt_diachi.Text);
                    MessageBox.Show("Thay đổi thông tin cá nhân thành công");
                    disableField(false);
                    b_submit.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra");
                    disableField(false);
                    b_submit.Enabled = false;

                }
            }
            else
            {
                ct.editNVInfo(txt_makh.Text, txt_hoten.Text, txt_email.Text, txt_diachi.Text, time_bd.Value.Date, gender, txt_sdt.Text);

                try
                {
                    MessageBox.Show("Thay đổi thông tin cá nhân thành công");
                    disableField(false);
                    b_submit.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra");
                    disableField(false);
                    b_submit.Enabled = false;

                }
            }
        }

        private void b_doianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            // Chỉ cho phép chọn các file hình ảnh có phần mở rộng là .jpg,.jpeg,  .png, và .bmp
            openFileDialog.Filter = "Hình ảnh (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_avt.Image = new Bitmap(openFileDialog.FileName);
                if (ct.showTypeAccount(sdt) == "Khách hàng")
                {
                    ct.editAvaKH(txt_makh.Text, getPhoto());/*Thay đổi ảnh khách hàng*/
                }
                else
                {
                    ct.editAvaNV(txt_makh.Text, getPhoto());/*Thay đổi ảnh nhân viên*/
                }
                   
            }
        }
        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            img_avt.Image.Save(stream, img_avt.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
