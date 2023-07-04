namespace WindowsFormsApp1
{
    partial class Form_HoaDon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_filtercustomername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_filterstaffname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_filterservicename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_filtercustomerid = new System.Windows.Forms.TextBox();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.txt_filterstaffid = new System.Windows.Forms.TextBox();
            this.lbl_staffid = new System.Windows.Forms.Label();
            this.txt_filterroomid = new System.Windows.Forms.TextBox();
            this.lbl_roomid = new System.Windows.Forms.Label();
            this.txt_filterserviceid = new System.Windows.Forms.TextBox();
            this.lbl_serviceid = new System.Windows.Forms.Label();
            this.dtp_today = new System.Windows.Forms.DateTimePicker();
            this.lbl_today = new System.Windows.Forms.Label();
            this.dtp_fromday = new System.Windows.Forms.DateTimePicker();
            this.lbl_fromday = new System.Windows.Forms.Label();
            this.txt_filterbillid = new System.Windows.Forms.TextBox();
            this.lbl_billid = new System.Windows.Forms.Label();
            this.grv_bill = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYPHONGGYMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYPHONGGYMDataSet = new WindowsFormsApp1.QUANLYPHONGGYMDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.hOADONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new WindowsFormsApp1.QUANLYPHONGGYMDataSetTableAdapters.HOADONTableAdapter();
            this.qUANLYPHONGGYMDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.b_filter = new WindowsFormsApp1.RJButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txt_filtercustomername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_filterstaffname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_filterservicename);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_filtercustomerid);
            this.panel2.Controls.Add(this.lbl_customer);
            this.panel2.Controls.Add(this.txt_filterstaffid);
            this.panel2.Controls.Add(this.lbl_staffid);
            this.panel2.Controls.Add(this.txt_filterroomid);
            this.panel2.Controls.Add(this.lbl_roomid);
            this.panel2.Controls.Add(this.txt_filterserviceid);
            this.panel2.Controls.Add(this.lbl_serviceid);
            this.panel2.Controls.Add(this.b_filter);
            this.panel2.Controls.Add(this.dtp_today);
            this.panel2.Controls.Add(this.lbl_today);
            this.panel2.Controls.Add(this.dtp_fromday);
            this.panel2.Controls.Add(this.lbl_fromday);
            this.panel2.Controls.Add(this.txt_filterbillid);
            this.panel2.Controls.Add(this.lbl_billid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 692);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.grv_bill);
            this.panel1.Location = new System.Drawing.Point(43, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 406);
            this.panel1.TabIndex = 137;
            // 
            // txt_filtercustomername
            // 
            this.txt_filtercustomername.Location = new System.Drawing.Point(213, 117);
            this.txt_filtercustomername.Name = "txt_filtercustomername";
            this.txt_filtercustomername.Size = new System.Drawing.Size(135, 20);
            this.txt_filtercustomername.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(220, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 135;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // txt_filterstaffname
            // 
            this.txt_filterstaffname.Location = new System.Drawing.Point(553, 117);
            this.txt_filterstaffname.Name = "txt_filterstaffname";
            this.txt_filterstaffname.Size = new System.Drawing.Size(135, 20);
            this.txt_filterstaffname.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(566, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 133;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // txt_filterservicename
            // 
            this.txt_filterservicename.Location = new System.Drawing.Point(383, 117);
            this.txt_filterservicename.Name = "txt_filterservicename";
            this.txt_filterservicename.Size = new System.Drawing.Size(135, 20);
            this.txt_filterservicename.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(402, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 129;
            this.label4.Text = "Tên Dịch Vụ";
            // 
            // txt_filtercustomerid
            // 
            this.txt_filtercustomerid.Location = new System.Drawing.Point(213, 56);
            this.txt_filtercustomerid.Name = "txt_filtercustomerid";
            this.txt_filtercustomerid.Size = new System.Drawing.Size(135, 20);
            this.txt_filtercustomerid.TabIndex = 126;
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.ForeColor = System.Drawing.Color.Black;
            this.lbl_customer.Location = new System.Drawing.Point(224, 37);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(115, 16);
            this.lbl_customer.TabIndex = 125;
            this.lbl_customer.Text = "Mã Khách Hàng";
            // 
            // txt_filterstaffid
            // 
            this.txt_filterstaffid.Location = new System.Drawing.Point(553, 56);
            this.txt_filterstaffid.Name = "txt_filterstaffid";
            this.txt_filterstaffid.Size = new System.Drawing.Size(135, 20);
            this.txt_filterstaffid.TabIndex = 124;
            // 
            // lbl_staffid
            // 
            this.lbl_staffid.AutoSize = true;
            this.lbl_staffid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staffid.ForeColor = System.Drawing.Color.Black;
            this.lbl_staffid.Location = new System.Drawing.Point(568, 37);
            this.lbl_staffid.Name = "lbl_staffid";
            this.lbl_staffid.Size = new System.Drawing.Size(103, 16);
            this.lbl_staffid.TabIndex = 123;
            this.lbl_staffid.Text = "Mã Nhân Viên";
            // 
            // txt_filterroomid
            // 
            this.txt_filterroomid.Location = new System.Drawing.Point(43, 117);
            this.txt_filterroomid.Name = "txt_filterroomid";
            this.txt_filterroomid.Size = new System.Drawing.Size(135, 20);
            this.txt_filterroomid.TabIndex = 122;
            // 
            // lbl_roomid
            // 
            this.lbl_roomid.AutoSize = true;
            this.lbl_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomid.ForeColor = System.Drawing.Color.Black;
            this.lbl_roomid.Location = new System.Drawing.Point(72, 98);
            this.lbl_roomid.Name = "lbl_roomid";
            this.lbl_roomid.Size = new System.Drawing.Size(76, 16);
            this.lbl_roomid.TabIndex = 121;
            this.lbl_roomid.Text = "Mã Phòng";
            // 
            // txt_filterserviceid
            // 
            this.txt_filterserviceid.Location = new System.Drawing.Point(383, 56);
            this.txt_filterserviceid.Name = "txt_filterserviceid";
            this.txt_filterserviceid.Size = new System.Drawing.Size(135, 20);
            this.txt_filterserviceid.TabIndex = 120;
            // 
            // lbl_serviceid
            // 
            this.lbl_serviceid.AutoSize = true;
            this.lbl_serviceid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serviceid.ForeColor = System.Drawing.Color.Black;
            this.lbl_serviceid.Location = new System.Drawing.Point(407, 37);
            this.lbl_serviceid.Name = "lbl_serviceid";
            this.lbl_serviceid.Size = new System.Drawing.Size(85, 16);
            this.lbl_serviceid.TabIndex = 119;
            this.lbl_serviceid.Text = "Mã Dịch Vụ";
            // 
            // dtp_today
            // 
            this.dtp_today.Location = new System.Drawing.Point(722, 117);
            this.dtp_today.Name = "dtp_today";
            this.dtp_today.Size = new System.Drawing.Size(201, 20);
            this.dtp_today.TabIndex = 39;
            // 
            // lbl_today
            // 
            this.lbl_today.AutoSize = true;
            this.lbl_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_today.ForeColor = System.Drawing.Color.Black;
            this.lbl_today.Location = new System.Drawing.Point(783, 98);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(75, 16);
            this.lbl_today.TabIndex = 38;
            this.lbl_today.Text = "Đến Ngày";
            // 
            // dtp_fromday
            // 
            this.dtp_fromday.Location = new System.Drawing.Point(722, 56);
            this.dtp_fromday.Name = "dtp_fromday";
            this.dtp_fromday.Size = new System.Drawing.Size(201, 20);
            this.dtp_fromday.TabIndex = 37;
            // 
            // lbl_fromday
            // 
            this.lbl_fromday.AutoSize = true;
            this.lbl_fromday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fromday.ForeColor = System.Drawing.Color.Black;
            this.lbl_fromday.Location = new System.Drawing.Point(785, 37);
            this.lbl_fromday.Name = "lbl_fromday";
            this.lbl_fromday.Size = new System.Drawing.Size(66, 16);
            this.lbl_fromday.TabIndex = 36;
            this.lbl_fromday.Text = "Từ Ngày";
            // 
            // txt_filterbillid
            // 
            this.txt_filterbillid.Location = new System.Drawing.Point(43, 56);
            this.txt_filterbillid.Name = "txt_filterbillid";
            this.txt_filterbillid.Size = new System.Drawing.Size(135, 20);
            this.txt_filterbillid.TabIndex = 29;
            // 
            // lbl_billid
            // 
            this.lbl_billid.AutoSize = true;
            this.lbl_billid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billid.ForeColor = System.Drawing.Color.Black;
            this.lbl_billid.Location = new System.Drawing.Point(64, 36);
            this.lbl_billid.Name = "lbl_billid";
            this.lbl_billid.Size = new System.Drawing.Size(92, 16);
            this.lbl_billid.TabIndex = 28;
            this.lbl_billid.Text = "Mã Hóa Đơn";
            // 
            // grv_bill
            // 
            this.grv_bill.AllowUserToResizeColumns = false;
            this.grv_bill.AllowUserToResizeRows = false;
            this.grv_bill.AutoGenerateColumns = false;
            this.grv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.MaPhong,
            this.MaDV,
            this.TongTien,
            this.Ngay,
            this.SoLuong});
            this.grv_bill.DataSource = this.hOADONBindingSource;
            this.grv_bill.Location = new System.Drawing.Point(15, 15);
            this.grv_bill.Name = "grv_bill";
            this.grv_bill.Size = new System.Drawing.Size(850, 375);
            this.grv_bill.TabIndex = 27;
            this.grv_bill.Tag = "grv_bill";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "MaHD";
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "MaKH";
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.Name = "MaNV";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.Name = "MaPhong";
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "MaDV";
            this.MaDV.Name = "MaDV";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "TongTien";
            this.TongTien.Name = "TongTien";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngay";
            this.Ngay.Name = "Ngay";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qUANLYPHONGGYMDataSetBindingSource;
            // 
            // qUANLYPHONGGYMDataSetBindingSource
            // 
            this.qUANLYPHONGGYMDataSetBindingSource.DataSource = this.qUANLYPHONGGYMDataSet;
            this.qUANLYPHONGGYMDataSetBindingSource.Position = 0;
            // 
            // qUANLYPHONGGYMDataSet
            // 
            this.qUANLYPHONGGYMDataSet.DataSetName = "QUANLYPHONGGYMDataSet";
            this.qUANLYPHONGGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(414, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // hOADONBindingSource1
            // 
            this.hOADONBindingSource1.DataMember = "HOADON";
            this.hOADONBindingSource1.DataSource = this.qUANLYPHONGGYMDataSetBindingSource;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // qUANLYPHONGGYMDataSetBindingSource1
            // 
            this.qUANLYPHONGGYMDataSetBindingSource1.DataSource = this.qUANLYPHONGGYMDataSet;
            this.qUANLYPHONGGYMDataSetBindingSource1.Position = 0;
            // 
            // b_filter
            // 
            this.b_filter.BackColor = System.Drawing.Color.Firebrick;
            this.b_filter.BackgroundColor = System.Drawing.Color.Firebrick;
            this.b_filter.BorderColor = System.Drawing.Color.White;
            this.b_filter.BorderRadius = 2;
            this.b_filter.BorderSize = 1;
            this.b_filter.FlatAppearance.BorderSize = 0;
            this.b_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_filter.ForeColor = System.Drawing.Color.White;
            this.b_filter.Location = new System.Drawing.Point(444, 159);
            this.b_filter.Margin = new System.Windows.Forms.Padding(2);
            this.b_filter.Name = "b_filter";
            this.b_filter.Size = new System.Drawing.Size(89, 34);
            this.b_filter.TabIndex = 118;
            this.b_filter.Text = "Lọc";
            this.b_filter.TextColor = System.Drawing.Color.White;
            this.b_filter.UseVisualStyleBackColor = false;
            this.b_filter.Click += new System.EventHandler(this.b_filter_Click);
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 693);
            this.Controls.Add(this.panel2);
            this.Name = "Form_HoaDon";
            this.Text = "Form_HoaDon";
            this.Load += new System.EventHandler(this.Form_HoaDon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private QUANLYPHONGGYMDataSet qUANLYPHONGGYMDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_filterbillid;
        private System.Windows.Forms.Label lbl_billid;
        private System.Windows.Forms.Label lbl_fromday;
        private System.Windows.Forms.DateTimePicker dtp_today;
        private System.Windows.Forms.Label lbl_today;
        private System.Windows.Forms.DateTimePicker dtp_fromday;
        private RJButton b_filter;
        private System.Windows.Forms.BindingSource qUANLYPHONGGYMDataSetBindingSource;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QUANLYPHONGGYMDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.BindingSource hOADONBindingSource1;
        private System.Windows.Forms.BindingSource qUANLYPHONGGYMDataSetBindingSource1;
        public System.Windows.Forms.DataGridView grv_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.TextBox txt_filterserviceid;
        private System.Windows.Forms.Label lbl_serviceid;
        private System.Windows.Forms.TextBox txt_filterstaffid;
        private System.Windows.Forms.Label lbl_staffid;
        private System.Windows.Forms.TextBox txt_filterroomid;
        private System.Windows.Forms.Label lbl_roomid;
        private System.Windows.Forms.TextBox txt_filtercustomerid;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filterstaffname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_filterservicename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_filtercustomername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

