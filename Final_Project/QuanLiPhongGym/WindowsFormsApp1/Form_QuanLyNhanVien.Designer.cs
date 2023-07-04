namespace WindowsFormsApp1
{
    partial class Form_QuanLyNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_EmployerTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.tbt_SearchEmployer = new System.Windows.Forms.TextBox();
            this.ptSearchDV = new System.Windows.Forms.PictureBox();
            this.btn_AddEmployer = new System.Windows.Forms.Button();
            this.btn_EditEmployer = new System.Windows.Forms.Button();
            this.btn_RefreshListData = new System.Windows.Forms.Button();
            this.pnl_SubFormAdd = new System.Windows.Forms.Panel();
            this.tb_Role = new System.Windows.Forms.TextBox();
            this.tb_Mobile = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.lb_Mobile = new System.Windows.Forms.Label();
            this.lb_Role = new System.Windows.Forms.Label();
            this.lb_Salary = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.pnl_UploadImage = new System.Windows.Forms.Panel();
            this.pnl_NavExitAdd = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_AddEmplorPanel = new System.Windows.Forms.Button();
            this.btn_ExitPanelAdd = new System.Windows.Forms.Button();
            this.pt_ImageOfEmployer = new System.Windows.Forms.PictureBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_TitleImage = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_BirthDay = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.pnl_Tiltle = new System.Windows.Forms.Panel();
            this.lb_TiltlePanelAddEmployer = new System.Windows.Forms.Label();
            this.pnlListData = new System.Windows.Forms.Panel();
            this.dGVListData = new System.Windows.Forms.DataGridView();
            this.pnl_EmployerTop.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchDV)).BeginInit();
            this.pnl_SubFormAdd.SuspendLayout();
            this.pnl_NavExitAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_ImageOfEmployer)).BeginInit();
            this.pnl_Tiltle.SuspendLayout();
            this.pnlListData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListData)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pnl_EmployerTop
            // 
            this.pnl_EmployerTop.ColumnCount = 5;
            this.pnl_EmployerTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.pnl_EmployerTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.pnl_EmployerTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.pnl_EmployerTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.pnl_EmployerTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 576F));
            this.pnl_EmployerTop.Controls.Add(this.pnl_Search, 4, 0);
            this.pnl_EmployerTop.Controls.Add(this.btn_AddEmployer, 0, 0);
            this.pnl_EmployerTop.Controls.Add(this.btn_EditEmployer, 1, 0);
            this.pnl_EmployerTop.Controls.Add(this.btn_RefreshListData, 2, 0);
            this.pnl_EmployerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_EmployerTop.Location = new System.Drawing.Point(0, 0);
            this.pnl_EmployerTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_EmployerTop.Name = "pnl_EmployerTop";
            this.pnl_EmployerTop.Padding = new System.Windows.Forms.Padding(2);
            this.pnl_EmployerTop.RowCount = 1;
            this.pnl_EmployerTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_EmployerTop.Size = new System.Drawing.Size(1000, 50);
            this.pnl_EmployerTop.TabIndex = 3;
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_Search.Controls.Add(this.tbt_SearchEmployer);
            this.pnl_Search.Controls.Add(this.ptSearchDV);
            this.pnl_Search.Location = new System.Drawing.Point(522, 2);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(469, 44);
            this.pnl_Search.TabIndex = 4;
            // 
            // tbt_SearchEmployer
            // 
            this.tbt_SearchEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbt_SearchEmployer.BackColor = System.Drawing.Color.White;
            this.tbt_SearchEmployer.Location = new System.Drawing.Point(49, 6);
            this.tbt_SearchEmployer.Multiline = true;
            this.tbt_SearchEmployer.Name = "tbt_SearchEmployer";
            this.tbt_SearchEmployer.Size = new System.Drawing.Size(335, 30);
            this.tbt_SearchEmployer.TabIndex = 1;
            // 
            // ptSearchDV
            // 
            this.ptSearchDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ptSearchDV.BackColor = System.Drawing.Color.White;
            this.ptSearchDV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptSearchDV.BackgroundImage")));
            this.ptSearchDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptSearchDV.Location = new System.Drawing.Point(390, 6);
            this.ptSearchDV.Name = "ptSearchDV";
            this.ptSearchDV.Size = new System.Drawing.Size(55, 30);
            this.ptSearchDV.TabIndex = 0;
            this.ptSearchDV.TabStop = false;
            this.ptSearchDV.Click += new System.EventHandler(this.ptSearchDV_Click);
            // 
            // btn_AddEmployer
            // 
            this.btn_AddEmployer.BackColor = System.Drawing.Color.Firebrick;
            this.btn_AddEmployer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddEmployer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddEmployer.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmployer.Location = new System.Drawing.Point(3, 3);
            this.btn_AddEmployer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_AddEmployer.Name = "btn_AddEmployer";
            this.btn_AddEmployer.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_AddEmployer.Size = new System.Drawing.Size(103, 44);
            this.btn_AddEmployer.TabIndex = 0;
            this.btn_AddEmployer.Text = "Thêm";
            this.btn_AddEmployer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddEmployer.UseVisualStyleBackColor = false;
            this.btn_AddEmployer.Click += new System.EventHandler(this.btn_AddEmployer_Click_1);
            // 
            // btn_EditEmployer
            // 
            this.btn_EditEmployer.BackColor = System.Drawing.Color.Firebrick;
            this.btn_EditEmployer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EditEmployer.ForeColor = System.Drawing.Color.White;
            this.btn_EditEmployer.Location = new System.Drawing.Point(108, 3);
            this.btn_EditEmployer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_EditEmployer.Name = "btn_EditEmployer";
            this.btn_EditEmployer.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_EditEmployer.Size = new System.Drawing.Size(103, 44);
            this.btn_EditEmployer.TabIndex = 2;
            this.btn_EditEmployer.Text = "Chỉnh sửa";
            this.btn_EditEmployer.UseVisualStyleBackColor = false;
            this.btn_EditEmployer.Click += new System.EventHandler(this.btn_EditEmployer_Click);
            // 
            // btn_RefreshListData
            // 
            this.btn_RefreshListData.BackColor = System.Drawing.Color.Firebrick;
            this.btn_RefreshListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RefreshListData.ForeColor = System.Drawing.Color.White;
            this.btn_RefreshListData.Location = new System.Drawing.Point(213, 3);
            this.btn_RefreshListData.Margin = new System.Windows.Forms.Padding(1);
            this.btn_RefreshListData.Name = "btn_RefreshListData";
            this.btn_RefreshListData.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_RefreshListData.Size = new System.Drawing.Size(103, 44);
            this.btn_RefreshListData.TabIndex = 3;
            this.btn_RefreshListData.Text = "Làm mới";
            this.btn_RefreshListData.UseVisualStyleBackColor = false;
            this.btn_RefreshListData.Click += new System.EventHandler(this.btn_RefreshListData_Click);
            // 
            // pnl_SubFormAdd
            // 
            this.pnl_SubFormAdd.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_SubFormAdd.Controls.Add(this.tb_Role);
            this.pnl_SubFormAdd.Controls.Add(this.tb_Mobile);
            this.pnl_SubFormAdd.Controls.Add(this.tb_Salary);
            this.pnl_SubFormAdd.Controls.Add(this.rb_Male);
            this.pnl_SubFormAdd.Controls.Add(this.rb_Female);
            this.pnl_SubFormAdd.Controls.Add(this.lb_Mobile);
            this.pnl_SubFormAdd.Controls.Add(this.lb_Role);
            this.pnl_SubFormAdd.Controls.Add(this.lb_Salary);
            this.pnl_SubFormAdd.Controls.Add(this.lb_Gender);
            this.pnl_SubFormAdd.Controls.Add(this.pnl_UploadImage);
            this.pnl_SubFormAdd.Controls.Add(this.pnl_NavExitAdd);
            this.pnl_SubFormAdd.Controls.Add(this.pt_ImageOfEmployer);
            this.pnl_SubFormAdd.Controls.Add(this.tb_Address);
            this.pnl_SubFormAdd.Controls.Add(this.dt_Date);
            this.pnl_SubFormAdd.Controls.Add(this.tb_Email);
            this.pnl_SubFormAdd.Controls.Add(this.tb_Name);
            this.pnl_SubFormAdd.Controls.Add(this.lb_TitleImage);
            this.pnl_SubFormAdd.Controls.Add(this.lb_Address);
            this.pnl_SubFormAdd.Controls.Add(this.lb_BirthDay);
            this.pnl_SubFormAdd.Controls.Add(this.lb_Email);
            this.pnl_SubFormAdd.Controls.Add(this.lb_Name);
            this.pnl_SubFormAdd.Controls.Add(this.pnl_Tiltle);
            this.pnl_SubFormAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_SubFormAdd.Location = new System.Drawing.Point(610, 50);
            this.pnl_SubFormAdd.Name = "pnl_SubFormAdd";
            this.pnl_SubFormAdd.Size = new System.Drawing.Size(390, 550);
            this.pnl_SubFormAdd.TabIndex = 4;
            // 
            // tb_Role
            // 
            this.tb_Role.Location = new System.Drawing.Point(21, 447);
            this.tb_Role.Multiline = true;
            this.tb_Role.Name = "tb_Role";
            this.tb_Role.Size = new System.Drawing.Size(182, 30);
            this.tb_Role.TabIndex = 21;
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Location = new System.Drawing.Point(22, 391);
            this.tb_Mobile.Multiline = true;
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(182, 30);
            this.tb_Mobile.TabIndex = 20;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Location = new System.Drawing.Point(21, 329);
            this.tb_Salary.Multiline = true;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(182, 30);
            this.tb_Salary.TabIndex = 19;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.ForeColor = System.Drawing.Color.White;
            this.rb_Male.Location = new System.Drawing.Point(102, 271);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(50, 17);
            this.rb_Male.TabIndex = 18;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.ForeColor = System.Drawing.Color.White;
            this.rb_Female.Location = new System.Drawing.Point(162, 271);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(41, 17);
            this.rb_Female.TabIndex = 17;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // lb_Mobile
            // 
            this.lb_Mobile.AutoSize = true;
            this.lb_Mobile.ForeColor = System.Drawing.Color.White;
            this.lb_Mobile.Location = new System.Drawing.Point(18, 372);
            this.lb_Mobile.Name = "lb_Mobile";
            this.lb_Mobile.Size = new System.Drawing.Size(83, 13);
            this.lb_Mobile.TabIndex = 16;
            this.lb_Mobile.Text = "Số điện thoại";
            // 
            // lb_Role
            // 
            this.lb_Role.AutoSize = true;
            this.lb_Role.ForeColor = System.Drawing.Color.White;
            this.lb_Role.Location = new System.Drawing.Point(21, 429);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(54, 13);
            this.lb_Role.TabIndex = 15;
            this.lb_Role.Text = "Chức vụ";
            // 
            // lb_Salary
            // 
            this.lb_Salary.AutoSize = true;
            this.lb_Salary.ForeColor = System.Drawing.Color.White;
            this.lb_Salary.Location = new System.Drawing.Point(18, 304);
            this.lb_Salary.Name = "lb_Salary";
            this.lb_Salary.Size = new System.Drawing.Size(66, 13);
            this.lb_Salary.TabIndex = 14;
            this.lb_Salary.Text = "Mức lương";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.ForeColor = System.Drawing.Color.White;
            this.lb_Gender.Location = new System.Drawing.Point(18, 271);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(56, 13);
            this.lb_Gender.TabIndex = 13;
            this.lb_Gender.Text = "Giới tính";
            // 
            // pnl_UploadImage
            // 
            this.pnl_UploadImage.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_UploadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_UploadImage.BackgroundImage")));
            this.pnl_UploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_UploadImage.Location = new System.Drawing.Point(267, 449);
            this.pnl_UploadImage.Name = "pnl_UploadImage";
            this.pnl_UploadImage.Size = new System.Drawing.Size(55, 27);
            this.pnl_UploadImage.TabIndex = 12;
            this.pnl_UploadImage.Click += new System.EventHandler(this.pnl_UploadImage_Click);
            // 
            // pnl_NavExitAdd
            // 
            this.pnl_NavExitAdd.Controls.Add(this.btn_Update);
            this.pnl_NavExitAdd.Controls.Add(this.btn_AddEmplorPanel);
            this.pnl_NavExitAdd.Controls.Add(this.btn_ExitPanelAdd);
            this.pnl_NavExitAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_NavExitAdd.Location = new System.Drawing.Point(0, 479);
            this.pnl_NavExitAdd.Name = "pnl_NavExitAdd";
            this.pnl_NavExitAdd.Size = new System.Drawing.Size(390, 71);
            this.pnl_NavExitAdd.TabIndex = 11;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(205, 27);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_Update.Size = new System.Drawing.Size(168, 30);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Lưu";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_AddEmplorPanel
            // 
            this.btn_AddEmplorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddEmplorPanel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_AddEmplorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddEmplorPanel.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmplorPanel.Location = new System.Drawing.Point(205, 27);
            this.btn_AddEmplorPanel.Margin = new System.Windows.Forms.Padding(1);
            this.btn_AddEmplorPanel.Name = "btn_AddEmplorPanel";
            this.btn_AddEmplorPanel.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_AddEmplorPanel.Size = new System.Drawing.Size(168, 30);
            this.btn_AddEmplorPanel.TabIndex = 2;
            this.btn_AddEmplorPanel.Text = "Thêm";
            this.btn_AddEmplorPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddEmplorPanel.UseVisualStyleBackColor = false;
            this.btn_AddEmplorPanel.Click += new System.EventHandler(this.btn_AddEmplorPanel_Click);
            // 
            // btn_ExitPanelAdd
            // 
            this.btn_ExitPanelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExitPanelAdd.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ExitPanelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExitPanelAdd.ForeColor = System.Drawing.Color.White;
            this.btn_ExitPanelAdd.Location = new System.Drawing.Point(21, 27);
            this.btn_ExitPanelAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ExitPanelAdd.Name = "btn_ExitPanelAdd";
            this.btn_ExitPanelAdd.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_ExitPanelAdd.Size = new System.Drawing.Size(182, 30);
            this.btn_ExitPanelAdd.TabIndex = 1;
            this.btn_ExitPanelAdd.Text = "Đóng";
            this.btn_ExitPanelAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ExitPanelAdd.UseVisualStyleBackColor = false;
            this.btn_ExitPanelAdd.Click += new System.EventHandler(this.btn_ExitPanelAdd_Click);
            // 
            // pt_ImageOfEmployer
            // 
            this.pt_ImageOfEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pt_ImageOfEmployer.Image = ((System.Drawing.Image)(resources.GetObject("pt_ImageOfEmployer.Image")));
            this.pt_ImageOfEmployer.Location = new System.Drawing.Point(213, 294);
            this.pt_ImageOfEmployer.Name = "pt_ImageOfEmployer";
            this.pt_ImageOfEmployer.Size = new System.Drawing.Size(150, 150);
            this.pt_ImageOfEmployer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_ImageOfEmployer.TabIndex = 10;
            this.pt_ImageOfEmployer.TabStop = false;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(102, 198);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(261, 30);
            this.tb_Address.TabIndex = 9;
            // 
            // dt_Date
            // 
            this.dt_Date.Location = new System.Drawing.Point(102, 153);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(261, 20);
            this.dt_Date.TabIndex = 8;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(102, 110);
            this.tb_Email.Multiline = true;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(261, 30);
            this.tb_Email.TabIndex = 7;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(102, 64);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(261, 30);
            this.tb_Name.TabIndex = 6;
            // 
            // lb_TitleImage
            // 
            this.lb_TitleImage.AutoSize = true;
            this.lb_TitleImage.ForeColor = System.Drawing.Color.White;
            this.lb_TitleImage.Location = new System.Drawing.Point(263, 273);
            this.lb_TitleImage.Name = "lb_TitleImage";
            this.lb_TitleImage.Size = new System.Drawing.Size(58, 13);
            this.lb_TitleImage.TabIndex = 5;
            this.lb_TitleImage.Text = "Hình ảnh";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.ForeColor = System.Drawing.Color.White;
            this.lb_Address.Location = new System.Drawing.Point(18, 206);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(47, 13);
            this.lb_Address.TabIndex = 4;
            this.lb_Address.Text = "Địa chỉ";
            // 
            // lb_BirthDay
            // 
            this.lb_BirthDay.AutoSize = true;
            this.lb_BirthDay.ForeColor = System.Drawing.Color.White;
            this.lb_BirthDay.Location = new System.Drawing.Point(18, 157);
            this.lb_BirthDay.Name = "lb_BirthDay";
            this.lb_BirthDay.Size = new System.Drawing.Size(63, 13);
            this.lb_BirthDay.TabIndex = 3;
            this.lb_BirthDay.Text = "Ngày sinh";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.ForeColor = System.Drawing.Color.White;
            this.lb_Email.Location = new System.Drawing.Point(18, 119);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(37, 13);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "Email";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.ForeColor = System.Drawing.Color.White;
            this.lb_Name.Location = new System.Drawing.Point(18, 73);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(67, 13);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Họ và Tên";
            // 
            // pnl_Tiltle
            // 
            this.pnl_Tiltle.Controls.Add(this.lb_TiltlePanelAddEmployer);
            this.pnl_Tiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tiltle.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tiltle.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Tiltle.Name = "pnl_Tiltle";
            this.pnl_Tiltle.Size = new System.Drawing.Size(390, 39);
            this.pnl_Tiltle.TabIndex = 0;
            // 
            // lb_TiltlePanelAddEmployer
            // 
            this.lb_TiltlePanelAddEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TiltlePanelAddEmployer.ForeColor = System.Drawing.Color.White;
            this.lb_TiltlePanelAddEmployer.Location = new System.Drawing.Point(144, 7);
            this.lb_TiltlePanelAddEmployer.Name = "lb_TiltlePanelAddEmployer";
            this.lb_TiltlePanelAddEmployer.Size = new System.Drawing.Size(144, 39);
            this.lb_TiltlePanelAddEmployer.TabIndex = 3;
            this.lb_TiltlePanelAddEmployer.Text = "Thêm Nhân Viên\r\n";
            this.lb_TiltlePanelAddEmployer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlListData
            // 
            this.pnlListData.Controls.Add(this.dGVListData);
            this.pnlListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListData.Location = new System.Drawing.Point(0, 50);
            this.pnlListData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlListData.Name = "pnlListData";
            this.pnlListData.Padding = new System.Windows.Forms.Padding(3);
            this.pnlListData.Size = new System.Drawing.Size(610, 550);
            this.pnlListData.TabIndex = 5;
            // 
            // dGVListData
            // 
            this.dGVListData.AllowUserToAddRows = false;
            this.dGVListData.AllowUserToDeleteRows = false;
            this.dGVListData.BackgroundColor = System.Drawing.Color.White;
            this.dGVListData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dGVListData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVListData.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVListData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVListData.EnableHeadersVisualStyles = false;
            this.dGVListData.GridColor = System.Drawing.Color.White;
            this.dGVListData.Location = new System.Drawing.Point(3, 3);
            this.dGVListData.Margin = new System.Windows.Forms.Padding(0);
            this.dGVListData.Name = "dGVListData";
            this.dGVListData.ReadOnly = true;
            this.dGVListData.Size = new System.Drawing.Size(604, 544);
            this.dGVListData.TabIndex = 0;
            this.dGVListData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListData_CellClick);
            // 
            // Form_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlListData);
            this.Controls.Add(this.pnl_SubFormAdd);
            this.Controls.Add(this.pnl_EmployerTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_QuanLyNhanVien";
            this.Text = "Form_QuanLyNhanVien";
            this.Load += new System.EventHandler(this.Form_QuanLyNhanVien_Load);
            this.pnl_EmployerTop.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchDV)).EndInit();
            this.pnl_SubFormAdd.ResumeLayout(false);
            this.pnl_SubFormAdd.PerformLayout();
            this.pnl_NavExitAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt_ImageOfEmployer)).EndInit();
            this.pnl_Tiltle.ResumeLayout(false);
            this.pnlListData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TableLayoutPanel pnl_EmployerTop;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.TextBox tbt_SearchEmployer;
        private System.Windows.Forms.PictureBox ptSearchDV;
        private System.Windows.Forms.Button btn_AddEmployer;
        private System.Windows.Forms.Button btn_EditEmployer;
        private System.Windows.Forms.Button btn_RefreshListData;
        private System.Windows.Forms.Panel pnl_SubFormAdd;
        private System.Windows.Forms.TextBox tb_Role;
        private System.Windows.Forms.TextBox tb_Mobile;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Label lb_Mobile;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.Label lb_Salary;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Panel pnl_UploadImage;
        private System.Windows.Forms.Panel pnl_NavExitAdd;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_AddEmplorPanel;
        private System.Windows.Forms.Button btn_ExitPanelAdd;
        private System.Windows.Forms.PictureBox pt_ImageOfEmployer;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_TitleImage;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_BirthDay;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Panel pnl_Tiltle;
        private System.Windows.Forms.Label lb_TiltlePanelAddEmployer;
        private System.Windows.Forms.Panel pnlListData;
        private System.Windows.Forms.DataGridView dGVListData;
    }
}