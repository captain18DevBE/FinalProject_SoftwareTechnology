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

//form chinh de push
namespace WindowsFormsApp1
{
    public partial class Form_QuanLyDichVu : Form
    {
        //Merger code

        private Controller controller = new Controller();

        public Form_QuanLyDichVu()
        {
            InitializeComponent();
        }

        //Mess error
        private string errorName = "Vui lòng nhập Tên Dịch Vụ!";
        private string errorPriceService = "Vui lòng nhập giá dịch vụ là số nguyên  dương!";
        private string errorSearching = "Không tìm thấy dịch vụ có ID: ";
        private string titleChanged = "Cập Nhật Gói Dịch Vụ";
        private string errorRowSelected = "Chọn dòng thông tin dịch vụ cần cập nhật thông tin!";
        private string errorRowDelete = "Chọn dòng thông tin dịch vụ cần xóa";
        //Mess error

        private void translateToEnglish()
        {
            //string tranlateFilePath = "Resources.en.resx";
            ResourceManager resourceManager = new ResourceManager("WindowsFormsApp1.Resources", typeof(Resources).Assembly);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            btnFornDV.Text = resourceManager.GetString("Thêm");
            btnXoaDV.Text = resourceManager.GetString("Xóa");
            btnChinhSuaDV.Text = resourceManager.GetString("Chỉnh sửa");
            btnLamMoiDSDV.Text = resourceManager.GetString("Làm mới");
            lbThemDV.Text = resourceManager.GetString("Thêm Dịch Vụ");
            lbTenDV.Text = resourceManager.GetString("Tên Dịch Vụ");
            lbGiaDV.Text = resourceManager.GetString("Đơn giá");
            lbNgay.Text = resourceManager.GetString("Ngày");
            lbAnhDV.Text = resourceManager.GetString("Hình ảnh");
            btnDong.Text = resourceManager.GetString("Đóng");
            btn_SaveUpdate.Text = resourceManager.GetString("Lưu");
            btnChinhSuaDV.Text = resourceManager.GetString("Chỉnh sửa");
            btnThemDV.Text = resourceManager.GetString("Thêm");

            //Mess error

            errorName = "Please enter Service Name!";
            errorPriceService = "Please enter the service price as a positive integer!";
            errorSearching = "Service with ID not found:";
            titleChanged = "Service Pack Update";
            errorRowSelected = "Select the service information line to update information!";
            errorRowDelete = "Select the service information line to delete";

            //Mess error
        }

        private void Form_QuanLyDichVu_Load(object sender, EventArgs e)
        {
            pnlThem.Width = 0;
            loadListData();
            tbtSearchDV.GotFocus += new EventHandler(tbt_SearchEmployer_GotFocus);
            tbtSearchDV.LostFocus += new EventHandler(tbt_SearchEmployer_LostFocus);
            tbtSearchDV.Text = "Nhập ID VD: DV001";
            tbtSearchDV.ForeColor = Color.Gray;

            //Test translate

            translateToEnglish();

            //Test translate
        }

        private void tbt_SearchEmployer_GotFocus(object sender, EventArgs e)
        {
            if (tbtSearchDV.Text == "Nhập ID VD: DV001")
            {
                tbtSearchDV.Text = "";
                tbtSearchDV.ForeColor = Color.Black;
            }
        }

        private void tbt_SearchEmployer_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbtSearchDV.Text))
            {
                tbtSearchDV.Text = "Nhập ID VD: DV001";
                tbtSearchDV.ForeColor = Color.Gray;
            }
        }

        public void loadListData()
        {
            List<DichVu> dichVus = controller.displayServiceToDGV();
            dGVListData.AutoGenerateColumns = true;
            dGVListData.DataSource = dichVus;

            dGVListData.Columns["MaDV"].HeaderText = "ID";
            dGVListData.Columns["MaDV"].DataPropertyName = "MaDV";
            dGVListData.Columns["MaDV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["MaDV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["MaDV"].MinimumWidth = 50;
            //dGVListData.Columns["MaDV"].FillWeight = 100;

            dGVListData.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dGVListData.Columns["TenDV"].DataPropertyName = "TenDV";
            dGVListData.Columns["TenDV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["TenDV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["TenDV"].MinimumWidth = 200;

            dGVListData.Columns["Gia"].HeaderText = "Đơn giá";
            dGVListData.Columns["Gia"].DataPropertyName = "Gia";
            dGVListData.Columns["Gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["Gia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["Gia"].MinimumWidth = 100;

            dGVListData.Columns["Ngay"].HeaderText = "Ngày";
            dGVListData.Columns["Ngay"].DataPropertyName = "Ngay";
            dGVListData.Columns["Ngay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["Ngay"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["Ngay"].MinimumWidth = 200;

            dGVListData.Columns["LichTap"].HeaderText = "Lịch tập";
            dGVListData.Columns["LichTap"].DataPropertyName = "LichTap";
            dGVListData.Columns["LichTap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["LichTap"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["LichTap"].MinimumWidth = 200;

            dGVListData.Columns["AnhDV"].HeaderText = "Ảnh dịch vụ";
            dGVListData.Columns["AnhDV"].DataPropertyName = "AnhDV";
            dGVListData.Columns["AnhDV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["AnhDV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["AnhDV"].MinimumWidth = 150;
        }

        // OK
        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (pnlThem.Width >= 390)
            {
                for (int i = 0; i < 10; i++)
                {
                    pnlThem.Width = pnlThem.Width - 39;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    pnlThem.Width = pnlThem.Width + 39;
                }
            }
            timer.Stop();
        }

        // OK
        private void btnFornDV_Click_1(object sender, EventArgs e)
        {
            timer.Start();
            QLDVPnlTop.Enabled = false;
            Button btn_Add = this.Controls.Find("btnThemDV", true).FirstOrDefault() as Button;
            Button btn_Update = this.Controls.Find("btn_SaveUpdate", true).FirstOrDefault() as Button;
            btn_Add.Visible = true;
            btn_Update.Visible = false;
            tbTenDV.Text = "";
            tbDonGiaDV.Text = "";
        }

        // OK
        private void btnDong_Click(object sender, EventArgs e)
        {
            timer.Start();
            QLDVPnlTop.Enabled = true;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            DichVu dichVu = getInfForm();

            if (dichVu.TenDV == "")
            {
                MessageBox.Show(errorName);
                tbTenDV.Focus();
            }
            else if (dichVu.Gia == 0)
            {
                MessageBox.Show(errorPriceService);
                tbDonGiaDV.Focus();
            }
            else
            {
                controller.insertService(dichVu);
            }
        }

        private DichVu getInfForm()
        {
            DichVu dichVu = new DichVu();
            dichVu.TenDV = tbTenDV.Text;
            if (tbDonGiaDV.Text == "")
            {
                dichVu.Gia = 0;
            }
            else
            {
                dichVu.Gia = int.Parse(tbDonGiaDV.Text);
            }
            dichVu.Ngay = dTNgayDV.Value;
            dichVu.LichTap = "";
            Bitmap image = (Bitmap)ptAnhDV.Image;
            byte[] imageBytes = controller.ImageToByteArray(image);
            dichVu.AnhDV = imageBytes;
            return dichVu;
        }

        private void pnlUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Lựa chọn file ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Bitmap image = new Bitmap(filePath);
                ptAnhDV.SizeMode = PictureBoxSizeMode.Zoom;
                ptAnhDV.Image = image;
            }
        }

        private void btnLamMoiDSDV_Click(object sender, EventArgs e)
        {
            loadListData();
        }

        private void ptSearchDV_Click(object sender, EventArgs e)
        {
            string searchValue = tbtSearchDV.Text.Trim();
            if (searchValue != null)
            {
                foreach (DataGridViewRow row in dGVListData.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dGVListData.CurrentCell = row.Cells[0];
                            row.Selected = true;
                            dGVListData.FirstDisplayedScrollingRowIndex = row.Index;
                            return;
                        }
                    }
                }
                MessageBox.Show(errorSearching + searchValue);
            }
        }

        DataGridViewRow selectedRow = null;

        private void dGVListData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (selectedRow != null)
                {
                    selectedRow.DefaultCellStyle.BackColor = Color.White;
                }
                selectedRow = dGVListData.Rows[e.RowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private void btnChinhSuaDV_Click(object sender, EventArgs e)
        {
            timer.Start();
            QLDVPnlTop.Enabled = false;
            Button btn_Add = this.Controls.Find("btnThemDV", true).FirstOrDefault() as Button;
            Button btn_Update = this.Controls.Find("btn_SaveUpdate", true).FirstOrDefault() as Button;

            //Button btn_Exit = this.Controls.Find("btn_ExitPanelAdd", true).FirstOrDefault() as Button;
            btn_Add.Visible = false;
            btn_Update.Visible = true;
            if (selectedRow != null)
            {
                string nameService = selectedRow.Cells[1].Value.ToString();
                string cost = selectedRow.Cells[2].Value.ToString();
                tbTenDV.Text = nameService;
                tbDonGiaDV.Text = cost;

            }
            else
            {
                MessageBox.Show(errorRowSelected);
            }
        }

        private void btn_SaveUpdate_Click(object sender, EventArgs e)
        {
            DichVu dichVu = getInfForm();
            dichVu.MaDV = selectedRow.Cells[0].Value.ToString();
            controller.updateService(dichVu);
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            if (selectedRow != null)
            {
                string maDV = selectedRow.Cells[0].Value.ToString();
                dichVu.MaDV = maDV;
                controller.deleteService(dichVu);
            }
            else
            {
                MessageBox.Show(errorRowDelete);
            }
        }
    }
}
