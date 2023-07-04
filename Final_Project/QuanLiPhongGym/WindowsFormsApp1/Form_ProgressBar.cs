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
    public partial class Form_ProgressBar : Form
    {
        public Form_ProgressBar()
        {
            InitializeComponent();
        }

        public void SetProgress(int value)
        {
            // Cập nhật giá trị của ProgressBar trên Form_ProgressBar
            progressBar1.Value = value;
            // Hiển thị giá trị phần trăm trên Label
            lbl_percentage.ForeColor = Color.Black;
            lbl_percentage.Text = value.ToString() + "%";

            // Cho phép form cập nhật lại giao diện khi thanh ProgressBar thay đổi giá trị
            Application.DoEvents();
        }

        private void b_signup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}
