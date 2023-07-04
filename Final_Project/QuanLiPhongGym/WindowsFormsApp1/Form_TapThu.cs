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
    public partial class Form_TapThu : Form
    {
        private Controller controller = new Controller();
        private string sdt;
        public void setSDT(string sdt)
        {
            this.sdt = sdt;
        }
        public Form_TapThu()
        {
            InitializeComponent();
        }

        private void Form_TapThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYPHONGGYMDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.qUANLYPHONGGYMDataSet.DICHVU);
            List<DichVu> dichvulist = controller.LoadDataToGridViewDKDV();
            grv_dktt.DataSource = dichvulist;
        }

        private void grv_dktt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grv_dktt.CurrentRow.Selected = true;
            int id = Convert.ToInt32(grv_dktt.Rows[e.RowIndex].Cells["MaDV"].FormattedValue);
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1TGOCSEI\SQLEXPRESS;Initial Catalog=QUANLYPHONGGYM;Integrated Security=True; MultipleActiveResultSets=true");
            con.Open();
            SqlCommand cm = new SqlCommand("Select AnhDV from DICHVU where MaDV = '"+id+"'", con);
            string img = cm.ExecuteScalar().ToString();
            pictureBox1.Image = Image.FromFile(img);
            con.Close();
        }
    }
}
