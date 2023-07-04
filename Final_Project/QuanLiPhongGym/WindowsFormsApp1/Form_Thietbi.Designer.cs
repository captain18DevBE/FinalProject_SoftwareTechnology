namespace WindowsFormsApp1
{
    partial class Form_Thietbi
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
            this.grv_thietbi = new System.Windows.Forms.DataGridView();
            this.lb_report = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_tenthietbi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.txt_matb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ngaynhap = new System.Windows.Forms.TextBox();
            this.b_tim = new WindowsFormsApp1.RJButton();
            this.b_sua = new WindowsFormsApp1.RJButton();
            this.b_xoa = new WindowsFormsApp1.RJButton();
            this.b_them = new WindowsFormsApp1.RJButton();
            this.b_comeback = new WindowsFormsApp1.RJButton();
            this.b_capnhat = new WindowsFormsApp1.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.grv_thietbi)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_thietbi
            // 
            this.grv_thietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_thietbi.Location = new System.Drawing.Point(460, 172);
            this.grv_thietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grv_thietbi.Name = "grv_thietbi";
            this.grv_thietbi.RowHeadersWidth = 51;
            this.grv_thietbi.RowTemplate.Height = 24;
            this.grv_thietbi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_thietbi.Size = new System.Drawing.Size(776, 559);
            this.grv_thietbi.TabIndex = 1;
            // 
            // lb_report
            // 
            this.lb_report.AutoSize = true;
            this.lb_report.BackColor = System.Drawing.Color.Transparent;
            this.lb_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_report.ForeColor = System.Drawing.Color.Black;
            this.lb_report.Location = new System.Drawing.Point(452, 42);
            this.lb_report.Name = "lb_report";
            this.lb_report.Size = new System.Drawing.Size(333, 39);
            this.lb_report.TabIndex = 113;
            this.lb_report.Text = "QUẢN LÝ THIẾT BỊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 117;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "Tên thiết bị";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(193, 226);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(172, 22);
            this.txt_soluong.TabIndex = 115;
            // 
            // txt_tenthietbi
            // 
            this.txt_tenthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenthietbi.Location = new System.Drawing.Point(193, 172);
            this.txt_tenthietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenthietbi.Name = "txt_tenthietbi";
            this.txt_tenthietbi.Size = new System.Drawing.Size(172, 22);
            this.txt_tenthietbi.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 121;
            this.label3.Text = "Tình trạng";
            // 
            // cb_tinhtrang
            // 
            this.cb_tinhtrang.FormattingEnabled = true;
            this.cb_tinhtrang.Items.AddRange(new object[] {
            "Mới",
            "Bình thường",
            "Cũ",
            "Hư hỏng"});
            this.cb_tinhtrang.Location = new System.Drawing.Point(193, 334);
            this.cb_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_tinhtrang.Name = "cb_tinhtrang";
            this.cb_tinhtrang.Size = new System.Drawing.Size(172, 24);
            this.cb_tinhtrang.TabIndex = 122;
            // 
            // txt_matb
            // 
            this.txt_matb.Location = new System.Drawing.Point(853, 127);
            this.txt_matb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matb.Name = "txt_matb";
            this.txt_matb.Size = new System.Drawing.Size(268, 22);
            this.txt_matb.TabIndex = 128;
            this.txt_matb.Tag = "";
            this.txt_matb.Text = "Tìm kiếm bằng mã thiết bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 131;
            this.label4.Text = "Ngày nhập";
            // 
            // txt_ngaynhap
            // 
            this.txt_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaynhap.Location = new System.Drawing.Point(193, 280);
            this.txt_ngaynhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngaynhap.Name = "txt_ngaynhap";
            this.txt_ngaynhap.Size = new System.Drawing.Size(172, 22);
            this.txt_ngaynhap.TabIndex = 130;
            // 
            // dichvudadangkyTableAdapter1
            // 
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
            this.b_tim.Location = new System.Drawing.Point(1127, 126);
            this.b_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_tim.Name = "b_tim";
            this.b_tim.Size = new System.Drawing.Size(109, 25);
            this.b_tim.TabIndex = 137;
            this.b_tim.Text = "Tìm kiếm";
            this.b_tim.TextColor = System.Drawing.Color.White;
            this.b_tim.UseVisualStyleBackColor = false;
            this.b_tim.Click += new System.EventHandler(this.b_tim_Click);
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
            this.b_sua.Location = new System.Drawing.Point(165, 411);
            this.b_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_sua.Name = "b_sua";
            this.b_sua.Size = new System.Drawing.Size(115, 36);
            this.b_sua.TabIndex = 136;
            this.b_sua.Text = "Sửa";
            this.b_sua.TextColor = System.Drawing.Color.White;
            this.b_sua.UseVisualStyleBackColor = false;
            this.b_sua.Click += new System.EventHandler(this.b_sua_Click);
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
            this.b_xoa.Location = new System.Drawing.Point(1121, 756);
            this.b_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_xoa.Name = "b_xoa";
            this.b_xoa.Size = new System.Drawing.Size(115, 36);
            this.b_xoa.TabIndex = 135;
            this.b_xoa.Text = "Xóa";
            this.b_xoa.TextColor = System.Drawing.Color.White;
            this.b_xoa.UseVisualStyleBackColor = false;
            this.b_xoa.Click += new System.EventHandler(this.b_xoa_Click);
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
            this.b_them.Location = new System.Drawing.Point(44, 411);
            this.b_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_them.Name = "b_them";
            this.b_them.Size = new System.Drawing.Size(115, 36);
            this.b_them.TabIndex = 134;
            this.b_them.Text = "Thêm";
            this.b_them.TextColor = System.Drawing.Color.White;
            this.b_them.UseVisualStyleBackColor = false;
            this.b_them.Click += new System.EventHandler(this.b_them_Click);
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
            this.b_comeback.TabIndex = 132;
            this.b_comeback.Text = "Về trang chủ";
            this.b_comeback.TextColor = System.Drawing.Color.White;
            this.b_comeback.UseVisualStyleBackColor = false;
            this.b_comeback.Click += new System.EventHandler(this.b_comeback_Click);
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
            this.b_capnhat.Location = new System.Drawing.Point(286, 411);
            this.b_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_capnhat.Name = "b_capnhat";
            this.b_capnhat.Size = new System.Drawing.Size(115, 36);
            this.b_capnhat.TabIndex = 138;
            this.b_capnhat.Text = "Cập Nhật";
            this.b_capnhat.TextColor = System.Drawing.Color.White;
            this.b_capnhat.UseVisualStyleBackColor = false;
            this.b_capnhat.Click += new System.EventHandler(this.b_capnhat_Click);
            // 
            // Form_Thietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 853);
            this.Controls.Add(this.b_capnhat);
            this.Controls.Add(this.b_tim);
            this.Controls.Add(this.b_sua);
            this.Controls.Add(this.b_xoa);
            this.Controls.Add(this.b_them);
            this.Controls.Add(this.b_comeback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ngaynhap);
            this.Controls.Add(this.txt_matb);
            this.Controls.Add(this.cb_tinhtrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tenthietbi);
            this.Controls.Add(this.lb_report);
            this.Controls.Add(this.grv_thietbi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Thietbi";
            this.Text = "Form_Thietbi";
            this.Load += new System.EventHandler(this.Form_Thietbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_thietbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grv_thietbi;
        private System.Windows.Forms.Label lb_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_tenthietbi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tinhtrang;
        private RJButton lb_comeback;
        private RJButton rjButton4;
        private RJButton rjButton3;
        private RJButton rjButton2;
        private RJButton rjButton1;
        private System.Windows.Forms.TextBox txt_matb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ngaynhap;
        private RJButton b_comeback;
        private RJButton b_tim;
        private RJButton b_sua;
        private RJButton b_xoa;
        private RJButton b_them;
        private RJButton b_capnhat;
    }
}