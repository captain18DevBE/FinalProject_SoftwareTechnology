using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form_Thietbi : Form
    {
        private Controller controller = new Controller();
        private bool isEditing = false;
        public Form_Thietbi()
        {
            InitializeComponent();
        }

        private void b_comeback_Click(object sender, EventArgs e)
        {
            /*   this.Hide();
               Form_Main form = new Form_Main();
               form.ShowDialog();
               this.Show();*/
            this.Close();
        }

        private void Form_Thietbi_Load(object sender, EventArgs e)
        {
            List<ThietBi> thietbilist = controller.LoadDataToGridViewThietBi();
            grv_thietbi.DataSource = thietbilist;
            grv_thietbi.ClearSelection();
        }

        private void b_tim_Click(object sender, EventArgs e)
        {
            string maTB = txt_matb.Text;
            bool found = false;

            // Duyệt qua từng hàng của DataGridView
            foreach (DataGridViewRow row in grv_thietbi.Rows)
            {
                if (row.Cells["MaTB"].Value != null && row.Cells["MaTB"].Value.ToString().Equals(maTB))
                {
                    // Nếu tìm thấy hàng có giá trị phù hợp, làm nổi bật nó
                    row.Selected = true;
                    found = true;
                    break; // Thoát khỏi vòng lặp vì đã tìm thấy hàng phù hợp
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy thiết bị có mã " + maTB);
            }

        }

        private void b_them_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng ThietBi từ thông tin được cung cấp
            ThietBi thietbi = new ThietBi
            {
                TenTB = txt_tenthietbi.Text,
                SoLuong = int.Parse(txt_soluong.Text),
                TinhTrang = cb_tinhtrang.Text,
                NgayNhap = DateTime.Parse(txt_ngaynhap.Text),
                AnhTB = new byte[0], // Nếu không có ảnh, đặt giá trị này thành null
            };

            // Gọi phương thức insertEquipment và hiển thị thông báo kết quả
            controller.insertEquipment(thietbi);

            // Cập nhật lại dữ liệu trên DataGridView
            grv_thietbi.DataSource = controller.LoadDataToGridViewThietBi();
        }

        private void b_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (grv_thietbi.SelectedRows.Count > 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = grv_thietbi.SelectedRows[0];
                string tenTB = row.Cells[1].Value.ToString();
                int soLuong = int.Parse(row.Cells[2].Value.ToString());
                string tinhTrang = row.Cells[3].Value.ToString();
                DateTime ngayNhap = DateTime.Parse(row.Cells[4].Value.ToString());

                txt_tenthietbi.Text = tenTB;
                txt_soluong.Text = soLuong.ToString();
                cb_tinhtrang.SelectedItem = tinhTrang;
                txt_ngaynhap.Text = ngayNhap.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn một hàng để sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b_capnhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (grv_thietbi.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrEmpty(txt_tenthietbi.Text) && !string.IsNullOrEmpty(txt_soluong.Text) && cb_tinhtrang.SelectedIndex != -1 && !string.IsNullOrEmpty(txt_ngaynhap.Text))
                {
                    // Lấy thông tin của hàng được chọn
                    DataGridViewRow row = grv_thietbi.SelectedRows[0];
                    string maTB = row.Cells["MaTB"].Value.ToString();

                    // Truyền các giá trị từng thuộc tính của đối tượng ThietBi vào phương thức editEquipmentInfo
                    controller.editEquipmentInfo(maTB, txt_tenthietbi.Text, int.Parse(txt_soluong.Text), cb_tinhtrang.Text, DateTime.Parse(txt_ngaynhap.Text), new byte[0]);
                }

                // Cập nhật lại dữ liệu trên DataGridView
                grv_thietbi.DataSource = controller.LoadDataToGridViewThietBi();

                // Xóa đi các giá trị đã nhập trên form
                txt_tenthietbi.Clear();
                txt_soluong.Clear();
                cb_tinhtrang.SelectedIndex = -1;
                txt_ngaynhap.Clear();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn một hàng để sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn hay không
            if (grv_thietbi.SelectedRows.Count > 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = grv_thietbi.SelectedRows[0];
                string maTB = row.Cells["MaTB"].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa dữ liệu
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa dữ liệu của thiết bị
                    controller.deleteEquipment(maTB);

                    // Cập nhật lại dữ liệu trên DataGridView
                    grv_thietbi.DataSource = controller.LoadDataToGridViewThietBi();
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
