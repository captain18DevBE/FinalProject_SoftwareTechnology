using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_HoaDonLe : Form
    {
        int total = 0;
        private Controller controller = new Controller();
        KhachHang kh = new KhachHang();
        private string sdt;
        public Form_HoaDonLe(DataGridViewRow[] rows)
        {
            InitializeComponent();
            foreach (DataGridViewRow row in rows)
            {
                grv_hdl.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
            }
        }
        public void setSDT(string sdt)
        {
            this.sdt = sdt;
        }
        private void b_print_Click(object sender, EventArgs e)
        {

            string maKH = kh.MaKH;  // Giá trị của MaKH được sinh tự động
            string maNV = "NV001";  // Giá trị của MaNV được sinh tự động
            string phong = "";
            string maDV = "";
            foreach (DataGridViewRow row in grv_hdl.Rows)
            {
                phong = row.Cells[3].Value.ToString(); // Lấy giá trị của cột Phong từ dòng hiện tại trong DataGridView
                maDV = row.Cells[0].Value.ToString();  // Lấy giá trị của cột MaDV từ dòng hiện tại trong DataGridView
            }
            int tongTien = total;  // Lấy giá trị tổng tiền từ TextBox txt_total
            DateTime ngay = DateTime.Now;  // Lấy ngày hiện tại của hệ thống
            int soLuong = grv_hdl.Rows.Count;  // Đếm số lượng dòng trong DataGridView

            HoaDon hoaDon = new HoaDon();
            hoaDon.MaKH = maKH;
            hoaDon.MaNV = maNV;
            hoaDon.Phong = phong;
            hoaDon.MaDV = maDV;
            hoaDon.TongTien = tongTien;
            hoaDon.Ngay = ngay;
            hoaDon.SoLuong = soLuong;

            controller.insertHoaDon(hoaDon);


            // IN
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;

            DialogResult result = printdialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Tạo một StringBuilder để lưu trữ tất cả các dòng của DataGridView
                StringBuilder sb = new StringBuilder();

                // Duyệt qua từng hàng của DataGridView và thêm vào StringBuilder
                foreach (DataGridViewRow row in grv_hdl.Rows)
                {
                    sb.AppendFormat("{0}\t{1}\t{2}\n", row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
                }

                // Thêm tổng số tiền vào StringBuilder
                sb.AppendFormat("\nTổng: {0}", txt_total.Text);

                // Thực hiện in
                printDocument1.PrintPage += (s, ev) =>
                {
                    // Thiết lập font chữ và margin
                    Font font = new Font("Arial", 10);
                    int margin = 50;

                    // Tính toán kích thước của văn bản và khung
                    SizeF textSize = ev.Graphics.MeasureString(sb.ToString(), font);
                    RectangleF textRect = new RectangleF(ev.PageBounds.Left + margin, ev.PageBounds.Top + margin, ev.PageBounds.Width - margin * 2, ev.PageBounds.Height - margin * 2);

                    // Tính toán kích thước của chuỗi "Hóa Đơn"
                    SizeF titleSize = ev.Graphics.MeasureString("Hóa Đơn", font);

                    // Vẽ khung xung quanh văn bản
                    ev.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(textRect));

                    // Vẽ nội dung của StringBuilder vào PrintingEventArgs.Graphics
                    ev.Graphics.DrawString("Hóa Đơn", font, Brushes.Black, new PointF(textRect.Left + (textRect.Width - titleSize.Width) / 2, textRect.Top));
                    ev.Graphics.DrawString(sb.ToString(), font, Brushes.Black, new PointF(textRect.Left, textRect.Top + titleSize.Height));
                };

                printDocument1.Print();
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_HoaDonLe_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grv_hdl.Rows)
            {
                int value = Convert.ToInt32(row.Cells[2].Value);
                total += value;
            }
            txt_total.Text = total.ToString();
            kh = controller.getInfoKH(sdt);

        }
    }
}
