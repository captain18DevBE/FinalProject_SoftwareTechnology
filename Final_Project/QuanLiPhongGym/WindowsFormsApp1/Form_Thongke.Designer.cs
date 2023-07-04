namespace WindowsFormsApp1
{
    partial class Form_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_datestat = new System.Windows.Forms.DateTimePicker();
            this.cb_datetypestat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_loadstat = new WindowsFormsApp1.RJButton();
            this.b_savestat = new WindowsFormsApp1.RJButton();
            this.cb_stattype = new System.Windows.Forms.ComboBox();
            this.lbl_stat = new System.Windows.Forms.Label();
            this.chart_stat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grv_stat = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_excel = new System.Windows.Forms.SaveFileDialog();
            this.save_chart = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_stat)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtp_datestat);
            this.panel1.Controls.Add(this.cb_datetypestat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_loadstat);
            this.panel1.Controls.Add(this.b_savestat);
            this.panel1.Controls.Add(this.cb_stattype);
            this.panel1.Controls.Add(this.lbl_stat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 852);
            this.panel1.TabIndex = 0;
            // 
            // dtp_datestat
            // 
            this.dtp_datestat.Location = new System.Drawing.Point(1046, 654);
            this.dtp_datestat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_datestat.Name = "dtp_datestat";
            this.dtp_datestat.Size = new System.Drawing.Size(116, 22);
            this.dtp_datestat.TabIndex = 123;
            // 
            // cb_datetypestat
            // 
            this.cb_datetypestat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_datetypestat.FormattingEnabled = true;
            this.cb_datetypestat.Items.AddRange(new object[] {
            "TẤT CẢ",
            "NGÀY",
            "THÁNG",
            "NĂM"});
            this.cb_datetypestat.Location = new System.Drawing.Point(750, 654);
            this.cb_datetypestat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_datetypestat.Name = "cb_datetypestat";
            this.cb_datetypestat.Size = new System.Drawing.Size(277, 28);
            this.cb_datetypestat.TabIndex = 122;
            this.cb_datetypestat.SelectedValueChanged += new System.EventHandler(this.cb_datetypestat_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 654);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 121;
            this.label1.Text = "Thống Kê Theo:";
            // 
            // b_loadstat
            // 
            this.b_loadstat.BackColor = System.Drawing.Color.Firebrick;
            this.b_loadstat.BackgroundColor = System.Drawing.Color.Firebrick;
            this.b_loadstat.BorderColor = System.Drawing.Color.White;
            this.b_loadstat.BorderRadius = 2;
            this.b_loadstat.BorderSize = 1;
            this.b_loadstat.FlatAppearance.BorderSize = 0;
            this.b_loadstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_loadstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_loadstat.ForeColor = System.Drawing.Color.White;
            this.b_loadstat.Location = new System.Drawing.Point(1046, 708);
            this.b_loadstat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_loadstat.Name = "b_loadstat";
            this.b_loadstat.Size = new System.Drawing.Size(117, 42);
            this.b_loadstat.TabIndex = 120;
            this.b_loadstat.Text = "Xác Nhận";
            this.b_loadstat.TextColor = System.Drawing.Color.White;
            this.b_loadstat.UseVisualStyleBackColor = false;
            this.b_loadstat.Click += new System.EventHandler(this.b_loadstat_Click);
            // 
            // b_savestat
            // 
            this.b_savestat.BackColor = System.Drawing.Color.Firebrick;
            this.b_savestat.BackgroundColor = System.Drawing.Color.Firebrick;
            this.b_savestat.BorderColor = System.Drawing.Color.White;
            this.b_savestat.BorderRadius = 2;
            this.b_savestat.BorderSize = 1;
            this.b_savestat.FlatAppearance.BorderSize = 0;
            this.b_savestat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_savestat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_savestat.ForeColor = System.Drawing.Color.White;
            this.b_savestat.Location = new System.Drawing.Point(1171, 708);
            this.b_savestat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_savestat.Name = "b_savestat";
            this.b_savestat.Size = new System.Drawing.Size(68, 42);
            this.b_savestat.TabIndex = 119;
            this.b_savestat.Text = "Lưu";
            this.b_savestat.TextColor = System.Drawing.Color.White;
            this.b_savestat.UseVisualStyleBackColor = false;
            this.b_savestat.Click += new System.EventHandler(this.b_savestat_Click);
            // 
            // cb_stattype
            // 
            this.cb_stattype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stattype.FormattingEnabled = true;
            this.cb_stattype.Items.AddRange(new object[] {
            "DOANH THU DỊCH VỤ",
            "SỐ LƯỢNG ĐĂNG KÝ DỊCH VỤ",
            "CHI TIÊU KHÁCH HÀNG"});
            this.cb_stattype.Location = new System.Drawing.Point(750, 716);
            this.cb_stattype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_stattype.Name = "cb_stattype";
            this.cb_stattype.Size = new System.Drawing.Size(277, 28);
            this.cb_stattype.TabIndex = 3;
            // 
            // lbl_stat
            // 
            this.lbl_stat.AutoSize = true;
            this.lbl_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stat.Location = new System.Drawing.Point(572, 717);
            this.lbl_stat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stat.Name = "lbl_stat";
            this.lbl_stat.Size = new System.Drawing.Size(161, 25);
            this.lbl_stat.TabIndex = 2;
            this.lbl_stat.Text = "Loại Thống Kê:";
            // 
            // chart_stat
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_stat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_stat.Legends.Add(legend1);
            this.chart_stat.Location = new System.Drawing.Point(542, 26);
            this.chart_stat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_stat.Name = "chart_stat";
            this.chart_stat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đơn Vị";
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            this.chart_stat.Series.Add(series1);
            this.chart_stat.Size = new System.Drawing.Size(632, 527);
            this.chart_stat.TabIndex = 1;
            this.chart_stat.Text = "chart1";
            // 
            // grv_stat
            // 
            this.grv_stat.AllowUserToOrderColumns = true;
            this.grv_stat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_stat.Location = new System.Drawing.Point(40, 26);
            this.grv_stat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grv_stat.Name = "grv_stat";
            this.grv_stat.RowHeadersWidth = 51;
            this.grv_stat.Size = new System.Drawing.Size(472, 482);
            this.grv_stat.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(35, 526);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(285, 27);
            this.lbl_title.TabIndex = 124;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(280, 526);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_total.Size = new System.Drawing.Size(232, 27);
            this.lbl_total.TabIndex = 125;
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.grv_stat);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.chart_stat);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Location = new System.Drawing.Point(37, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 585);
            this.panel2.TabIndex = 126;
            // 
            // Form_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 853);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_ThongKe";
            this.Text = "Form_ThongKe";
            this.Load += new System.EventHandler(this.Form_ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_stat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grv_stat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stat;
        private System.Windows.Forms.ComboBox cb_stattype;
        private System.Windows.Forms.Label lbl_stat;
        private RJButton b_savestat;
        private System.Windows.Forms.DateTimePicker dtp_datestat;
        private System.Windows.Forms.ComboBox cb_datetypestat;
        private System.Windows.Forms.Label label1;
        private RJButton b_loadstat;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SaveFileDialog save_excel;
        private System.Windows.Forms.SaveFileDialog save_chart;
    }
}