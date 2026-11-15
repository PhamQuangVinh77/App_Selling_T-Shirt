namespace QuanLyBanHang.View.FrmBanHang
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            groupBox1 = new GroupBox();
            txt_TimKiem = new TextBox();
            cbb_hangSX = new ComboBox();
            cbb_mauSac = new ComboBox();
            cbb_size = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgv_DSSP = new DataGridView();
            groupBox2 = new GroupBox();
            btn_thanhtoanngay = new Button();
            btn_TaoHD = new Button();
            btn_XoaGH = new Button();
            btn_XoaSP = new Button();
            dtgv_gioHang = new DataGridView();
            groupBox3 = new GroupBox();
            cbb_KhachHang = new ComboBox();
            rdb_nu = new RadioButton();
            rdb_nam = new RadioButton();
            lbl_diemTichLuy = new Label();
            btn_ThemKH = new Button();
            txt_SDT = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            btn_huyDon = new Button();
            dtgv_HoadonCho = new DataGridView();
            groupBox5 = new GroupBox();
            btnThanhToan = new Button();
            txt_GhiChu = new TextBox();
            txt_TienThua = new TextBox();
            txt_TongTien = new TextBox();
            txt_khachDua = new TextBox();
            txt_giamGia = new TextBox();
            txt_MaHD = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ppdhd = new PrintPreviewDialog();
            pdhd = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_DSSP).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_gioHang).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_HoadonCho).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TimKiem);
            groupBox1.Controls.Add(cbb_hangSX);
            groupBox1.Controls.Add(cbb_mauSac);
            groupBox1.Controls.Add(cbb_size);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtgv_DSSP);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(953, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRODUCTS";
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(737, 38);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(201, 27);
            txt_TimKiem.TabIndex = 8;
            txt_TimKiem.PlaceholderText = "Searching...";
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged_1;
            // 
            // cbb_hangSX
            // 
            cbb_hangSX.FormattingEnabled = true;
            cbb_hangSX.Location = new Point(139, 38);
            cbb_hangSX.Name = "cbb_hangSX";
            cbb_hangSX.Size = new Size(106, 27);
            cbb_hangSX.TabIndex = 7;
            cbb_hangSX.SelectedIndexChanged += cbb_hangSX_SelectedIndexChanged_1;
            // 
            // cbb_mauSac
            // 
            cbb_mauSac.FormattingEnabled = true;
            cbb_mauSac.Location = new Point(345, 38);
            cbb_mauSac.Name = "cbb_mauSac";
            cbb_mauSac.Size = new Size(106, 27);
            cbb_mauSac.TabIndex = 6;
            cbb_mauSac.SelectedIndexChanged += cbb_mauSac_SelectedIndexChanged_1;
            // 
            // cbb_size
            // 
            cbb_size.FormattingEnabled = true;
            cbb_size.Location = new Point(526, 38);
            cbb_size.Name = "cbb_size";
            cbb_size.Size = new Size(106, 27);
            cbb_size.TabIndex = 5;
            cbb_size.SelectedIndexChanged += cbb_size_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(665, 42);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 4;
            label4.Text = "Search: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 42);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 3;
            label3.Text = "Manufacturer: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 42);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 2;
            label2.Text = "Color: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 42);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 1;
            label1.Text = "Size: ";
            // 
            // dtgv_DSSP
            // 
            dtgv_DSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_DSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_DSSP.Location = new Point(12, 80);
            dtgv_DSSP.Name = "dtgv_DSSP";
            dtgv_DSSP.RowHeadersWidth = 51;
            dtgv_DSSP.RowTemplate.Height = 29;
            dtgv_DSSP.Size = new Size(926, 279);
            dtgv_DSSP.TabIndex = 0;
            dtgv_DSSP.CellClick += dtgv_DSSP_CellClick_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_thanhtoanngay);
            groupBox2.Controls.Add(btn_TaoHD);
            groupBox2.Controls.Add(btn_XoaGH);
            groupBox2.Controls.Add(btn_XoaSP);
            groupBox2.Controls.Add(dtgv_gioHang);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(542, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CART";
            // 
            // btn_thanhtoanngay
            // 
            btn_thanhtoanngay.Location = new Point(388, 255);
            btn_thanhtoanngay.Name = "btn_thanhtoanngay";
            btn_thanhtoanngay.Size = new Size(144, 34);
            btn_thanhtoanngay.TabIndex = 4;
            btn_thanhtoanngay.Text = "Checkout Now";
            btn_thanhtoanngay.UseVisualStyleBackColor = true;
            btn_thanhtoanngay.Click += btn_thanhtoanngay_Click;
            // 
            // btn_TaoHD
            // 
            btn_TaoHD.Location = new Point(260, 255);
            btn_TaoHD.Name = "btn_TaoHD";
            btn_TaoHD.Size = new Size(122, 34);
            btn_TaoHD.TabIndex = 3;
            btn_TaoHD.Text = "Create Order";
            btn_TaoHD.UseVisualStyleBackColor = true;
            btn_TaoHD.Click += btn_TaoHD_Click_1;
            // 
            // btn_XoaGH
            // 
            btn_XoaGH.Location = new Point(138, 255);
            btn_XoaGH.Name = "btn_XoaGH";
            btn_XoaGH.Size = new Size(116, 34);
            btn_XoaGH.TabIndex = 2;
            btn_XoaGH.Text = "Clear Cart";
            btn_XoaGH.UseVisualStyleBackColor = true;
            btn_XoaGH.Click += btn_XoaGH_Click_1;
            // 
            // btn_XoaSP
            // 
            btn_XoaSP.Location = new Point(6, 255);
            btn_XoaSP.Name = "btn_XoaSP";
            btn_XoaSP.Size = new Size(122, 34);
            btn_XoaSP.TabIndex = 1;
            btn_XoaSP.Text = "Remove";
            btn_XoaSP.UseVisualStyleBackColor = true;
            btn_XoaSP.Click += btn_XoaSP_Click_1;
            // 
            // dtgv_gioHang
            // 
            dtgv_gioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_gioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_gioHang.Location = new Point(6, 26);
            dtgv_gioHang.Name = "dtgv_gioHang";
            dtgv_gioHang.RowHeadersWidth = 51;
            dtgv_gioHang.RowTemplate.Height = 29;
            dtgv_gioHang.Size = new Size(526, 208);
            dtgv_gioHang.TabIndex = 0;
            dtgv_gioHang.CellClick += dtgv_gioHang_CellClick_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbb_KhachHang);
            groupBox3.Controls.Add(rdb_nu);
            groupBox3.Controls.Add(rdb_nam);
            groupBox3.Controls.Add(lbl_diemTichLuy);
            groupBox3.Controls.Add(btn_ThemKH);
            groupBox3.Controls.Add(txt_SDT);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(563, 393);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 305);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "CUSTOMER";
            // 
            // cbb_KhachHang
            // 
            cbb_KhachHang.FormattingEnabled = true;
            cbb_KhachHang.Location = new Point(162, 33);
            cbb_KhachHang.Name = "cbb_KhachHang";
            cbb_KhachHang.Size = new Size(225, 27);
            cbb_KhachHang.TabIndex = 14;
            cbb_KhachHang.SelectedIndexChanged += cbb_KhachHang_SelectedIndexChanged_1;
            cbb_KhachHang.TextChanged += cbb_KhachHang_TextChanged_1;
            // 
            // rdb_nu
            // 
            rdb_nu.AutoSize = true;
            rdb_nu.Location = new Point(162, 157);
            rdb_nu.Name = "rdb_nu";
            rdb_nu.Size = new Size(85, 23);
            rdb_nu.TabIndex = 9;
            rdb_nu.TabStop = true;
            rdb_nu.Text = "Female";
            rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            rdb_nam.AutoSize = true;
            rdb_nam.Location = new Point(162, 124);
            rdb_nam.Name = "rdb_nam";
            rdb_nam.Size = new Size(68, 23);
            rdb_nam.TabIndex = 8;
            rdb_nam.TabStop = true;
            rdb_nam.Text = "Male";
            rdb_nam.UseVisualStyleBackColor = true;
            // 
            // lbl_diemTichLuy
            // 
            lbl_diemTichLuy.AutoSize = true;
            lbl_diemTichLuy.Location = new Point(162, 201);
            lbl_diemTichLuy.Name = "lbl_diemTichLuy";
            lbl_diemTichLuy.Size = new Size(21, 19);
            lbl_diemTichLuy.TabIndex = 8;
            lbl_diemTichLuy.Text = "...";
            // 
            // btn_ThemKH
            // 
            btn_ThemKH.Location = new Point(85, 249);
            btn_ThemKH.Name = "btn_ThemKH";
            btn_ThemKH.Size = new Size(231, 40);
            btn_ThemKH.TabIndex = 6;
            btn_ThemKH.Text = "Quick Add Customer";
            btn_ThemKH.UseVisualStyleBackColor = true;
            btn_ThemKH.Click += btn_ThemKH_Click_1;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(162, 77);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(225, 27);
            txt_SDT.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 126);
            label14.Name = "label14";
            label14.Size = new Size(71, 19);
            label14.TabIndex = 3;
            label14.Text = "Gender:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 201);
            label13.Name = "label13";
            label13.Size = new Size(123, 19);
            label13.TabIndex = 2;
            label13.Text = "Loyalty Points:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 80);
            label12.Name = "label12";
            label12.Size = new Size(125, 19);
            label12.TabIndex = 1;
            label12.Text = "Phone Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 38);
            label11.Name = "label11";
            label11.Size = new Size(134, 19);
            label11.TabIndex = 0;
            label11.Text = "Customer Name:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_huyDon);
            groupBox4.Controls.Add(dtgv_HoadonCho);
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(973, 393);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(329, 305);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "PENDING ORDERS";
            // 
            // btn_huyDon
            // 
            btn_huyDon.BackColor = Color.FromArgb(220, 53, 69);
            btn_huyDon.Cursor = Cursors.Hand;
            btn_huyDon.FlatAppearance.BorderSize = 0;
            btn_huyDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(165, 28, 41);
            btn_huyDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            btn_huyDon.FlatStyle = FlatStyle.Flat;
            btn_huyDon.ForeColor = Color.White;
            btn_huyDon.Location = new Point(79, 249);
            btn_huyDon.Name = "btn_huyDon";
            btn_huyDon.Size = new Size(182, 40);
            btn_huyDon.TabIndex = 5;
            btn_huyDon.Text = "CANCEL ORDER";
            btn_huyDon.UseVisualStyleBackColor = false;
            btn_huyDon.Click += btn_huyDon_Click;
            // 
            // dtgv_HoadonCho
            // 
            dtgv_HoadonCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_HoadonCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_HoadonCho.Location = new Point(9, 26);
            dtgv_HoadonCho.Name = "dtgv_HoadonCho";
            dtgv_HoadonCho.RowHeadersWidth = 51;
            dtgv_HoadonCho.RowTemplate.Height = 29;
            dtgv_HoadonCho.Size = new Size(306, 208);
            dtgv_HoadonCho.TabIndex = 0;
            dtgv_HoadonCho.CellClick += dtgv_HoadonCho_CellClick_1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnThanhToan);
            groupBox5.Controls.Add(txt_GhiChu);
            groupBox5.Controls.Add(txt_TienThua);
            groupBox5.Controls.Add(txt_TongTien);
            groupBox5.Controls.Add(txt_khachDua);
            groupBox5.Controls.Add(txt_giamGia);
            groupBox5.Controls.Add(txt_MaHD);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(973, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(329, 375);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "PAYMENT";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(40, 167, 69);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 111, 46);
            btnThanhToan.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(79, 319);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(182, 40);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "PAY NOW";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click_1;
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new Point(126, 248);
            txt_GhiChu.Multiline = true;
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new Size(182, 57);
            txt_GhiChu.TabIndex = 11;
            // 
            // txt_TienThua
            // 
            txt_TienThua.Enabled = false;
            txt_TienThua.Location = new Point(126, 202);
            txt_TienThua.Name = "txt_TienThua";
            txt_TienThua.Size = new Size(182, 27);
            txt_TienThua.TabIndex = 10;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Enabled = false;
            txt_TongTien.Location = new Point(126, 158);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(182, 27);
            txt_TongTien.TabIndex = 9;
            // 
            // txt_khachDua
            // 
            txt_khachDua.Location = new Point(126, 75);
            txt_khachDua.Name = "txt_khachDua";
            txt_khachDua.Size = new Size(182, 27);
            txt_khachDua.TabIndex = 8;
            txt_khachDua.TextChanged += txt_khachDua_TextChanged_1;
            // 
            // txt_giamGia
            // 
            txt_giamGia.Location = new Point(126, 115);
            txt_giamGia.Name = "txt_giamGia";
            txt_giamGia.Size = new Size(182, 27);
            txt_giamGia.TabIndex = 7;
            txt_giamGia.TextChanged += txt_giamGia_TextChanged_1;
            // 
            // txt_MaHD
            // 
            txt_MaHD.Enabled = false;
            txt_MaHD.Location = new Point(126, 30);
            txt_MaHD.Name = "txt_MaHD";
            txt_MaHD.Size = new Size(182, 27);
            txt_MaHD.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 252);
            label10.Name = "label10";
            label10.Size = new Size(57, 19);
            label10.TabIndex = 5;
            label10.Text = "Notes:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 206);
            label9.Name = "label9";
            label9.Size = new Size(103, 19);
            label9.TabIndex = 4;
            label9.Text = "Change Due:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 162);
            label8.Name = "label8";
            label8.Size = new Size(52, 19);
            label8.TabIndex = 3;
            label8.Text = "Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 79);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 2;
            label7.Text = "Amount Paid:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 119);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 1;
            label6.Text = "Discount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 34);
            label5.Name = "label5";
            label5.Size = new Size(111, 19);
            label5.TabIndex = 0;
            label5.Text = "Invoice Code:";
            // 
            // ppdhd
            // 
            ppdhd.AutoScrollMargin = new Size(0, 0);
            ppdhd.AutoScrollMinSize = new Size(0, 0);
            ppdhd.ClientSize = new Size(400, 300);
            ppdhd.Enabled = true;
            ppdhd.Icon = (Icon)resources.GetObject("ppdhd.Icon");
            ppdhd.Name = "ppdhd";
            ppdhd.Visible = false;
            // 
            // pdhd
            // 
            pdhd.PrintPage += pdhd_PrintPage;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 717);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormBanHang";
            Text = "FormBanHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_DSSP).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_gioHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_HoadonCho).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView dtgv_DSSP;
        private DataGridView dtgv_gioHang;
        private DataGridView dtgv_HoadonCho;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cbb_size;
        private ComboBox cbb_mauSac;
        private ComboBox cbb_hangSX;
        private TextBox txt_TimKiem;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_TienThua;
        private TextBox txt_TongTien;
        private TextBox txt_khachDua;
        private TextBox txt_giamGia;
        private TextBox txt_MaHD;
        private TextBox txt_GhiChu;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btn_ThanhToan;
        private RadioButton rdb_nu;
        private RadioButton rdb_nam;
        private TextBox txt_SDT;
        private Button btn_ThemKH;
        private Button btn_TaoHD;
        private Button btn_XoaGH;
        private Button btn_XoaSP;
        //private Button btn_ThanhToan;
        private Label lbl_diemTichLuy;
        private Button btnThanhToan;
        private ComboBox cbb_KhachHang;
        private Button btn_thanhtoanngay;
        private PrintPreviewDialog ppdhd;
        private System.Drawing.Printing.PrintDocument pdhd;
        private Button btn_huyDon;
    }
}