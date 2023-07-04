namespace WindowsFormsApp1
{
    partial class Form_TapThu
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
            this.lb_report = new System.Windows.Forms.Label();
            this.grv_dktt = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.qUANLYPHONGGYMDataSet = new WindowsFormsApp1.QUANLYPHONGGYMDataSet();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUTableAdapter = new WindowsFormsApp1.QUANLYPHONGGYMDataSetTableAdapters.DICHVUTableAdapter();
            this.maDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichTapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDVDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dktt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_report
            // 
            this.lb_report.AutoSize = true;
            this.lb_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_report.ForeColor = System.Drawing.Color.Black;
            this.lb_report.Location = new System.Drawing.Point(480, 11);
            this.lb_report.Name = "lb_report";
            this.lb_report.Size = new System.Drawing.Size(300, 39);
            this.lb_report.TabIndex = 122;
            this.lb_report.Text = "Đăng Ký Tập Thử";
            // 
            // grv_dktt
            // 
            this.grv_dktt.AutoGenerateColumns = false;
            this.grv_dktt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_dktt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDVDataGridViewTextBoxColumn,
            this.tenDVDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.lichTapDataGridViewTextBoxColumn,
            this.anhDVDataGridViewImageColumn});
            this.grv_dktt.DataSource = this.dICHVUBindingSource;
            this.grv_dktt.Location = new System.Drawing.Point(40, 151);
            this.grv_dktt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grv_dktt.Name = "grv_dktt";
            this.grv_dktt.RowHeadersWidth = 51;
            this.grv_dktt.Size = new System.Drawing.Size(772, 549);
            this.grv_dktt.TabIndex = 123;
            this.grv_dktt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_dktt_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 105);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 125;
            this.label1.Text = "Chọn ngày tập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(853, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1093, 654);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 128;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // qUANLYPHONGGYMDataSet
            // 
            this.qUANLYPHONGGYMDataSet.DataSetName = "QUANLYPHONGGYMDataSet";
            this.qUANLYPHONGGYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // anhDVDataGridViewImageColumn
            // 
            this.anhDVDataGridViewImageColumn.DataPropertyName = "AnhDV";
            this.anhDVDataGridViewImageColumn.HeaderText = "AnhDV";
            this.anhDVDataGridViewImageColumn.MinimumWidth = 6;
            this.anhDVDataGridViewImageColumn.Name = "anhDVDataGridViewImageColumn";
            this.anhDVDataGridViewImageColumn.Width = 125;
            // 
            // Form_TapThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 853);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grv_dktt);
            this.Controls.Add(this.lb_report);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_TapThu";
            this.Text = "Form_TapThu";
            this.Load += new System.EventHandler(this.Form_TapThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_dktt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYPHONGGYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_report;
        private System.Windows.Forms.DataGridView grv_dktt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private QUANLYPHONGGYMDataSet qUANLYPHONGGYMDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private QUANLYPHONGGYMDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lichTapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn anhDVDataGridViewImageColumn;
    }
}