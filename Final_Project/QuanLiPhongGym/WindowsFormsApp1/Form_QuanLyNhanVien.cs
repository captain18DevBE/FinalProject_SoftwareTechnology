using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form_QuanLyNhanVien : Form
    {
        public Form_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private Controller controller = new Controller();

        private string errorName = "Bạn chưa nhập trường thông tin: Họ và Tên";
        private string errorEmail = "Bạn chưa nhập đúng thông tin: Email";
        private string errorAddress = "Bạn chưa nhập thông tin địa chỉ thường trú";
        private string errorGender = "Vui lòng chọn giới tính";
        private string errorSalary = "Vui lòng nhập mực lương là một số nguyên dương!";
        private string errorPhoneNumber = "Vui lòng chính xác số điện thoại liên hệ";
        private string errorPosition = "Vui lòng nhập chức vụ của nhân sự!";
        private string errorSearching = "Không tìm thấy nhân viên có ID: ";
        private string titleUpdatePanel = "Cập Nhật Thông Tin";
        private string errorRowSelected = "Chọn dòng thông tin nhân viên cần cập nhật thông tin!";

        private void translateToEnglish()
        {
            //string tranlateFilePath = "Resources.en.resx";
            ResourceManager resourceManager = new ResourceManager("WindowsFormsApp1.Resources", typeof(Resources).Assembly);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            btn_AddEmployer.Text = resourceManager.GetString("Thêm");
            btn_EditEmployer.Text = resourceManager.GetString("Chỉnh sửa");
            btn_RefreshListData.Text = resourceManager.GetString("Làm mới");
            lb_TiltlePanelAddEmployer.Text = resourceManager.GetString("Thêm Nhân Viên");
            lb_Name.Text = resourceManager.GetString("Họ và Tên");
            lb_BirthDay.Text = resourceManager.GetString("Ngày sinh");
            lb_Address.Text = resourceManager.GetString("Địa chỉ");
            lb_Gender.Text = resourceManager.GetString("Giới tính");
            rb_Male.Text = resourceManager.GetString("Nam");
            rb_Female.Text = resourceManager.GetString("Nữ");
            lb_Salary.Text = resourceManager.GetString("Mức lương");
            lb_Mobile.Text = resourceManager.GetString("Số điện thoại");
            lb_Role.Text = resourceManager.GetString("Chức vụ");
            lb_TitleImage.Text = resourceManager.GetString("Hình ảnh");
            btn_ExitPanelAdd.Text = resourceManager.GetString("Đóng");
            btn_Update.Text = resourceManager.GetString("Lưu");
            btn_AddEmplorPanel.Text = resourceManager.GetString("Thêm");

            // Mess Error
            errorName = "You have not entered the information field: Full name";
            errorEmail = "You have not entered the correct information: Email";
            errorAddress = "You have not entered your permanent address information";
            errorGender = "Please select your gender";
            errorSalary = "Please enter salary as a positive integer!";
            errorPhoneNumber = "Please correct contact phone number";
            errorPosition = "Please enter the position of the personnel";
            errorSearching = "Employee with ID not found:";
            titleUpdatePanel = "Update information";
            errorRowSelected = "Select the employee information line to update information!";
        }

        private void Form_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            pnl_SubFormAdd.Width = 0;
            tbt_SearchEmployer.GotFocus += new EventHandler(tbt_SearchEmployer_GotFocus);
            tbt_SearchEmployer.LostFocus += new EventHandler(tbt_SearchEmployer_LostFocus);
            tbt_SearchEmployer.Text = "Nhập ID VD: NV001";
            tbt_SearchEmployer.ForeColor = Color.Gray;
            loadListData();
            //Test translate to english

            translateToEnglish();

            //Test translate to english
        }

        private void loadListData()
        {
            List<NhanVien> nhanViens;
            nhanViens = controller.displayEmployerToDGV();
            dGVListData.AutoGenerateColumns = true;
            dGVListData.DataSource = nhanViens;
            dGVListData.Columns["MaNV"].HeaderText = "ID";
            dGVListData.Columns["MaNV"].DataPropertyName = "MaNV";
            dGVListData.Columns["MaNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["MaNV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["TenNV"].HeaderText = "Họ và Tên";
            dGVListData.Columns["TenNV"].DataPropertyName = "TenNV";
            dGVListData.Columns["TenNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["TenNV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["Email"].HeaderText = "Email";
            dGVListData.Columns["Email"].DataPropertyName = "Email";
            dGVListData.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dGVListData.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dGVListData.Columns["DiaChi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["DiaChi"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dGVListData.Columns["NgaySinh"].DataPropertyName = "NgaySinh";
            dGVListData.Columns["NgaySinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["NgaySinh"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["GioiTinh"].HeaderText = "Giới tính";
            dGVListData.Columns["GioiTinh"].DataPropertyName = "GioiTinh";
            dGVListData.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["GioiTinh"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["Luong"].HeaderText = "Lương";
            dGVListData.Columns["Luong"].DataPropertyName = "Luong";
            dGVListData.Columns["Luong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["Luong"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["SDT"].HeaderText = "Số điện thoại";
            dGVListData.Columns["SDT"].DataPropertyName = "SDT";
            dGVListData.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["SDT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["ChucVu"].HeaderText = "Chức vụ";
            dGVListData.Columns["ChucVu"].DataPropertyName = "ChucVu";
            dGVListData.Columns["ChucVu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["ChucVu"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVListData.Columns["AnhNV"].HeaderText = "Ảnh";
            dGVListData.Columns["AnhNV"].DataPropertyName = "AnhNV";
            dGVListData.Columns["AnhNV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dGVListData.Columns["AnhNV"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pnl_SubFormAdd.Width >= 390)
            {
                for (int i = 0; i < 10; i++)
                {
                    pnl_SubFormAdd.Width = pnl_SubFormAdd.Width - 39;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    pnl_SubFormAdd.Width = pnl_SubFormAdd.Width + 39;
                }
            }
            Timer.Stop();
        }


        private void btn_AddEmployer_Click_1(object sender, EventArgs e)
        {
            Timer.Start();
            pnl_EmployerTop.Enabled = false;
            Button btn_Add = this.Controls.Find("btn_AddEmplorPanel", true).FirstOrDefault() as Button;
            Button btn_Update = this.Controls.Find("btn_Update", true).FirstOrDefault() as Button;
            btn_Add.Visible = true;
            btn_Update.Visible = false;

            tbt_SearchEmployer.GotFocus += new EventHandler(tbt_SearchEmployer_GotFocus);
            tbt_SearchEmployer.LostFocus += new EventHandler(tbt_SearchEmployer_LostFocus);
            tbt_SearchEmployer.Text = "Nhập ID VD: NV001";
            tbt_SearchEmployer.ForeColor = Color.Gray;

            tb_Name.GotFocus += new EventHandler(tb_Name_GotFocus);
            tb_Name.LostFocus += new EventHandler(tb_Name_LostFocus);
            tb_Name.Text = "VD: Võ Hoàng A";
            tb_Name.ForeColor = Color.Gray;

            tb_Email.GotFocus += new EventHandler(tb_Email_GotFocus);
            tb_Email.LostFocus += new EventHandler(tb_Email_LostFocus);
            tb_Email.Text = "VD: abc@gmail.com";
            tb_Email.ForeColor = Color.Gray;

            tb_Address.GotFocus += new EventHandler(tb_Address_GotFocus);
            tb_Address.LostFocus += new EventHandler(tb_Address_LostFocus);
            tb_Address.Text = "VD: Quận 7 - Tp.Hồ Chí Minh";
            tb_Address.ForeColor = Color.Gray;

            tb_Salary.GotFocus += new EventHandler(tb_Salary_GotFocus);
            tb_Salary.LostFocus += new EventHandler(tb_Salary_LostFocus);
            tb_Salary.Text = "VD: 1000$";
            tb_Salary.ForeColor = Color.Gray;

            tb_Mobile.GotFocus += new EventHandler(tb_Mobile_GotFocus);
            tb_Mobile.LostFocus += new EventHandler(tb_Mobile_LostFocus);
            tb_Mobile.Text = "VD: 03xxxxxxxx";
            tb_Mobile.ForeColor = Color.Gray;

            tb_Role.GotFocus += new EventHandler(tb_Role_GotFocus);
            tb_Role.LostFocus += new EventHandler(tb_Role_LostFocus);
            tb_Role.Text = "VD: Nhân viên";
            tb_Role.ForeColor = Color.Gray;
        }

        private void tbt_SearchEmployer_GotFocus(object sender, EventArgs e)
        {
            if (tbt_SearchEmployer.Text == "Nhập ID VD: NV001")
            {
                tbt_SearchEmployer.Text = "";
                tbt_SearchEmployer.ForeColor = Color.Black;
            }
        }

        private void tbt_SearchEmployer_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbt_SearchEmployer.Text))
            {
                tbt_SearchEmployer.Text = "Nhập ID VD: NV001";
                tbt_SearchEmployer.ForeColor = Color.Gray;
            }
        }

        private void tb_Name_GotFocus(object sender, EventArgs e)
        {
            if (tb_Name.Text == "VD: Võ Hoàng A")
            {
                tb_Name.Text = "";
                tb_Name.ForeColor = Color.Black;
            }
        }

        private void tb_Name_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Name.Text))
            {
                tb_Name.Text = "VD: Võ Hoàng A";
                tb_Name.ForeColor = Color.Gray;
            }
        }

        private void tb_Email_GotFocus(object sender, EventArgs e)
        {
            if (tb_Email.Text == "VD: abc@gmail.com")
            {
                tb_Email.Text = "";
                tb_Email.ForeColor = Color.Black;
            }
        }

        private void tb_Email_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Email.Text))
            {
                tb_Email.Text = "VD: abc@gmail.com";
                tb_Email.ForeColor = Color.Gray;
            }
        }

        private void tb_Address_GotFocus(object sender, EventArgs e)
        {
            if (tb_Address.Text == "VD: Quận 7 - Tp.Hồ Chí Minh")
            {
                tb_Address.Text = "";
                tb_Address.ForeColor = Color.Black;
            }
        }

        private void tb_Address_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Address.Text))
            {
                tb_Address.Text = "VD: Quận 7 - Tp.Hồ Chí Minh";
                tb_Address.ForeColor = Color.Gray;
            }
        }

        private void tb_Salary_GotFocus(object sender, EventArgs e)
        {
            if (tb_Salary.Text == "VD: 1000$")
            {
                tb_Salary.Text = "";
                tb_Salary.ForeColor = Color.Black;
            }
        }

        private void tb_Salary_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Salary.Text))
            {
                tb_Salary.Text = "VD: 1000$";
                tb_Salary.ForeColor = Color.Gray;
            }
        }

        private void tb_Mobile_GotFocus(object sender, EventArgs e)
        {
            if (tb_Mobile.Text == "VD: 03xxxxxxxx")
            {
                tb_Mobile.Text = "";
                tb_Mobile.ForeColor = Color.Black;
            }
        }

        private void tb_Mobile_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Mobile.Text))
            {
                tb_Mobile.Text = "VD: 03xxxxxxxx";
                tb_Mobile.ForeColor = Color.Gray;
            }
        }

        private void tb_Role_GotFocus(object sender, EventArgs e)
        {
            if (tb_Role.Text == "VD: Nhân viên")
            {
                tb_Role.Text = "";
                tb_Role.ForeColor = Color.Black;
            }
        }

        private void tb_Role_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Role.Text))
            {
                tb_Role.Text = "VD: Nhân viên";
                tb_Role.ForeColor = Color.Gray;
            }
        }

        private void btn_ExitPanelAdd_Click(object sender, EventArgs e)
        {
            Timer.Start();
            pnl_EmployerTop.Enabled = true;
        }

        private void btn_AddEmplorPanel_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = getInfEmployer();
            bool phoneNumberIsTrue = regexPhoneNumber(nhanVien.SDT);
            bool emailAddressIsTrue = regexEmailAddress(nhanVien.Email);
            if (nhanVien.TenNV == "" || nhanVien.TenNV == "VD: Võ Hoàng A")
            {
                MessageBox.Show(errorName);
                tb_Name.Focus();
            }
            else if (nhanVien.Email == "" || nhanVien.Email == "VD: abc@gmail.com" || !emailAddressIsTrue)
            {
                MessageBox.Show(errorEmail);
                tb_Email.Focus();
            }
            else if (nhanVien.DiaChi == "" || nhanVien.DiaChi == "VD: Quận 7 - Tp.Hồ Chí Minh")
            {
                MessageBox.Show(errorAddress);
                tb_Address.Focus();
            }
            else if (nhanVien.GioiTinh == "")
            {
                MessageBox.Show(errorGender);
                rb_Male.Focus();
            }
            else if (nhanVien.Luong == "" || nhanVien.Luong == "VD: 1000" || !int.TryParse(tb_Salary.Text, out int salary))
            {
                MessageBox.Show(errorSalary);
                tb_Salary.Focus();
            }
            else if (nhanVien.SDT == "" || nhanVien.SDT == "VD: 03xxxxxxxx" || !phoneNumberIsTrue)
            {
                MessageBox.Show(errorPhoneNumber);
                tb_Mobile.Focus();
            }
            else if (nhanVien.ChucVu == "" || nhanVien.ChucVu == "VD: Nhân viên")
            {
                MessageBox.Show(errorPosition);
                tb_Role.Focus();
            }
            else
            {
                controller.insertEmployer(nhanVien);
            }
        }

        private bool regexPhoneNumber(string phoneNumber)
        {
            string phoneRegex = @"^\d{10}$";
            return Regex.IsMatch(phoneNumber, phoneRegex);
        }

        private bool regexEmailAddress(string emailAddress)
        {
            string emailRegex = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            return Regex.IsMatch(emailAddress, emailRegex);
        }


        // Merge code

        private NhanVien getInfEmployer()
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.TenNV = tb_Name.Text;
            nhanVien.Email = tb_Email.Text;
            nhanVien.NgaySinh = dt_Date.Value;
            nhanVien.DiaChi = tb_Address.Text;
            if (rb_Male.Checked)
            {
                nhanVien.GioiTinh = "Nam";
            }
            else if (rb_Female.Checked)
            {
                nhanVien.GioiTinh = "Nữ";
            }
            nhanVien.Luong = tb_Salary.Text;
            nhanVien.SDT = tb_Mobile.Text;
            nhanVien.ChucVu = tb_Role.Text;
            Bitmap image = (Bitmap)pt_ImageOfEmployer.Image;
            byte[] imageBytes = nhanVien.ImageToByteArray(image);
            nhanVien.AnhNV = imageBytes;
            return nhanVien;
        }

        private void pnl_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Lựa chọn file ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Bitmap image = new Bitmap(filePath);
                pt_ImageOfEmployer.SizeMode = PictureBoxSizeMode.Zoom;
                pt_ImageOfEmployer.Image = image;
            }
        }

        private void btn_RefreshListData_Click(object sender, EventArgs e)
        {
            loadListData();
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

        private void ptSearchDV_Click(object sender, EventArgs e)
        {
            string searchValue = tbt_SearchEmployer.Text.Trim();
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

        private void btn_EditEmployer_Click(object sender, EventArgs e)
        {
            Timer.Start();
            pnl_EmployerTop.Enabled = false;
            lb_TiltlePanelAddEmployer.Text = titleUpdatePanel;
            Button btn_Add = this.Controls.Find("btn_AddEmplorPanel", true).FirstOrDefault() as Button;
            Button btn_Update = this.Controls.Find("btn_Update", true).FirstOrDefault() as Button;

            //Button btn_Exit = this.Controls.Find("btn_ExitPanelAdd", true).FirstOrDefault() as Button;
            btn_Add.Visible = false;
            btn_Update.Visible = true;
            if (selectedRow != null)
            {
                string nameEmployer = selectedRow.Cells[1].Value.ToString();
                //string Email, Địa chỉ,  Ngày sinh, Giới tính, lương, số điện thoại, chức vụ
                string email = selectedRow.Cells[2].Value.ToString();
                string address = selectedRow.Cells[3].Value.ToString();
                string birthDay = selectedRow.Cells[4].Value.ToString();
                string gender = selectedRow.Cells[5].Value.ToString();
                string salary = selectedRow.Cells[6].Value.ToString();
                string phoneNumber = selectedRow.Cells[7].Value.ToString();
                string role = selectedRow.Cells[8].Value.ToString();

                tb_Name.Text = nameEmployer;
                tb_Email.Text = email;
                tb_Address.Text = address;
                tb_Salary.Text = salary;
                tb_Mobile.Text = phoneNumber;
                tb_Role.Text = role;

                if (gender == "Nam")
                {
                    rb_Male.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    rb_Female.Checked = true;
                }
            }
            else
            {
                MessageBox.Show(errorRowSelected);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = getInfEmployer();
            string MaNV = selectedRow.Cells[0].Value.ToString();
            nhanVien.MaNV = MaNV;
            controller.updateEmployer(nhanVien);
        }
    }
}
