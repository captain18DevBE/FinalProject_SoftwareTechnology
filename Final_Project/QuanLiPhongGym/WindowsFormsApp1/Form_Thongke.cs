using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_ThongKe : Form
    {
        private Controller controller = new Controller();
        private List<ThongKe> thongkeList = new List<ThongKe>();
        public Form_ThongKe()
        {
            InitializeComponent();
        }
        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            cb_datetypestat.SelectedIndex = 0;
            cb_stattype.SelectedIndex = 0;
            dtp_datestat.Visible = false;
            lbl_total.AutoSize = false;
            lbl_total.TextAlign = ContentAlignment.MiddleRight;
            lbl_total.Anchor = AnchorStyles.Right;
        }
        private void cb_datetypestat_SelectedValueChanged(object sender, EventArgs e)
        {
            //TẤT CẢ
            if (cb_datetypestat.SelectedIndex == 0)
            {
                dtp_datestat.Visible = false;
            }
            //NGÀY
            else if (cb_datetypestat.SelectedIndex == 1)
            {
                dtp_datestat.Visible = true;
                dtp_datestat.Format = DateTimePickerFormat.Short;
                dtp_datestat.ShowUpDown = false;
            }
            //THÁNG
            else if (cb_datetypestat.SelectedIndex == 2)
            {
                dtp_datestat.Visible = true;
                dtp_datestat.Format = DateTimePickerFormat.Custom;
                dtp_datestat.CustomFormat = "MM/yyyy";
                dtp_datestat.ShowUpDown = true;
            }
            //NĂM
            else if (cb_datetypestat.SelectedIndex == 3)
            {
                dtp_datestat.Visible = true;
                dtp_datestat.Format = DateTimePickerFormat.Custom;
                dtp_datestat.CustomFormat = "yyyy";
                dtp_datestat.ShowUpDown = true;
            }
        }

        private void b_loadstat_Click(object sender, EventArgs e)
        {
            string loaingay = cb_datetypestat.Text;
            DateTime ngay = dtp_datestat.Value.Date;
            //DOANH THU DỊCH VỤ
            if (cb_stattype.SelectedIndex == 0)
            {
                List<ThongKe> thongkeList = controller.FilterThongKeDoanhThuDichVu(loaingay, ngay);
                grv_stat.DataSource = thongkeList;

                //Đặt tên cột
                grv_stat.Columns[0].HeaderText = "Mã DV";
                grv_stat.Columns[1].HeaderText = "Dịch Vụ";
                grv_stat.Columns[2].HeaderText = "Doanh Thu";
                //Chỉnh sửa chiều rộng cột
                grv_stat.Columns[0].Width = 65;
                grv_stat.Columns[1].Width = 150;
                grv_stat.Columns[2].Width = 86;

                //Vẽ biểu đồ thống kê
                chart_stat.DataSource = thongkeList;
                chart_stat.Series[0].XValueMember = "Ten";
                chart_stat.Series[0].YValueMembers = "TongTien";
                chart_stat.Series[0].Name = "Doanh Thu";
                chart_stat.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart_stat.DataBind();

                //Tính tổng tiền của tất cả các khách hàng
                int total = thongkeList.Sum(t => t.TongTien);
                lbl_title.Text = "Tổng Doanh Thu:";
                lbl_total.Text = total.ToString() + " VND";
            }
            //SỐ LƯỢT ĐĂNG KÝ DỊCH VỤ
            if (cb_stattype.SelectedIndex == 1)
            {
                List<ThongKe> thongkeList = controller.FilterThongKeSoLanDungKhachHang(loaingay, ngay);
                grv_stat.DataSource = thongkeList;

                //Đặt tên cột
                grv_stat.Columns[0].HeaderText = "Mã DV";
                grv_stat.Columns[1].HeaderText = "Dịch Vụ";
                grv_stat.Columns[2].HeaderText = "Lượt ĐK";
                //Chỉnh sửa chiều rộng cột
                grv_stat.Columns[0].Width = 65;
                grv_stat.Columns[1].Width = 150;
                grv_stat.Columns[2].Width = 86;

                //Vẽ biểu đồ thống kê
                chart_stat.DataSource = thongkeList;
                chart_stat.Series[0].XValueMember = "Ten";
                chart_stat.Series[0].YValueMembers = "TongTien";
                chart_stat.Series[0].Name = "Số Lượt Đăng Ký";
                chart_stat.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart_stat.DataBind();

                //Tính tổng tiền của tất cả các khách hàng
                int total = thongkeList.Sum(t => t.TongTien);
                lbl_title.Text = "Tổng Số Lượt Đăng Ký:";
                lbl_total.Text = total.ToString() + " lần";
            }
            //CHI TIÊU KHÁCH HÀNG
            if (cb_stattype.SelectedIndex == 2)
            {
                List<ThongKe> thongkeList = controller.FilterThongKeChiTieuKhachHang(loaingay, ngay);
                grv_stat.DataSource = thongkeList;

                //Đặt tên cột
                grv_stat.Columns[0].HeaderText = "Mã KH";
                grv_stat.Columns[1].HeaderText = "Khách Hàng";
                grv_stat.Columns[2].HeaderText = "Chi Tiêu";
                //Chỉnh sửa chiều rộng cột
                grv_stat.Columns[0].Width = 65;
                grv_stat.Columns[1].Width = 150;
                grv_stat.Columns[2].Width = 86;

                //Vẽ biểu đồ thống kê
                chart_stat.DataSource = thongkeList;
                chart_stat.Series[0].XValueMember = "Ten";
                chart_stat.Series[0].YValueMembers = "TongTien";
                chart_stat.Series[0].Name = "Chi Tiêu";
                chart_stat.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart_stat.Series[0]["PieLabelStyle"] = "Disabled";
                chart_stat.DataBind();

                //Tính tổng tiền của tất cả các khách hàng
                int total = thongkeList.Sum(t => t.TongTien);
                lbl_title.Text = "Tổng Chi Tiêu:";
                lbl_total.Text = total.ToString() + " VND";
            }
        }

        private void b_savestat_Click(object sender, EventArgs e)
        {
            save_chart.Filter = "bmp(*.bmp) | *.bmp | jpeg(*.jpeg) | *.jpeg | png(*.png) | *.png | tiff(*.tiff) | *.tiff";
            if (save_excel.ShowDialog() == DialogResult.OK)
            {
                controller.ExExcel(grv_stat, save_excel.FileName);
            }
            if (save_chart.ShowDialog() == DialogResult.OK)
            {
                chart_stat.SaveImage(save_chart.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
        }
    }
}
