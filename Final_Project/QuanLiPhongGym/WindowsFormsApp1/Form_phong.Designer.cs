namespace WindowsFormsApp1
{
    partial class Form_phong
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
            this.b_tim = new WindowsFormsApp1.RJButton();
            this.b_comeback = new WindowsFormsApp1.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.cb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_songuoi = new System.Windows.Forms.TextBox();
            this.lb_report = new System.Windows.Forms.Label();
            this.grv_phong = new System.Windows.Forms.DataGridView();
            this.b_them = new WindowsFormsApp1.RJButton();
            this.b_sua = new WindowsFormsApp1.RJButton();
            this.b_capnhat = new WindowsFormsApp1.RJButton();
            this.b_xoa = new WindowsFormsApp1.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.grv_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // b_tim
            // 
            this.b_tim.BackColor = System.Drawing.Color.Black;
            this.b_tim.BackgroundColor = System.Drawing.Color.Black;
            this.b_tim.BorderColor = System.Drawing.Color.White;
            this.b_tim.BorderRadius = 2;
            this.b_tim.BorderSize = 1;
            this.b_tim.FlatAppearance.BorderSize = 0;
            this.b_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_tim.ForeColor = System.Drawing.Color.White;
            this.b_tim.Location = new System.Drawing.Point(1109, 127);
            this.b_tim.Name = "b_tim";
            this.b_tim.Size = new System.Drawing.Size(110, 25);
            this.b_tim.TabIndex = 156;
            this.b_tim.Text = "Tìm kiếm";
            this.b_tim.TextColor = System.Drawing.Color.White;
            this.b_tim.UseVisualStyleBackColor = false;
            this.b_tim.Click += new System.EventHandler(this.b_tim_Click);
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
            this.b_comeback.Location = new System.Drawing.Point(12, 12);
            this.b_comeback.Name = "b_comeback";
            this.b_comeback.Size = new System.Drawing.Size(119, 28);
            this.b_comeback.TabIndex = 152;
            this.b_comeback.Text = "Về trang chủ";
            this.b_comeback.TextColor = System.Drawing.Color.White;
            this.b_comeback.UseVisualStyleBackColor = false;
            this.b_comeback.Click += new System.EventHandler(this.b_comeback_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 151;
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(835, 130);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(268, 22);
            this.txt_maphong.TabIndex = 149;
            // 
            // cb_tinhtrang
            // 
            this.cb_tinhtrang.FormattingEnabled = true;
            this.cb_tinhtrang.Items.AddRange(new object[] {
            "Đã đầy",
            "Còn trống"});
            this.cb_tinhtrang.Location = new System.Drawing.Point(201, 280);
            this.cb_tinhtrang.Name = "cb_tinhtrang";
            this.cb_tinhtrang.Size = new System.Drawing.Size(163, 24);
            this.cb_tinhtrang.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 147;
            this.label3.Text = "Tình trạng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 25);
            this.label10.TabIndex = 146;
            this.label10.Text = "Tên phòng tập";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenphong.Location = new System.Drawing.Point(201, 170);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(163, 22);
            this.txt_tenphong.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 144;
            this.label2.Text = "Số lượng người";
            // 
            // txt_songuoi
            // 
            this.txt_songuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_songuoi.Location = new System.Drawing.Point(201, 227);
            this.txt_songuoi.Name = "txt_songuoi";
            this.txt_songuoi.Size = new System.Drawing.Size(163, 22);
            this.txt_songuoi.TabIndex = 142;
            // 
            // lb_report
            // 
            this.lb_report.AutoSize = true;
            this.lb_report.BackColor = System.Drawing.Color.Transparent;
            this.lb_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_report.ForeColor = System.Drawing.Color.Black;
            this.lb_report.Location = new System.Drawing.Point(416, 41);
            this.lb_report.Name = "lb_report";
            this.lb_report.Size = new System.Drawing.Size(397, 39);
            this.lb_report.TabIndex = 140;
            this.lb_report.Text = "QUẢN LÝ PHÒNG TẬP";
            // 
            // grv_phong
            // 
            this.grv_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_phong.Location = new System.Drawing.Point(443, 170);
            this.grv_phong.Name = "grv_phong";
            this.grv_phong.RowHeadersWidth = 51;
            this.grv_phong.RowTemplate.Height = 24;
            this.grv_phong.Size = new System.Drawing.Size(776, 559);
            this.grv_phong.TabIndex = 138;
            // 
            // b_them
            // 
            this.b_them.BackColor = System.Drawing.Color.Black;
            this.b_them.BackgroundColor = System.Drawing.Color.Black;
            this.b_them.BorderColor = System.Drawing.Color.White;
            this.b_them.BorderRadius = 2;
            this.b_them.BorderSize = 1;
            this.b_them.FlatAppearance.BorderSize = 0;
            this.b_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_them.ForeColor = System.Drawing.Color.White;
            this.b_them.Location = new System.Drawing.Point(27, 353);
            this.b_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_them.Name = "b_them";
            this.b_them.Size = new System.Drawing.Size(115, 36);
            this.b_them.TabIndex = 157;
            this.b_them.Text = "Thêm";
            this.b_them.TextColor = System.Drawing.Color.White;
            this.b_them.UseVisualStyleBackColor = false;
            this.b_them.Click += new System.EventHandler(this.b_them_Click);
            // 
            // b_sua
            // 
            this.b_sua.BackColor = System.Drawing.Color.Black;
            this.b_sua.BackgroundColor = System.Drawing.Color.Black;
            this.b_sua.BorderColor = System.Drawing.Color.White;
            this.b_sua.BorderRadius = 2;
            this.b_sua.BorderSize = 1;
            this.b_sua.FlatAppearance.BorderSize = 0;
            this.b_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sua.ForeColor = System.Drawing.Color.White;
            this.b_sua.Location = new System.Drawing.Point(148, 353);
            this.b_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_sua.Name = "b_sua";
            this.b_sua.Size = new System.Drawing.Size(115, 36);
            this.b_sua.TabIndex = 158;
            this.b_sua.Text = "Sửa";
            this.b_sua.TextColor = System.Drawing.Color.White;
            this.b_sua.UseVisualStyleBackColor = false;
            this.b_sua.Click += new System.EventHandler(this.b_sua_Click);
            // 
            // b_capnhat
            // 
            this.b_capnhat.BackColor = System.Drawing.Color.Black;
            this.b_capnhat.BackgroundColor = System.Drawing.Color.Black;
            this.b_capnhat.BorderColor = System.Drawing.Color.White;
            this.b_capnhat.BorderRadius = 2;
            this.b_capnhat.BorderSize = 1;
            this.b_capnhat.FlatAppearance.BorderSize = 0;
            this.b_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_capnhat.ForeColor = System.Drawing.Color.White;
            this.b_capnhat.Location = new System.Drawing.Point(269, 353);
            this.b_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_capnhat.Name = "b_capnhat";
            this.b_capnhat.Size = new System.Drawing.Size(115, 36);
            this.b_capnhat.TabIndex = 159;
            this.b_capnhat.Text = "Cập Nhật";
            this.b_capnhat.TextColor = System.Drawing.Color.White;
            this.b_capnhat.UseVisualStyleBackColor = false;
            this.b_capnhat.Click += new System.EventHandler(this.b_capnhat_Click);
            // 
            // b_xoa
            // 
            this.b_xoa.BackColor = System.Drawing.Color.Black;
            this.b_xoa.BackgroundColor = System.Drawing.Color.Black;
            this.b_xoa.BorderColor = System.Drawing.Color.Black;
            this.b_xoa.BorderRadius = 2;
            this.b_xoa.BorderSize = 1;
            this.b_xoa.FlatAppearance.BorderSize = 0;
            this.b_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_xoa.ForeColor = System.Drawing.Color.White;
            this.b_xoa.Location = new System.Drawing.Point(1104, 744);
            this.b_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_xoa.Name = "b_xoa";
            this.b_xoa.Size = new System.Drawing.Size(115, 36);
            this.b_xoa.TabIndex = 160;
            this.b_xoa.Text = "Xóa";
            this.b_xoa.TextColor = System.Drawing.Color.White;
            this.b_xoa.UseVisualStyleBackColor = false;
            this.b_xoa.Click += new System.EventHandler(this.b_xoa_Click);
            // 
            // Form_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 853);
            this.Controls.Add(this.b_xoa);
            this.Controls.Add(this.b_capnhat);
            this.Controls.Add(this.b_sua);
            this.Controls.Add(this.b_them);
            this.Controls.Add(this.b_tim);
            this.Controls.Add(this.b_comeback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.cb_tinhtrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_songuoi);
            this.Controls.Add(this.lb_report);
            this.Controls.Add(this.grv_phong);
            this.Name = "Form_phong";
            this.Text = "Form_phong";
            this.Load += new System.EventHandler(this.Form_phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton b_tim;
        private RJButton b_comeback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.ComboBox cb_tinhtrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_songuoi;
        private System.Windows.Forms.Label lb_report;
        private System.Windows.Forms.DataGridView grv_phong;
        private RJButton b_them;
        private RJButton b_sua;
        private RJButton b_capnhat;
        private RJButton b_xoa;
    }
}