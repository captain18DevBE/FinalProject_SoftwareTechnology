using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1
{
    public partial class Form_HoaDon : Form
    {
        private Controller controller = new Controller();
        private string sdt;
        public Form_HoaDon()
        {
            InitializeComponent();
        }
        public void setSDT(string sdt)
        {
            this.sdt = sdt;
        }
        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            //Thêm cột 
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            grv_bill.Columns.Add(column);
            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            grv_bill.Columns.Add(column1);
            //Đặt tên cột
            grv_bill.Columns[0].HeaderText = "HĐ";
            grv_bill.Columns[1].HeaderText = "Ngày";
            grv_bill.Columns[2].HeaderText = "Mã KH";
            grv_bill.Columns[3].HeaderText = "Tên Khách Hàng";
            grv_bill.Columns[4].HeaderText = "Phòng";
            grv_bill.Columns[5].HeaderText = "Mã DV";
            grv_bill.Columns[6].HeaderText = "Tên Dịch Vụ";
            grv_bill.Columns[7].HeaderText = "Nhân Viên";
            grv_bill.Columns[8].HeaderText = "SL";
            grv_bill.Columns[9].HeaderText = "Tổng Tiền";
            //Đặt DataProperty phù hợp 
            grv_bill.Columns[0].DataPropertyName = "MaHD";
            grv_bill.Columns[1].DataPropertyName = "Ngay";
            grv_bill.Columns[2].DataPropertyName = "MaKH";
            grv_bill.Columns[3].DataPropertyName = "TenKH";
            grv_bill.Columns[4].DataPropertyName = "Phong";
            grv_bill.Columns[5].DataPropertyName = "MaDV";
            grv_bill.Columns[6].DataPropertyName = "TenDV";
            grv_bill.Columns[7].DataPropertyName = "TenNV";
            grv_bill.Columns[8].DataPropertyName = "SoLuong";
            grv_bill.Columns[9].DataPropertyName = "TongTien";
            //Tùy chỉnh độ rộng cột
            grv_bill.Columns[0].Width = 60;
            grv_bill.Columns[1].Width = 70;
            grv_bill.Columns[2].Width = 65;
            grv_bill.Columns[3].Width = 140;
            grv_bill.Columns[4].Width = 97;
            grv_bill.Columns[5].Width = 65;
            grv_bill.Columns[6].Width = 125;
            grv_bill.Columns[7].Width = 80;
            grv_bill.Columns[8].Width = 25;
            grv_bill.Columns[9].Width = 80;
            //Chỉnh ngày Filter
            dtp_fromday.Value = new DateTime(2000, 1, 1);
            // Khởi tạo controller để lấy danh sách hóa đơn
            if (controller.showTypeAccount(sdt) == "Khách hàng")
            {
                KhachHang kh = new KhachHang();
                kh = controller.getInfoKH(sdt);
                // Gọi hàm GetHoaDonKhachHang để lấy danh sách hóa đơn từ database
                List<HoaDon> hoadonList = controller.LoadDataToGridViewByPhone(sdt);
                grv_bill.DataSource = hoadonList;
                txt_filtercustomerid.Text = kh.MaKH;
                txt_filtercustomername.Text = kh.TenKH;
                txt_filtercustomerid.Enabled = false;
                txt_filtercustomername.Enabled = false;
            }
            if (controller.showTypeAccount(sdt) == "Nhân viên")
            {
                // Gọi hàm GetHoaDon để lấy danh sách hóa đơn từ database
                List<HoaDon> hoadonList = controller.LoadDataToGridView();
                grv_bill.DataSource = hoadonList;
            }
        }

        private void b_filter_Click(object sender, EventArgs e)
        {
            string maHD = txt_filterbillid.Text;
            string maKH = txt_filtercustomerid.Text;
            string tenKH = txt_filtercustomername.Text;
            string maNV = txt_filterstaffid.Text;
            string tenNV = txt_filterstaffname.Text;
            string maPhong = txt_filterroomid.Text;
            string maDV = txt_filterserviceid.Text;
            string tenDV = txt_filterservicename.Text;
            DateTime fromDay = dtp_fromday.Value.Date;
            DateTime toDay = dtp_today.Value.Date;

            //Lấy dữ liệu từ Toolbox và gọi hàm FilterHoaDon để lọc hóa đơn
            List<HoaDon> filteredHoaDonList = controller.FilterHoaDon(maHD, maKH, tenKH, maDV, tenDV, maNV, tenNV, maPhong, fromDay, toDay);
            grv_bill.DataSource = filteredHoaDonList;
        }
    }
}
