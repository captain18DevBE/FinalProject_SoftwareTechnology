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

namespace WindowsFormsApp1
{
    public partial class Form_DangKyDichVu : Form
    {
        private Controller controller = new Controller();
        private string sdt;
        public void setSDT(string sdt)
        {
            this.sdt = sdt;
        }

        public Form_DangKyDichVu()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_DangKyDichVu_Load(object sender, EventArgs e)
        {
            List<DichVu> dichvulist = controller.LoadDataToGridViewDKDV();
            grv_dkdv.DataSource = dichvulist;

            // TODO: This line of code loads data into the 'qUANLYPHONGGYMDataSet.DICHVUDADANGKY' table. You can move, or remove it, as needed.
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grv_dkdv.SelectedRows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                newRow.CreateCells(grv_dadkdv); // tạo các ô cho hàng mới
                newRow.Cells[0].Value = row.Cells[0].Value;
                newRow.Cells[1].Value = row.Cells[1].Value;
                newRow.Cells[2].Value = row.Cells[2].Value;
                newRow.Cells[3].Value = row.Cells[3].Value;
                grv_dadkdv.Rows.Add(newRow);
            }

        }

        private void btn_oke_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] rows = new DataGridViewRow[grv_dadkdv.Rows.Count];

            for (int i = 0; i < grv_dadkdv.Rows.Count; i++)
            {
                rows[i] = grv_dadkdv.Rows[i];
            }

            Form_HoaDonLe form = new Form_HoaDonLe(rows);
            form.setSDT(sdt);
            form.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grv_dadkdv.SelectedRows)
            {
                if (!row.IsNewRow) // Kiểm tra hàng không phải là hàng mới
                {
                    grv_dadkdv.Rows.Remove(row);
                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbb_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPhong = cbb_phong.SelectedItem.ToString();
            List<DichVu> filteredClasses = new List<DichVu>();
            List<DichVu> dichvulist = controller.LoadDataToGridViewDKDV();

            foreach (DichVu dv in dichvulist)
            {
                if (dv.Phong.Equals(selectedPhong))
                {
                    filteredClasses.Add(dv);
                }
            }

            grv_dkdv.DataSource = filteredClasses;
        }
    }
}
