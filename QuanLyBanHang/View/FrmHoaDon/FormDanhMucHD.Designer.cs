namespace QuanLyBanHang.View.FrmHoaDon
{
    partial class FormDanhMucHD
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            rdb_ChuaThanhToan = new RadioButton();
            rdb_DaThanhToan = new RadioButton();
            dtp_ngayBan = new DateTimePicker();
            txt_ghiChu = new TextBox();
            txt_TongTien = new TextBox();
            txt_SDTKH = new TextBox();
            txt_MaNV = new TextBox();
            txt_MaHD = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_CapNhap = new Button();
            groupBox3 = new GroupBox();
            dtgv_HoaDon = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btn_TimKiem = new Button();
            txt_timKiem = new TextBox();
            groupBox4 = new GroupBox();
            dtgv_ChiTietHoaDon = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            btn_xoa = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_HoaDon).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_ChiTietHoaDon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(rdb_ChuaThanhToan);
            groupBox1.Controls.Add(rdb_DaThanhToan);
            groupBox1.Controls.Add(dtp_ngayBan);
            groupBox1.Controls.Add(txt_ghiChu);
            groupBox1.Controls.Add(txt_TongTien);
            groupBox1.Controls.Add(txt_SDTKH);
            groupBox1.Controls.Add(txt_MaNV);
            groupBox1.Controls.Add(txt_MaHD);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 11);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(971, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục đơn hàng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(849, 49);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 19);
            label9.TabIndex = 15;
            label9.Text = "VNĐ";
            // 
            // rdb_ChuaThanhToan
            // 
            rdb_ChuaThanhToan.AutoSize = true;
            rdb_ChuaThanhToan.Location = new Point(743, 196);
            rdb_ChuaThanhToan.Margin = new Padding(4, 3, 4, 3);
            rdb_ChuaThanhToan.Name = "rdb_ChuaThanhToan";
            rdb_ChuaThanhToan.Size = new Size(150, 23);
            rdb_ChuaThanhToan.TabIndex = 14;
            rdb_ChuaThanhToan.TabStop = true;
            rdb_ChuaThanhToan.Text = "Chưa thanh toán";
            rdb_ChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdb_DaThanhToan
            // 
            rdb_DaThanhToan.AutoSize = true;
            rdb_DaThanhToan.Location = new Point(575, 196);
            rdb_DaThanhToan.Margin = new Padding(4, 3, 4, 3);
            rdb_DaThanhToan.Name = "rdb_DaThanhToan";
            rdb_DaThanhToan.Size = new Size(131, 23);
            rdb_DaThanhToan.TabIndex = 13;
            rdb_DaThanhToan.TabStop = true;
            rdb_DaThanhToan.Text = "Đã thanh toán";
            rdb_DaThanhToan.UseVisualStyleBackColor = true;
            // 
            // dtp_ngayBan
            // 
            dtp_ngayBan.Enabled = false;
            dtp_ngayBan.Location = new Point(575, 95);
            dtp_ngayBan.Margin = new Padding(4, 3, 4, 3);
            dtp_ngayBan.Name = "dtp_ngayBan";
            dtp_ngayBan.Size = new Size(259, 27);
            dtp_ngayBan.TabIndex = 12;
            // 
            // txt_ghiChu
            // 
            txt_ghiChu.Location = new Point(575, 149);
            txt_ghiChu.Margin = new Padding(4, 3, 4, 3);
            txt_ghiChu.Name = "txt_ghiChu";
            txt_ghiChu.Size = new Size(259, 27);
            txt_ghiChu.TabIndex = 11;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Enabled = false;
            txt_TongTien.Location = new Point(575, 47);
            txt_TongTien.Margin = new Padding(4, 3, 4, 3);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(259, 27);
            txt_TongTien.TabIndex = 10;
            // 
            // txt_SDTKH
            // 
            txt_SDTKH.Enabled = false;
            txt_SDTKH.Location = new Point(156, 149);
            txt_SDTKH.Margin = new Padding(4, 3, 4, 3);
            txt_SDTKH.Name = "txt_SDTKH";
            txt_SDTKH.Size = new Size(259, 27);
            txt_SDTKH.TabIndex = 9;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Enabled = false;
            txt_MaNV.Location = new Point(156, 97);
            txt_MaNV.Margin = new Padding(4, 3, 4, 3);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(259, 27);
            txt_MaNV.TabIndex = 8;
            // 
            // txt_MaHD
            // 
            txt_MaHD.Enabled = false;
            txt_MaHD.Location = new Point(156, 47);
            txt_MaHD.Margin = new Padding(4, 3, 4, 3);
            txt_MaHD.Name = "txt_MaHD";
            txt_MaHD.Size = new Size(259, 27);
            txt_MaHD.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(455, 198);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 19);
            label7.TabIndex = 6;
            label7.Text = "Trạng thái :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(455, 155);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 5;
            label6.Text = "Ghi chú :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 100);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 4;
            label5.Text = "Ngày bán :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 49);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 3;
            label4.Text = "Tổng tiền :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 2;
            label3.Text = "SDT KH :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_xoa);
            groupBox2.Controls.Add(btn_CapNhap);
            groupBox2.Location = new Point(1016, 15);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(312, 231);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_CapNhap
            // 
            btn_CapNhap.Location = new Point(63, 59);
            btn_CapNhap.Margin = new Padding(4, 3, 4, 3);
            btn_CapNhap.Name = "btn_CapNhap";
            btn_CapNhap.Size = new Size(186, 45);
            btn_CapNhap.TabIndex = 1;
            btn_CapNhap.Text = "CẬP NHẬP";
            btn_CapNhap.UseVisualStyleBackColor = true;
            btn_CapNhap.Click += btn_CapNhap_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_HoaDon);
            groupBox3.Controls.Add(btn_TimKiem);
            groupBox3.Controls.Add(txt_timKiem);
            groupBox3.Location = new Point(15, 252);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(1314, 246);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn";
            // 
            // dtgv_HoaDon
            // 
            dtgv_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_HoaDon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dtgv_HoaDon.Location = new Point(8, 48);
            dtgv_HoaDon.Margin = new Padding(4, 3, 4, 3);
            dtgv_HoaDon.Name = "dtgv_HoaDon";
            dtgv_HoaDon.RowHeadersWidth = 51;
            dtgv_HoaDon.RowTemplate.Height = 29;
            dtgv_HoaDon.Size = new Size(1299, 180);
            dtgv_HoaDon.TabIndex = 17;
            dtgv_HoaDon.CellClick += dtgv_HoaDon_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã HD";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã NV";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "SDT KH";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng tiền";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày bán";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Ghi chú";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng thái";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(1189, 16);
            btn_TimKiem.Margin = new Padding(4, 3, 4, 3);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(118, 28);
            btn_TimKiem.TabIndex = 16;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // txt_timKiem
            // 
            txt_timKiem.Location = new Point(921, 16);
            txt_timKiem.Margin = new Padding(4, 3, 4, 3);
            txt_timKiem.Name = "txt_timKiem";
            txt_timKiem.PlaceholderText = "Tìm kiếm ở đây ...";
            txt_timKiem.Size = new Size(259, 27);
            txt_timKiem.TabIndex = 15;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtgv_ChiTietHoaDon);
            groupBox4.Location = new Point(15, 504);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(1314, 196);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // dtgv_ChiTietHoaDon
            // 
            dtgv_ChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ChiTietHoaDon.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column11, Column12 });
            dtgv_ChiTietHoaDon.Location = new Point(8, 25);
            dtgv_ChiTietHoaDon.Margin = new Padding(4, 3, 4, 3);
            dtgv_ChiTietHoaDon.Name = "dtgv_ChiTietHoaDon";
            dtgv_ChiTietHoaDon.RowHeadersWidth = 51;
            dtgv_ChiTietHoaDon.RowTemplate.Height = 29;
            dtgv_ChiTietHoaDon.Size = new Size(1299, 165);
            dtgv_ChiTietHoaDon.TabIndex = 18;
            // 
            // Column9
            // 
            Column9.HeaderText = "Mã SP";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Tên SP";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Số lượng";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Đơn giá";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(63, 138);
            btn_xoa.Margin = new Padding(4, 3, 4, 3);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(186, 45);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "XÓA";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // FormDanhMucHD
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1834, 711);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDanhMucHD";
            Text = "FormDanhMucHD";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_HoaDon).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_ChiTietHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_SDTKH;
        private TextBox txt_MaNV;
        private TextBox txt_MaHD;
        private TextBox txt_ghiChu;
        private TextBox txt_TongTien;
        private DateTimePicker dtp_ngayBan;
        private RadioButton rdb_ChuaThanhToan;
        private RadioButton rdb_DaThanhToan;
        private TextBox txt_timKiem;
        private Label label9;
        private Button btn_TimKiem;
        private Button btn_CapNhap;
        private DataGridView dtgv_HoaDon;
        private DataGridView dtgv_ChiTietHoaDon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button btn_xoa;
    }
}