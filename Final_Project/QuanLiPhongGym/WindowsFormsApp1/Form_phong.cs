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
    public partial class Form_phong : Form
    {
        private Controller controller = new Controller();
        public Form_phong()
        {
            InitializeComponent();
        }

        private void b_comeback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_phong_Load(object sender, EventArgs e)
        {
            List<Phong> phonglist = controller.LoadDataToGridViewPhong();
            grv_phong.DataSource = phonglist;
            grv_phong.ClearSelection();
        }

        private void b_them_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng Phong từ thông tin được cung cấp
            Phong phong = new Phong
            {
                TenPhong = txt_tenphong.Text,
                HienTrang = cb_tinhtrang.Text,
                SoNguoi = int.Parse(txt_songuoi.Text),
                AnhPhong = new byte[0], // Nếu không có ảnh, đặt giá trị này thành null
            };

            // Gọi phương thức insertEquipment và hiển thị thông báo kết quả
            controller.insertRoom(phong);

            // Cập nhật lại dữ liệu trên DataGridView
            grv_phong.DataSource = controller.LoadDataToGridViewPhong();
        }

        private void b_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (grv_phong.SelectedRows.Count > 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = grv_phong.SelectedRows[0];
                string tenPhong = row.Cells[1].Value.ToString();
                string tinhTrang = row.Cells[2].Value.ToString();
                int soLuong = int.Parse(row.Cells[3].Value.ToString());

                txt_tenphong.Text = tenPhong;
                cb_tinhtrang.SelectedItem = tinhTrang;
                txt_songuoi.Text = soLuong.ToString();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn một hàng để sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b_capnhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (grv_phong.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrEmpty(txt_tenphong.Text) && !string.IsNullOrEmpty(txt_songuoi.Text) && cb_tinhtrang.SelectedIndex != -1)
                {
                    // Lấy thông tin của hàng được chọn
                    DataGridViewRow row = grv_phong.SelectedRows[0];
                    string maPhong = row.Cells["MaPhong"].Value.ToString();

                    // Truyền các giá trị từng thuộc tính của đối tượng ThietBi vào phương thức editEquipmentInfo
                    controller.editRoomInfo(maPhong, txt_tenphong.Text, cb_tinhtrang.Text, int.Parse(txt_songuoi.Text), new byte[0]);
                }

                // Cập nhật lại dữ liệu trên DataGridView
                grv_phong.DataSource = controller.LoadDataToGridViewPhong();

                // Xóa đi các giá trị đã nhập trên form
                txt_tenphong.Clear();
                txt_songuoi.Clear();
                cb_tinhtrang.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Bạn cần chọn một hàng để sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (grv_phong.SelectedRows.Count > 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = grv_phong.SelectedRows[0];
                string maPhong = row.Cells["MaPhong"].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa dữ liệu
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa dữ liệu của thiết bị
                    controller.deleteRoom(maPhong);

                    // Cập nhật lại dữ liệu trên DataGridView
                    grv_phong.DataSource = controller.LoadDataToGridViewPhong();
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b_tim_Click(object sender, EventArgs e)
        {
            string maPhong = txt_maphong.Text;
            bool found = false;

            // Duyệt qua từng hàng của DataGridView
            foreach (DataGridViewRow row in grv_phong.Rows)
            {
                if (row.Cells["MaPhong"].Value != null && row.Cells["MaPhong"].Value.ToString().Equals(maPhong))
                {
                    // Nếu tìm thấy hàng có giá trị phù hợp, làm nổi bật nó
                    row.Selected = true;
                    found = true;
                    break; // Thoát khỏi vòng lặp vì đã tìm thấy hàng phù hợp
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy phòng có mã " + maPhong);
            }
        }
    }
}
