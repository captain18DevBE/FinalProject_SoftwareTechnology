using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        Controller ct = new Controller();
        private string sdt;
        private string password;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void translateToEnglish()
        {
            ResourceManager resourceManager = new ResourceManager("WindowsFormsApp1.Resources", typeof(Resources).Assembly);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            b_profile.Text = resourceManager.GetString("Trang cá nhân");
            b_dichvu.Text = resourceManager.GetString("Dịch vụ");
            b_hoadon.Text = resourceManager.GetString("Hóa đơn");
            b_tapthu.Text = resourceManager.GetString("Tập thử");
            b_thietbi.Text = resourceManager.GetString("Thiết bị");
            b_phong.Text = resourceManager.GetString("Phòng");
            b_khachhang.Text = resourceManager.GetString("Khách hàng");
            b_nhanvien.Text = resourceManager.GetString("Nhân viên");
            b_thongke.Text = resourceManager.GetString("Thống kê");
            b_comeback.Text = resourceManager.GetString("Đăng xuất");
        }

        public void setSDT(string sdt)
        {
            this.sdt = sdt;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (ct.showTypeAccount(sdt) == "Khách hàng")
            {
                b_thongke.Visible = false;
            }
            if (ct.showTypeAccount(sdt) == "Nhân viên")
            {
                b_thongke.Visible = true;
            }
            /*            if (true)
                        {
                            b_thongke.Visible= false;
                            b_khachhang.Visible= false;
                            b_thietbi.Visible= false;
                            b_nhanvien.Visible= false;
                            b_phong.Visible= false;
                            b_hoadon.Visible= false;
                        }*/
            //Test tranlate
            translateToEnglish();
            //Test tranlate
        }
        private void b_thongke_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_ThongKe form = new Form_ThongKe();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }


        private void b_nhanvien_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_QuanLyNhanVien form = new Form_QuanLyNhanVien();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }

        private void b_khachhang_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_QuanLyKH form = new Form_QuanLyKH();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }

        private void b_thietbi_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_Thietbi form = new Form_Thietbi();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }

        private void b_dichvu_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            if (ct.showTypeAccount(sdt) == "Khách hàng")
            {
                Form_DangKyDichVu form = new Form_DangKyDichVu();
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.AutoScroll = true;
                form.Dock = DockStyle.Fill;
                form.setSDT(sdt);
                pnMain.Controls.Add(form);
                form.Show();
            }
            if (ct.showTypeAccount(sdt) == "Nhân viên")
            {
                Form_QuanLyDichVu form = new Form_QuanLyDichVu();
                form.FormBorderStyle = FormBorderStyle.None;
                form.TopLevel = false;
                form.AutoScroll = true;
                form.Dock = DockStyle.Fill;
                pnMain.Controls.Add(form);
                form.Show();
            }
        }

        private void b_profile_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_profile form = new Form_profile();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.setSDT(sdt);
            form.setPassword(password);
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }

        private void b_comeback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap form = new Form_DangNhap();
            form.ShowDialog();
            this.Show();
            this.Close();
        }

        private void b_phong_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_phong form = new Form_phong();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            /*form.setSDT(sdt);*/
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }

        private void lb_logo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main form = new Form_Main();
            form.setSDT(sdt);
            form.setPassword(password);
            form.ShowDialog();
            this.Show();
        }

        private void b_tapthu_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_TapThu form = new Form_TapThu();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            /*form.setSDT(sdt);*/
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            form.Show();
        }

        private void b_hoadon_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Form_HoaDon form = new Form_HoaDon();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            form.setSDT(sdt);
            pnMain.Controls.Add(form);
            form.Show();
        }

    }
}
