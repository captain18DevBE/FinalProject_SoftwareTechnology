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

//form chỉnh để push

namespace WindowsFormsApp1
{
    public partial class Form_QuanLyKH : Form
    {
        public Form_QuanLyKH()
        {
            InitializeComponent();
        }


        private Controller controller = new Controller();


        //String tranlated to English
        private string rowSelectedIsNull = "Chọn dòng thông tin khách hàng cần cập nhật thông tin";
        private string notExistCustomer = "Không tìm thấy khách hàng có ID: ";

        private void translateToEnglish()
        {
            //string tranlateFilePath = "Resources.en.resx";
            ResourceManager resourceManager = new ResourceManager("WindowsFormsApp1.Resources", typeof(Resources).Assembly);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            btn_EditInfCustomer.Text = resourceManager.GetString("Chỉnh sửa");
            btn_refreshListCustomer.Text = resourceManager.GetString("Làm mới");
            lb_TiltlePanelEditCustomer.Text = resourceManager.GetString("Cập Nhật Thông Tin Khách Hàng");
            lb_updateHeight.Text = resourceManager.GetString("Cập nhật chiều cao");
            lb_updateWeight.Text = resourceManager.GetString("Cập nhật cân nặng");
            btn_ExitFormEdit.Text = resourceManager.GetString("Đóng");
            btn_UpdateCustomerForm.Text = resourceManager.GetString("Lưu");
            rowSelectedIsNull = "Select the customer information row to update.";
            notExistCustomer = "Customer with ID: not found.";
        }

        private void Form_QuanLyKH_Load(object sender, EventArgs e)
        {
            pnl_SubFormEdit.Width = 0;
            tbt_SearchCustomerByID.GotFocus += new EventHandler(tbt_SearchEmployer_GotFocus);
            tbt_SearchCustomerByID.LostFocus += new EventHandler(tbt_SearchEmployer_LostFocus);
            tbt_SearchCustomerByID.Text = "Nhập ID VD: KH001";
            tbt_SearchCustomerByID.ForeColor = Color.Gray;
            loadListData();
            //Test stranlate English

            translateToEnglish();

            //Test stranlate English
        }

        private void tbt_SearchEmployer_GotFocus(object sender, EventArgs e)
        {
            if (tbt_SearchCustomerByID.Text == "Nhập ID VD: KH001")
            {
                tbt_SearchCustomerByID.Text = "";
                tbt_SearchCustomerByID.ForeColor = Color.Black;
            }
        }

        private void tbt_SearchEmployer_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbt_SearchCustomerByID.Text))
            {
                tbt_SearchCustomerByID.Text = "Nhập ID VD: KH001";
                tbt_SearchCustomerByID.ForeColor = Color.Gray;
            }
        }

        private void loadListData()
        {
            List<KhachHang> khachHangs;
            khachHangs = controller.displayCustomerToDGV();
            dGV_ListCustomer.AutoGenerateColumns = true;
            dGV_ListCustomer.DataSource = khachHangs;
            dGV_ListCustomer.Columns["MaKH"].HeaderText = "ID";
            dGV_ListCustomer.Columns["MaKH"].DataPropertyName = "MaKH";
            dGV_ListCustomer.Columns["MaKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["MaKH"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGV_ListCustomer.Columns["TenKH"].HeaderText = "Họ và Tên";
            dGV_ListCustomer.Columns["TenKH"].DataPropertyName = "TenKH";
            dGV_ListCustomer.Columns["TenKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["TenKH"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGV_ListCustomer.Columns["Email"].HeaderText = "Email";
            dGV_ListCustomer.Columns["Email"].DataPropertyName = "Email";
            dGV_ListCustomer.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGV_ListCustomer.Columns["GioiTinh"].HeaderText = "Giới tính";
            dGV_ListCustomer.Columns["GioiTinh"].DataPropertyName = "GioiTinh";
            dGV_ListCustomer.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["GioiTinh"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGV_ListCustomer.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dGV_ListCustomer.Columns["NgaySinh"].DataPropertyName = "NgaySinh";
            dGV_ListCustomer.Columns["NgaySinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["NgaySinh"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGV_ListCustomer.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dGV_ListCustomer.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dGV_ListCustomer.Columns["DiaChi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["DiaChi"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGV_ListCustomer.Columns["Sdt"].HeaderText = "Số điện thoại";
            dGV_ListCustomer.Columns["Sdt"].DataPropertyName = "Sdt";
            dGV_ListCustomer.Columns["Sdt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["Sdt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGV_ListCustomer.Columns["AnhKH"].HeaderText = "Hình ảnh";
            dGV_ListCustomer.Columns["AnhKH"].DataPropertyName = "AnhKH";
            dGV_ListCustomer.Columns["AnhKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGV_ListCustomer.Columns["AnhKH"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void TimerCustomer_Tick_1(object sender, EventArgs e)
        {
            if (pnl_SubFormEdit.Width >= 390)
            {
                for (int i = 0; i < 10; i++)
                {
                    pnl_SubFormEdit.Width = pnl_SubFormEdit.Width - 39;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    pnl_SubFormEdit.Width = pnl_SubFormEdit.Width + 39;
                }
            }
            TimerCustomer.Stop();
        }



        private void btn_ExitFormEdit_Click(object sender, EventArgs e)
        {
            TimerCustomer.Start();
            CusomerPnlTop.Enabled = true;
        }

        private void btn_onClickSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbt_SearchCustomerByID.Text.Trim();
            if (searchValue != null)
            {
                foreach (DataGridViewRow row in dGV_ListCustomer.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dGV_ListCustomer.CurrentCell = row.Cells[0];
                            row.Selected = true;
                            dGV_ListCustomer.FirstDisplayedScrollingRowIndex = row.Index;
                            return;
                        }
                    }
                }
                MessageBox.Show(notExistCustomer + searchValue);
            }
        }

        DataGridViewRow selectedRow = null;

        private void btn_EditInfCustomer_Click_1(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show(rowSelectedIsNull);
            }
            TimerCustomer.Start();
            CusomerPnlTop.Enabled = false;

        }

        private void dGV_ListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (selectedRow != null)
                {
                    selectedRow.DefaultCellStyle.BackColor = Color.White;
                }
                selectedRow = dGV_ListCustomer.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void btn_UpdateCustomerForm_Click(object sender, EventArgs e)
        {
            string MaKH = selectedRow.Cells[0].Value.ToString();
            string weight = tb_updateWeight.Text;
            string height = tb_updateHeight.Text;
            controller.updateCustomer(MaKH, height, weight);
        }

        private void btn_refreshListCustomer_Click(object sender, EventArgs e)
        {
            loadListData();
        }
    }
}
