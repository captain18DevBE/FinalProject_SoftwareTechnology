namespace WindowsFormsApp1
{
    partial class Form_HoaDonLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HoaDonLe));
            this.b_print = new System.Windows.Forms.Button();
            this.grv_hdl = new System.Windows.Forms.DataGridView();
            this.b_cancel = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lb_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_hdl)).BeginInit();
            this.SuspendLayout();
            // 
            // b_print
            // 
            this.b_print.BackColor = System.Drawing.Color.Black;
            this.b_print.ForeColor = System.Drawing.Color.White;
            this.b_print.Location = new System.Drawing.Point(304, 300);
            this.b_print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_print.Name = "b_print";
            this.b_print.Size = new System.Drawing.Size(117, 47);
            this.b_print.TabIndex = 3;
            this.b_print.Text = "In hóa đơn";
            this.b_print.UseVisualStyleBackColor = false;
            this.b_print.Click += new System.EventHandler(this.b_print_Click);
            // 
            // grv_hdl
            // 
            this.grv_hdl.AllowUserToAddRows = false;
            this.grv_hdl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_hdl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.Gia,
            this.Phong});
            this.grv_hdl.Location = new System.Drawing.Point(15, 14);
            this.grv_hdl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grv_hdl.Name = "grv_hdl";
            this.grv_hdl.RowHeadersWidth = 51;
            this.grv_hdl.RowTemplate.Height = 24;
            this.grv_hdl.Size = new System.Drawing.Size(533, 224);
            this.grv_hdl.TabIndex = 4;
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.Black;
            this.b_cancel.ForeColor = System.Drawing.Color.White;
            this.b_cancel.Location = new System.Drawing.Point(429, 300);
            this.b_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(117, 47);
            this.b_cancel.TabIndex = 5;
            this.b_cancel.Text = "Hủy";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(16, 268);
            this.lb_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(51, 20);
            this.lb_total.TabIndex = 6;
            this.lb_total.Text = "Tổng:";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.Black;
            this.txt_total.Location = new System.Drawing.Point(72, 268);
            this.txt_total.Margin = new System.Windows.Forms.Padding(0);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(96, 19);
            this.txt_total.TabIndex = 7;
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
            this.TenDV.Width = 150;
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
            // Form_HoaDonLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 362);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.grv_hdl);
            this.Controls.Add(this.b_print);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_HoaDonLe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_HoaDonLe";
            this.Load += new System.EventHandler(this.Form_HoaDonLe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_hdl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_print;
        private System.Windows.Forms.DataGridView grv_hdl;
        private System.Windows.Forms.Button b_cancel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
    }
}