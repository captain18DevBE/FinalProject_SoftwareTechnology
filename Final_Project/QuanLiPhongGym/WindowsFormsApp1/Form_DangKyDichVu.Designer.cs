namespace WindowsFormsApp1
{
    partial class Form_DangKyDichVu
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton1 = new WindowsFormsApp1.RJButton();
            this.btn_oke = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.grv_dadkdv = new System.Windows.Forms.DataGridView();
            this.grv_dkdv = new System.Windows.Forms.DataGridView();
            this.maDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichTapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICHVUBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYPHONGGYMDataSet = new WindowsFormsApp1.QUANLYPHONGGYMDataSet();
            this.cbb_phong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_report = new System.Windows.Forms.Label();
            this.dICHVUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUTableAdapter = new WindowsFormsApp1.QUANLYPHONGGYMDataSetTableAdapters.DICHVUTableAdapter();
            this.dICHVUDADANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b_comeback = new WindowsFormsApp1.RJButton();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dadkdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dkdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUDADANGKYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(464, -98);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, -98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 143;
            this.label3.Text = "Ngày";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, -39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-41, -39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 141;
            this.label2.Text = "Tên dịch vụ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, -96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-41, -96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 139;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, -39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 145;
            this.label4.Text = "Phòng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.btn_oke);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_info);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.grv_dadkdv);
            this.panel1.Controls.Add(this.grv_dkdv);
            this.panel1.Controls.Add(this.cbb_phong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_report);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 853);
            this.panel1.TabIndex = 147;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Black;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Black;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 2;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(15, 14);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(119, 28);
            this.rjButton1.TabIndex = 139;
            this.rjButton1.Text = "Về trang chủ";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btn_oke
            // 
            this.btn_oke.BackColor = System.Drawing.Color.Black;
            this.btn_oke.ForeColor = System.Drawing.Color.White;
            this.btn_oke.Location = new System.Drawing.Point(956, 790);
            this.btn_oke.Margin = new System.Windows.Forms.Padding(4);
            this.btn_oke.Name = "btn_oke";
            this.btn_oke.Size = new System.Drawing.Size(259, 48);
            this.btn_oke.TabIndex = 138;
            this.btn_oke.Text = "Xác nhận";
            this.btn_oke.UseVisualStyleBackColor = false;
            this.btn_oke.Click += new System.EventHandler(this.btn_oke_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(949, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 31);
            this.label6.TabIndex = 137;
            this.label6.Text = "Đã Đăng Ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(405, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 136;
            this.label5.Text = "Dịch Vụ";
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.Black;
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Location = new System.Drawing.Point(560, 729);
            this.btn_info.Margin = new System.Windows.Forms.Padding(4);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(135, 48);
            this.btn_info.TabIndex = 135;
            this.btn_info.Text = "Xem thêm";
            this.btn_info.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1080, 729);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(135, 48);
            this.btn_delete.TabIndex = 134;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(703, 729);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(135, 48);
            this.btn_add.TabIndex = 133;
            this.btn_add.Text = "Đăng ký";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // grv_dadkdv
            // 
            this.grv_dadkdv.AllowUserToAddRows = false;
            this.grv_dadkdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_dadkdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.Gia,
            this.Phong});
            this.grv_dadkdv.Location = new System.Drawing.Point(859, 219);
            this.grv_dadkdv.Margin = new System.Windows.Forms.Padding(4);
            this.grv_dadkdv.Name = "grv_dadkdv";
            this.grv_dadkdv.RowHeadersWidth = 51;
            this.grv_dadkdv.Size = new System.Drawing.Size(356, 502);
            this.grv_dadkdv.TabIndex = 132;
            // 
            // grv_dkdv
            // 
            this.grv_dkdv.AutoGenerateColumns = false;
            this.grv_dkdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_dkdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDVDataGridViewTextBoxColumn,
            this.tenDVDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.phongDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.lichTapDataGridViewTextBoxColumn});
            this.grv_dkdv.DataSource = this.dICHVUBindingSource3;
            this.grv_dkdv.Location = new System.Drawing.Point(71, 219);
            this.grv_dkdv.Margin = new System.Windows.Forms.Padding(4);
            this.grv_dkdv.Name = "grv_dkdv";
            this.grv_dkdv.RowHeadersWidth = 51;
            this.grv_dkdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_dkdv.Size = new System.Drawing.Size(767, 502);
            this.grv_dkdv.TabIndex = 131;
            // 
            // maDVDataGridViewTextBoxColumn
            // 
            this.maDVDataGridViewTextBoxColumn.DataPropertyName = "MaDV";
            this.maDVDataGridViewTextBoxColumn.HeaderText = "MaDV";
            this.maDVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDVDataGridViewTextBoxColumn.Name = "maDVDataGridViewTextBoxColumn";
            this.maDVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDVDataGridViewTextBoxColumn
            // 
            this.tenDVDataGridViewTextBoxColumn.DataPropertyName = "TenDV";
            this.tenDVDataGridViewTextBoxColumn.HeaderText = "TenDV";
            this.tenDVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDVDataGridViewTextBoxColumn.Name = "tenDVDataGridViewTextBoxColumn";
            this.tenDVDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongDataGridViewTextBoxColumn
            // 
            this.phongDataGridViewTextBoxColumn.DataPropertyName = "Phong";
            this.phongDataGridViewTextBoxColumn.HeaderText = "Phong";
            this.phongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongDataGridViewTextBoxColumn.Name = "phongDataGridViewTextBoxColumn";
            this.phongDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngay";
            this.ngayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            this.ngayDataGridViewTextBoxColumn.Width = 125;
            // 
            // lichTapDataGridViewTextBoxColumn
            // 
            this.lichTapDataGridViewTextBoxColumn.DataPropertyName = "LichTap";
            this.lichTapDataGridViewTextBoxColumn.HeaderText = "LichTap";
            this.lichTapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lichTapDataGridViewTextBoxColumn.Name = "lichTapDataGridViewTextBoxColumn";
            this.lichTapDataGridViewTextBoxColumn.Width = 125;
            // 
            // dICHVUBindingSource3
            // 
            this.dICHVUBindingSource3.DataMember = "DICHVU";
            this.dICHVUBindingSource3.DataSource = this.qUANLYPHONGGYMDataSet;
            // 
            // qUANLYPHONGGYMDataSet
            // 
            this.qUANLYPHONGGYMDataSet.DataSetName = "QUANLYPHONGGYMDataSet";
            this.qUANLYPHONGGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbb_phong
            // 
            this.cbb_phong.FormattingEnabled = true;
            this.cbb_phong.Items.AddRange(new object[] {
            "Cộng Hòa",
            "Phan Xích Long"});
            this.cbb_phong.Location = new System.Drawing.Point(148, 122);
            this.cbb_phong.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_phong.Name = "cbb_phong";
            this.cbb_phong.Size = new System.Drawing.Size(265, 24);
            this.cbb_phong.TabIndex = 129;
            this.cbb_phong.SelectedIndexChanged += new System.EventHandler(this.cbb_phong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 128;
            this.label7.Text = "Phòng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_report
            // 
            this.lb_report.AutoSize = true;
            this.lb_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_report.ForeColor = System.Drawing.Color.Black;
            this.lb_report.Location = new System.Drawing.Point(479, 11);
            this.lb_report.Name = "lb_report";
            this.lb_report.Size = new System.Drawing.Size(294, 39);
            this.lb_report.TabIndex = 121;
            this.lb_report.Text = "Đăng Ký Dịch Vụ";
            // 
            // dICHVUBindingSource2
            // 
            this.dICHVUBindingSource2.DataMember = "DICHVU";
            this.dICHVUBindingSource2.DataSource = this.qUANLYPHONGGYMDataSet;
            // 
            // dICHVUBindingSource1
            // 
            this.dICHVUBindingSource1.DataMember = "DICHVU";
            this.dICHVUBindingSource1.DataSource = this.qUANLYPHONGGYMDataSet;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.qUANLYPHONGGYMDataSet;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // dICHVUDADANGKYBindingSource
            // 
            this.dICHVUDADANGKYBindingSource.DataMember = "DICHVUDADANGKY";
            this.dICHVUDADANGKYBindingSource.DataSource = this.qUANLYPHONGGYMDataSet;
            // 
            // b_comeback
            // 
            this.b_comeback.BackColor = System.Drawing.Color.Black;
            this.b_comeback.BackgroundColor = System.Drawing.Color.Black;
            this.b_comeback.BorderColor = System.Drawing.Color.White;
            this.b_comeback.BorderRadius = 2;
            this.b_comeback.BorderSize = 1;
            this.b_comeback.FlatAppearance.BorderSize = 0;
            this.b_comeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_comeback.ForeColor = System.Drawing.Color.White;
            this.b_comeback.Location = new System.Drawing.Point(15, 14);
            this.b_comeback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_comeback.Name = "b_comeback";
            this.b_comeback.Size = new System.Drawing.Size(119, 28);
            this.b_comeback.TabIndex = 146;
            this.b_comeback.Text = "Về trang chủ";
            this.b_comeback.TextColor = System.Drawing.Color.White;
            this.b_comeback.UseVisualStyleBackColor = false;
            // 
            // MaDV
            // 
            this.MaDV.HeaderText = "MaDV";
            this.MaDV.MinimumWidth = 6;
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 125;
            // 
            // TenDV
            // 
            this.TenDV.HeaderText = "TenDV";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.Width = 125;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Gia";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // Phong
            // 
            this.Phong.HeaderText = "Phong";
            this.Phong.MinimumWidth = 6;
            this.Phong.Name = "Phong";
            this.Phong.Width = 125;
            // 
            // Form_DangKyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_comeback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DangKyDichVu";
            this.Text = "Form_DangKyDichVu";
            this.Load += new System.EventHandler(this.Form_DangKyDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dadkdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dkdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private RJButton rjButton1;
        private System.Windows.Forms.Button btn_oke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView grv_dadkdv;
        private System.Windows.Forms.DataGridView grv_dkdv;
        private System.Windows.Forms.ComboBox cbb_phong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_report;
        private RJButton b_comeback;
        private QUANLYPHONGGYMDataSet qUANLYPHONGGYMDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private QUANLYPHONGGYMDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.BindingSource dICHVUBindingSource1;
        private System.Windows.Forms.BindingSource dICHVUDADANGKYBindingSource;
        private System.Windows.Forms.BindingSource dICHVUBindingSource2;
        private System.Windows.Forms.BindingSource dICHVUBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lichTapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
    }
}