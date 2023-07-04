namespace WindowsFormsApp1
{
    partial class Form_QuanLyKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TimerCustomer = new System.Windows.Forms.Timer(this.components);
            this.CusomerPnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EditInfCustomer = new System.Windows.Forms.Button();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.tbt_SearchCustomerByID = new System.Windows.Forms.TextBox();
            this.btn_onClickSearch = new System.Windows.Forms.PictureBox();
            this.btn_refreshListCustomer = new System.Windows.Forms.Button();
            this.pnl_SubFormEdit = new System.Windows.Forms.Panel();
            this.pnl_NavExitAdd = new System.Windows.Forms.Panel();
            this.btn_UpdateCustomerForm = new System.Windows.Forms.Button();
            this.btn_ExitFormEdit = new System.Windows.Forms.Button();
            this.tb_updateWeight = new System.Windows.Forms.TextBox();
            this.tb_updateHeight = new System.Windows.Forms.TextBox();
            this.lb_updateWeight = new System.Windows.Forms.Label();
            this.lb_updateHeight = new System.Windows.Forms.Label();
            this.pnl_Tiltle = new System.Windows.Forms.Panel();
            this.lb_TiltlePanelEditCustomer = new System.Windows.Forms.Label();
            this.pnlListData = new System.Windows.Forms.Panel();
            this.dGV_ListCustomer = new System.Windows.Forms.DataGridView();
            this.CusomerPnlTop.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_onClickSearch)).BeginInit();
            this.pnl_SubFormEdit.SuspendLayout();
            this.pnl_NavExitAdd.SuspendLayout();
            this.pnl_Tiltle.SuspendLayout();
            this.pnlListData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerCustomer
            // 
            this.TimerCustomer.Interval = 500;
            this.TimerCustomer.Tick += new System.EventHandler(this.TimerCustomer_Tick_1);
            // 
            // CusomerPnlTop
            // 
            this.CusomerPnlTop.ColumnCount = 4;
            this.CusomerPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.CusomerPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.CusomerPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.CusomerPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 788F));
            this.CusomerPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CusomerPnlTop.Controls.Add(this.btn_EditInfCustomer, 0, 0);
            this.CusomerPnlTop.Controls.Add(this.pnl_Search, 3, 0);
            this.CusomerPnlTop.Controls.Add(this.btn_refreshListCustomer, 1, 0);
            this.CusomerPnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.CusomerPnlTop.Location = new System.Drawing.Point(0, 0);
            this.CusomerPnlTop.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.CusomerPnlTop.Name = "CusomerPnlTop";
            this.CusomerPnlTop.Padding = new System.Windows.Forms.Padding(2);
            this.CusomerPnlTop.RowCount = 1;
            this.CusomerPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CusomerPnlTop.Size = new System.Drawing.Size(1000, 50);
            this.CusomerPnlTop.TabIndex = 3;
            // 
            // btn_EditInfCustomer
            // 
            this.btn_EditInfCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btn_EditInfCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EditInfCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_EditInfCustomer.Location = new System.Drawing.Point(3, 3);
            this.btn_EditInfCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_EditInfCustomer.Name = "btn_EditInfCustomer";
            this.btn_EditInfCustomer.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_EditInfCustomer.Size = new System.Drawing.Size(140, 44);
            this.btn_EditInfCustomer.TabIndex = 2;
            this.btn_EditInfCustomer.Text = "Chỉnh sửa";
            this.btn_EditInfCustomer.UseVisualStyleBackColor = false;
            this.btn_EditInfCustomer.Click += new System.EventHandler(this.btn_EditInfCustomer_Click_1);
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_Search.Controls.Add(this.tbt_SearchCustomerByID);
            this.pnl_Search.Controls.Add(this.btn_onClickSearch);
            this.pnl_Search.Location = new System.Drawing.Point(564, 2);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(136, 0, 0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(427, 44);
            this.pnl_Search.TabIndex = 4;
            // 
            // tbt_SearchCustomerByID
            // 
            this.tbt_SearchCustomerByID.BackColor = System.Drawing.Color.White;
            this.tbt_SearchCustomerByID.Location = new System.Drawing.Point(20, 7);
            this.tbt_SearchCustomerByID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbt_SearchCustomerByID.Multiline = true;
            this.tbt_SearchCustomerByID.Name = "tbt_SearchCustomerByID";
            this.tbt_SearchCustomerByID.Size = new System.Drawing.Size(344, 30);
            this.tbt_SearchCustomerByID.TabIndex = 1;
            // 
            // btn_onClickSearch
            // 
            this.btn_onClickSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_onClickSearch.BackColor = System.Drawing.Color.White;
            this.btn_onClickSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_onClickSearch.BackgroundImage")));
            this.btn_onClickSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_onClickSearch.Location = new System.Drawing.Point(374, 7);
            this.btn_onClickSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_onClickSearch.Name = "btn_onClickSearch";
            this.btn_onClickSearch.Size = new System.Drawing.Size(45, 30);
            this.btn_onClickSearch.TabIndex = 0;
            this.btn_onClickSearch.TabStop = false;
            this.btn_onClickSearch.Click += new System.EventHandler(this.btn_onClickSearch_Click);
            // 
            // btn_refreshListCustomer
            // 
            this.btn_refreshListCustomer.BackColor = System.Drawing.Color.Firebrick;
            this.btn_refreshListCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_refreshListCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_refreshListCustomer.Location = new System.Drawing.Point(145, 3);
            this.btn_refreshListCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_refreshListCustomer.Name = "btn_refreshListCustomer";
            this.btn_refreshListCustomer.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_refreshListCustomer.Size = new System.Drawing.Size(140, 44);
            this.btn_refreshListCustomer.TabIndex = 3;
            this.btn_refreshListCustomer.Text = "Làm mới";
            this.btn_refreshListCustomer.UseVisualStyleBackColor = false;
            this.btn_refreshListCustomer.Click += new System.EventHandler(this.btn_refreshListCustomer_Click);
            // 
            // pnl_SubFormEdit
            // 
            this.pnl_SubFormEdit.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_SubFormEdit.Controls.Add(this.pnl_NavExitAdd);
            this.pnl_SubFormEdit.Controls.Add(this.tb_updateWeight);
            this.pnl_SubFormEdit.Controls.Add(this.tb_updateHeight);
            this.pnl_SubFormEdit.Controls.Add(this.lb_updateWeight);
            this.pnl_SubFormEdit.Controls.Add(this.lb_updateHeight);
            this.pnl_SubFormEdit.Controls.Add(this.pnl_Tiltle);
            this.pnl_SubFormEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_SubFormEdit.Location = new System.Drawing.Point(610, 50);
            this.pnl_SubFormEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_SubFormEdit.Name = "pnl_SubFormEdit";
            this.pnl_SubFormEdit.Size = new System.Drawing.Size(390, 550);
            this.pnl_SubFormEdit.TabIndex = 5;
            // 
            // pnl_NavExitAdd
            // 
            this.pnl_NavExitAdd.Controls.Add(this.btn_UpdateCustomerForm);
            this.pnl_NavExitAdd.Controls.Add(this.btn_ExitFormEdit);
            this.pnl_NavExitAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_NavExitAdd.Location = new System.Drawing.Point(0, 479);
            this.pnl_NavExitAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_NavExitAdd.Name = "pnl_NavExitAdd";
            this.pnl_NavExitAdd.Size = new System.Drawing.Size(390, 71);
            this.pnl_NavExitAdd.TabIndex = 11;
            // 
            // btn_UpdateCustomerForm
            // 
            this.btn_UpdateCustomerForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateCustomerForm.BackColor = System.Drawing.Color.Firebrick;
            this.btn_UpdateCustomerForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UpdateCustomerForm.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateCustomerForm.Location = new System.Drawing.Point(239, 27);
            this.btn_UpdateCustomerForm.Margin = new System.Windows.Forms.Padding(1);
            this.btn_UpdateCustomerForm.Name = "btn_UpdateCustomerForm";
            this.btn_UpdateCustomerForm.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_UpdateCustomerForm.Size = new System.Drawing.Size(131, 30);
            this.btn_UpdateCustomerForm.TabIndex = 2;
            this.btn_UpdateCustomerForm.Text = "Lưu";
            this.btn_UpdateCustomerForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UpdateCustomerForm.UseVisualStyleBackColor = false;
            this.btn_UpdateCustomerForm.Click += new System.EventHandler(this.btn_UpdateCustomerForm_Click);
            // 
            // btn_ExitFormEdit
            // 
            this.btn_ExitFormEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExitFormEdit.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ExitFormEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExitFormEdit.ForeColor = System.Drawing.Color.White;
            this.btn_ExitFormEdit.Location = new System.Drawing.Point(24, 27);
            this.btn_ExitFormEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ExitFormEdit.Name = "btn_ExitFormEdit";
            this.btn_ExitFormEdit.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btn_ExitFormEdit.Size = new System.Drawing.Size(147, 30);
            this.btn_ExitFormEdit.TabIndex = 1;
            this.btn_ExitFormEdit.Text = "Đóng";
            this.btn_ExitFormEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ExitFormEdit.UseVisualStyleBackColor = false;
            this.btn_ExitFormEdit.Click += new System.EventHandler(this.btn_ExitFormEdit_Click);
            // 
            // tb_updateWeight
            // 
            this.tb_updateWeight.Location = new System.Drawing.Point(60, 269);
            this.tb_updateWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_updateWeight.Multiline = true;
            this.tb_updateWeight.Name = "tb_updateWeight";
            this.tb_updateWeight.Size = new System.Drawing.Size(310, 30);
            this.tb_updateWeight.TabIndex = 7;
            // 
            // tb_updateHeight
            // 
            this.tb_updateHeight.Location = new System.Drawing.Point(60, 166);
            this.tb_updateHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_updateHeight.Multiline = true;
            this.tb_updateHeight.Name = "tb_updateHeight";
            this.tb_updateHeight.Size = new System.Drawing.Size(310, 30);
            this.tb_updateHeight.TabIndex = 6;
            // 
            // lb_updateWeight
            // 
            this.lb_updateWeight.AutoSize = true;
            this.lb_updateWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_updateWeight.ForeColor = System.Drawing.Color.White;
            this.lb_updateWeight.Location = new System.Drawing.Point(64, 236);
            this.lb_updateWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_updateWeight.Name = "lb_updateWeight";
            this.lb_updateWeight.Size = new System.Drawing.Size(115, 13);
            this.lb_updateWeight.TabIndex = 2;
            this.lb_updateWeight.Text = "Cập nhật cân nặng";
            // 
            // lb_updateHeight
            // 
            this.lb_updateHeight.AutoSize = true;
            this.lb_updateHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_updateHeight.ForeColor = System.Drawing.Color.White;
            this.lb_updateHeight.Location = new System.Drawing.Point(57, 130);
            this.lb_updateHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_updateHeight.Name = "lb_updateHeight";
            this.lb_updateHeight.Size = new System.Drawing.Size(122, 13);
            this.lb_updateHeight.TabIndex = 1;
            this.lb_updateHeight.Text = "Cập nhật chiều cao:";
            // 
            // pnl_Tiltle
            // 
            this.pnl_Tiltle.Controls.Add(this.lb_TiltlePanelEditCustomer);
            this.pnl_Tiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tiltle.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tiltle.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Tiltle.Name = "pnl_Tiltle";
            this.pnl_Tiltle.Size = new System.Drawing.Size(390, 40);
            this.pnl_Tiltle.TabIndex = 0;
            // 
            // lb_TiltlePanelEditCustomer
            // 
            this.lb_TiltlePanelEditCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TiltlePanelEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TiltlePanelEditCustomer.ForeColor = System.Drawing.Color.White;
            this.lb_TiltlePanelEditCustomer.Location = new System.Drawing.Point(0, 0);
            this.lb_TiltlePanelEditCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TiltlePanelEditCustomer.Name = "lb_TiltlePanelEditCustomer";
            this.lb_TiltlePanelEditCustomer.Size = new System.Drawing.Size(390, 40);
            this.lb_TiltlePanelEditCustomer.TabIndex = 3;
            this.lb_TiltlePanelEditCustomer.Text = "Cập Nhật Thông Tin Khách Hàng";
            this.lb_TiltlePanelEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlListData
            // 
            this.pnlListData.Controls.Add(this.dGV_ListCustomer);
            this.pnlListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListData.Location = new System.Drawing.Point(0, 50);
            this.pnlListData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlListData.Name = "pnlListData";
            this.pnlListData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlListData.Size = new System.Drawing.Size(610, 550);
            this.pnlListData.TabIndex = 6;
            // 
            // dGV_ListCustomer
            // 
            this.dGV_ListCustomer.AllowUserToAddRows = false;
            this.dGV_ListCustomer.AllowUserToDeleteRows = false;
            this.dGV_ListCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dGV_ListCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dGV_ListCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGV_ListCustomer.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ListCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_ListCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ListCustomer.EnableHeadersVisualStyles = false;
            this.dGV_ListCustomer.GridColor = System.Drawing.Color.White;
            this.dGV_ListCustomer.Location = new System.Drawing.Point(4, 3);
            this.dGV_ListCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.dGV_ListCustomer.Name = "dGV_ListCustomer";
            this.dGV_ListCustomer.ReadOnly = true;
            this.dGV_ListCustomer.Size = new System.Drawing.Size(602, 544);
            this.dGV_ListCustomer.TabIndex = 0;
            this.dGV_ListCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ListCustomer_CellClick);
            // 
            // Form_QuanLyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlListData);
            this.Controls.Add(this.pnl_SubFormEdit);
            this.Controls.Add(this.CusomerPnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_QuanLyKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Customer";
            this.Load += new System.EventHandler(this.Form_QuanLyKH_Load);
            this.CusomerPnlTop.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_onClickSearch)).EndInit();
            this.pnl_SubFormEdit.ResumeLayout(false);
            this.pnl_SubFormEdit.PerformLayout();
            this.pnl_NavExitAdd.ResumeLayout(false);
            this.pnl_Tiltle.ResumeLayout(false);
            this.pnlListData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerCustomer;
        private System.Windows.Forms.TableLayoutPanel CusomerPnlTop;
        private System.Windows.Forms.Button btn_EditInfCustomer;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.TextBox tbt_SearchCustomerByID;
        private System.Windows.Forms.PictureBox btn_onClickSearch;
        private System.Windows.Forms.Button btn_refreshListCustomer;
        private System.Windows.Forms.Panel pnl_SubFormEdit;
        private System.Windows.Forms.Panel pnl_NavExitAdd;
        private System.Windows.Forms.Button btn_UpdateCustomerForm;
        private System.Windows.Forms.Button btn_ExitFormEdit;
        private System.Windows.Forms.TextBox tb_updateWeight;
        private System.Windows.Forms.TextBox tb_updateHeight;
        private System.Windows.Forms.Label lb_updateWeight;
        private System.Windows.Forms.Label lb_updateHeight;
        private System.Windows.Forms.Panel pnl_Tiltle;
        private System.Windows.Forms.Label lb_TiltlePanelEditCustomer;
        private System.Windows.Forms.Panel pnlListData;
        private System.Windows.Forms.DataGridView dGV_ListCustomer;
    }
}