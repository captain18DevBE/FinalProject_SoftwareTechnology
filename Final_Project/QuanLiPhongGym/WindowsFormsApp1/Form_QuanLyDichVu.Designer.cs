namespace WindowsFormsApp1
{
    partial class Form_QuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.QLDVPnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnLamMoiDSDV = new System.Windows.Forms.Button();
            this.btnChinhSuaDV = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tbtSearchDV = new System.Windows.Forms.TextBox();
            this.ptSearchDV = new System.Windows.Forms.PictureBox();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnFornDV = new System.Windows.Forms.Button();
            this.pnlThem = new System.Windows.Forms.Panel();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.pnl_NavExitAdd = new System.Windows.Forms.Panel();
            this.btn_SaveUpdate = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.ptAnhDV = new System.Windows.Forms.PictureBox();
            this.dTNgayDV = new System.Windows.Forms.DateTimePicker();
            this.tbDonGiaDV = new System.Windows.Forms.TextBox();
            this.tbTenDV = new System.Windows.Forms.TextBox();
            this.lbAnhDV = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbGiaDV = new System.Windows.Forms.Label();
            this.lbTenDV = new System.Windows.Forms.Label();
            this.pnl_Tiltle = new System.Windows.Forms.Panel();
            this.lbThemDV = new System.Windows.Forms.Label();
            this.pnlListData = new System.Windows.Forms.Panel();
            this.dGVListData = new System.Windows.Forms.DataGridView();
            this.QLDVPnlTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchDV)).BeginInit();
            this.pnlThem.SuspendLayout();
            this.pnl_NavExitAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnhDV)).BeginInit();
            this.pnl_Tiltle.SuspendLayout();
            this.pnlListData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListData)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // QLDVPnlTop
            // 
            this.QLDVPnlTop.ColumnCount = 5;
            this.QLDVPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.QLDVPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.QLDVPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.QLDVPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.QLDVPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 576F));
            this.QLDVPnlTop.Controls.Add(this.btnLamMoiDSDV, 3, 0);
            this.QLDVPnlTop.Controls.Add(this.btnChinhSuaDV, 2, 0);
            this.QLDVPnlTop.Controls.Add(this.pnlSearch, 4, 0);
            this.QLDVPnlTop.Controls.Add(this.btnXoaDV, 1, 0);
            this.QLDVPnlTop.Controls.Add(this.btnFornDV, 0, 0);
            this.QLDVPnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.QLDVPnlTop.Location = new System.Drawing.Point(0, 0);
            this.QLDVPnlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QLDVPnlTop.Name = "QLDVPnlTop";
            this.QLDVPnlTop.Padding = new System.Windows.Forms.Padding(2);
            this.QLDVPnlTop.RowCount = 1;
            this.QLDVPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.QLDVPnlTop.Size = new System.Drawing.Size(1000, 50);
            this.QLDVPnlTop.TabIndex = 2;
            // 
            // btnLamMoiDSDV
            // 
            this.btnLamMoiDSDV.BackColor = System.Drawing.Color.Firebrick;
            this.btnLamMoiDSDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoiDSDV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiDSDV.Location = new System.Drawing.Point(318, 3);
            this.btnLamMoiDSDV.Margin = new System.Windows.Forms.Padding(1);
            this.btnLamMoiDSDV.Name = "btnLamMoiDSDV";
            this.btnLamMoiDSDV.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnLamMoiDSDV.Size = new System.Drawing.Size(103, 44);
            this.btnLamMoiDSDV.TabIndex = 3;
            this.btnLamMoiDSDV.Text = "Làm mới";
            this.btnLamMoiDSDV.UseVisualStyleBackColor = false;
            this.btnLamMoiDSDV.Click += new System.EventHandler(this.btnLamMoiDSDV_Click);
            // 
            // btnChinhSuaDV
            // 
            this.btnChinhSuaDV.BackColor = System.Drawing.Color.Firebrick;
            this.btnChinhSuaDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChinhSuaDV.ForeColor = System.Drawing.Color.White;
            this.btnChinhSuaDV.Location = new System.Drawing.Point(213, 3);
            this.btnChinhSuaDV.Margin = new System.Windows.Forms.Padding(1);
            this.btnChinhSuaDV.Name = "btnChinhSuaDV";
            this.btnChinhSuaDV.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnChinhSuaDV.Size = new System.Drawing.Size(103, 44);
            this.btnChinhSuaDV.TabIndex = 2;
            this.btnChinhSuaDV.Text = "Chỉnh sửa";
            this.btnChinhSuaDV.UseVisualStyleBackColor = false;
            this.btnChinhSuaDV.Click += new System.EventHandler(this.btnChinhSuaDV_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Firebrick;
            this.pnlSearch.Controls.Add(this.tbtSearchDV);
            this.pnlSearch.Controls.Add(this.ptSearchDV);
            this.pnlSearch.Location = new System.Drawing.Point(522, 2);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(469, 44);
            this.pnlSearch.TabIndex = 4;
            // 
            // tbtSearchDV
            // 
            this.tbtSearchDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtSearchDV.BackColor = System.Drawing.Color.White;
            this.tbtSearchDV.Location = new System.Drawing.Point(49, 6);
            this.tbtSearchDV.Multiline = true;
            this.tbtSearchDV.Name = "tbtSearchDV";
            this.tbtSearchDV.Size = new System.Drawing.Size(335, 30);
            this.tbtSearchDV.TabIndex = 1;
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
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoaDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Location = new System.Drawing.Point(108, 3);
            this.btnXoaDV.Margin = new System.Windows.Forms.Padding(1);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnXoaDV.Size = new System.Drawing.Size(103, 44);
            this.btnXoaDV.TabIndex = 1;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnFornDV
            // 
            this.btnFornDV.BackColor = System.Drawing.Color.Firebrick;
            this.btnFornDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFornDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFornDV.ForeColor = System.Drawing.Color.White;
            this.btnFornDV.Location = new System.Drawing.Point(3, 3);
            this.btnFornDV.Margin = new System.Windows.Forms.Padding(1);
            this.btnFornDV.Name = "btnFornDV";
            this.btnFornDV.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnFornDV.Size = new System.Drawing.Size(103, 44);
            this.btnFornDV.TabIndex = 0;
            this.btnFornDV.Text = "Thêm";
            this.btnFornDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFornDV.UseVisualStyleBackColor = false;
            this.btnFornDV.Click += new System.EventHandler(this.btnFornDV_Click_1);
            // 
            // pnlThem
            // 
            this.pnlThem.BackColor = System.Drawing.Color.Firebrick;
            this.pnlThem.Controls.Add(this.pnlUpload);
            this.pnlThem.Controls.Add(this.pnl_NavExitAdd);
            this.pnlThem.Controls.Add(this.ptAnhDV);
            this.pnlThem.Controls.Add(this.dTNgayDV);
            this.pnlThem.Controls.Add(this.tbDonGiaDV);
            this.pnlThem.Controls.Add(this.tbTenDV);
            this.pnlThem.Controls.Add(this.lbAnhDV);
            this.pnlThem.Controls.Add(this.lbNgay);
            this.pnlThem.Controls.Add(this.lbGiaDV);
            this.pnlThem.Controls.Add(this.lbTenDV);
            this.pnlThem.Controls.Add(this.pnl_Tiltle);
            this.pnlThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThem.Location = new System.Drawing.Point(610, 50);
            this.pnlThem.Name = "pnlThem";
            this.pnlThem.Size = new System.Drawing.Size(390, 550);
            this.pnlThem.TabIndex = 3;
            // 
            // pnlUpload
            // 
            this.pnlUpload.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUpload.BackgroundImage")));
            this.pnlUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUpload.Location = new System.Drawing.Point(177, 440);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(55, 27);
            this.pnlUpload.TabIndex = 12;
            this.pnlUpload.Click += new System.EventHandler(this.pnlUpload_Click);
            // 
            // pnl_NavExitAdd
            // 
            this.pnl_NavExitAdd.Controls.Add(this.btn_SaveUpdate);
            this.pnl_NavExitAdd.Controls.Add(this.btnThemDV);
            this.pnl_NavExitAdd.Controls.Add(this.btnDong);
            this.pnl_NavExitAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_NavExitAdd.Location = new System.Drawing.Point(0, 479);
            this.pnl_NavExitAdd.Name = "pnl_NavExitAdd";
            this.pnl_NavExitAdd.Size = new System.Drawing.Size(390, 71);
            this.pnl_NavExitAdd.TabIndex = 11;
            // 
            // btn_SaveUpdate
            // 
            this.btn_SaveUpdate.BackColor = System.Drawing.Color.Firebrick;
            this.btn_SaveUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SaveUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_SaveUpdate.Location = new System.Drawing.Point(205, 27);
            this.btn_SaveUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.btn_SaveUpdate.Name = "btn_SaveUpdate";
            this.btn_SaveUpdate.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_SaveUpdate.Size = new System.Drawing.Size(168, 30);
            this.btn_SaveUpdate.TabIndex = 3;
            this.btn_SaveUpdate.Text = "Lưu";
            this.btn_SaveUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SaveUpdate.UseVisualStyleBackColor = false;
            this.btn_SaveUpdate.Click += new System.EventHandler(this.btn_SaveUpdate_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.Firebrick;
            this.btnThemDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(205, 27);
            this.btnThemDV.Margin = new System.Windows.Forms.Padding(1);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnThemDV.Size = new System.Drawing.Size(168, 30);
            this.btnThemDV.TabIndex = 2;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Firebrick;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(21, 27);
            this.btnDong.Margin = new System.Windows.Forms.Padding(1);
            this.btnDong.Name = "btnDong";
            this.btnDong.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnDong.Size = new System.Drawing.Size(182, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // ptAnhDV
            // 
            this.ptAnhDV.Image = ((System.Drawing.Image)(resources.GetObject("ptAnhDV.Image")));
            this.ptAnhDV.Location = new System.Drawing.Point(23, 223);
            this.ptAnhDV.Name = "ptAnhDV";
            this.ptAnhDV.Size = new System.Drawing.Size(352, 209);
            this.ptAnhDV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptAnhDV.TabIndex = 10;
            this.ptAnhDV.TabStop = false;
            // 
            // dTNgayDV
            // 
            this.dTNgayDV.Location = new System.Drawing.Point(102, 153);
            this.dTNgayDV.Name = "dTNgayDV";
            this.dTNgayDV.Size = new System.Drawing.Size(261, 20);
            this.dTNgayDV.TabIndex = 8;
            // 
            // tbDonGiaDV
            // 
            this.tbDonGiaDV.Location = new System.Drawing.Point(102, 110);
            this.tbDonGiaDV.Multiline = true;
            this.tbDonGiaDV.Name = "tbDonGiaDV";
            this.tbDonGiaDV.Size = new System.Drawing.Size(261, 30);
            this.tbDonGiaDV.TabIndex = 7;
            // 
            // tbTenDV
            // 
            this.tbTenDV.Location = new System.Drawing.Point(102, 64);
            this.tbTenDV.Multiline = true;
            this.tbTenDV.Name = "tbTenDV";
            this.tbTenDV.Size = new System.Drawing.Size(261, 30);
            this.tbTenDV.TabIndex = 6;
            // 
            // lbAnhDV
            // 
            this.lbAnhDV.AutoSize = true;
            this.lbAnhDV.ForeColor = System.Drawing.Color.White;
            this.lbAnhDV.Location = new System.Drawing.Point(174, 197);
            this.lbAnhDV.Name = "lbAnhDV";
            this.lbAnhDV.Size = new System.Drawing.Size(58, 13);
            this.lbAnhDV.TabIndex = 5;
            this.lbAnhDV.Text = "Hình ảnh";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(18, 157);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(36, 13);
            this.lbNgay.TabIndex = 3;
            this.lbNgay.Text = "Ngày";
            // 
            // lbGiaDV
            // 
            this.lbGiaDV.AutoSize = true;
            this.lbGiaDV.ForeColor = System.Drawing.Color.White;
            this.lbGiaDV.Location = new System.Drawing.Point(18, 119);
            this.lbGiaDV.Name = "lbGiaDV";
            this.lbGiaDV.Size = new System.Drawing.Size(51, 13);
            this.lbGiaDV.TabIndex = 2;
            this.lbGiaDV.Text = "Đơn giá";
            // 
            // lbTenDV
            // 
            this.lbTenDV.AutoSize = true;
            this.lbTenDV.ForeColor = System.Drawing.Color.White;
            this.lbTenDV.Location = new System.Drawing.Point(18, 73);
            this.lbTenDV.Name = "lbTenDV";
            this.lbTenDV.Size = new System.Drawing.Size(78, 13);
            this.lbTenDV.TabIndex = 1;
            this.lbTenDV.Text = "Tên Dịch Vụ";
            // 
            // pnl_Tiltle
            // 
            this.pnl_Tiltle.Controls.Add(this.lbThemDV);
            this.pnl_Tiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tiltle.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tiltle.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Tiltle.Name = "pnl_Tiltle";
            this.pnl_Tiltle.Size = new System.Drawing.Size(390, 39);
            this.pnl_Tiltle.TabIndex = 0;
            // 
            // lbThemDV
            // 
            this.lbThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemDV.ForeColor = System.Drawing.Color.White;
            this.lbThemDV.Location = new System.Drawing.Point(144, 3);
            this.lbThemDV.Name = "lbThemDV";
            this.lbThemDV.Size = new System.Drawing.Size(144, 39);
            this.lbThemDV.TabIndex = 3;
            this.lbThemDV.Text = "Thêm Dịch Vụ";
            this.lbThemDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlListData.TabIndex = 4;
            // 
            // dGVListData
            // 
            this.dGVListData.AllowUserToAddRows = false;
            this.dGVListData.AllowUserToDeleteRows = false;
            this.dGVListData.BackgroundColor = System.Drawing.Color.White;
            this.dGVListData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dGVListData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVListData.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVListData.DefaultCellStyle = dataGridViewCellStyle4;
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
            // Form_QuanLyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlListData);
            this.Controls.Add(this.pnlThem);
            this.Controls.Add(this.QLDVPnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_QuanLyDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QuanLyDichVu";
            this.Load += new System.EventHandler(this.Form_QuanLyDichVu_Load);
            this.QLDVPnlTop.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSearchDV)).EndInit();
            this.pnlThem.ResumeLayout(false);
            this.pnlThem.PerformLayout();
            this.pnl_NavExitAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptAnhDV)).EndInit();
            this.pnl_Tiltle.ResumeLayout(false);
            this.pnlListData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel QLDVPnlTop;
        private System.Windows.Forms.Button btnLamMoiDSDV;
        private System.Windows.Forms.Button btnChinhSuaDV;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox tbtSearchDV;
        private System.Windows.Forms.PictureBox ptSearchDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnFornDV;
        private System.Windows.Forms.Panel pnlThem;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Panel pnl_NavExitAdd;
        private System.Windows.Forms.Button btn_SaveUpdate;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.PictureBox ptAnhDV;
        private System.Windows.Forms.DateTimePicker dTNgayDV;
        private System.Windows.Forms.TextBox tbDonGiaDV;
        private System.Windows.Forms.TextBox tbTenDV;
        private System.Windows.Forms.Label lbAnhDV;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbGiaDV;
        private System.Windows.Forms.Label lbTenDV;
        private System.Windows.Forms.Panel pnl_Tiltle;
        private System.Windows.Forms.Label lbThemDV;
        private System.Windows.Forms.Panel pnlListData;
        private System.Windows.Forms.DataGridView dGVListData;
    }
}