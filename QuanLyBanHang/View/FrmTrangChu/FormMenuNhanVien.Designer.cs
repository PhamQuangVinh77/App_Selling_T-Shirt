namespace QuanLyBanHang.View.FrmTrangChu
{
    partial class FormMenuNhanVien
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
            panel1 = new Panel();
            pnl_Home = new Panel();
            lbl_Home = new Label();
            btn_X = new Button();
            pnl_ManChinh = new Panel();
            pnl_Menu = new Panel();
            pictureBox1 = new PictureBox();
            btn_Thoat = new Button();
            btn_HoaDon = new Button();
            btn_BanHang = new Button();
            btn_TrangChu = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            pnl_Home.SuspendLayout();
            pnl_ManChinh.SuspendLayout();
            pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnl_Home);
            panel1.Controls.Add(pnl_ManChinh);
            panel1.Controls.Add(pnl_Menu);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1864, 882);
            panel1.TabIndex = 2;
            // 
            // pnl_Home
            // 
            pnl_Home.BackColor = Color.FromArgb(224, 224, 224);
            pnl_Home.Controls.Add(lbl_Home);
            pnl_Home.Controls.Add(btn_X);
            pnl_Home.Location = new Point(205, 6);
            pnl_Home.Name = "pnl_Home";
            pnl_Home.Size = new Size(1652, 67);
            pnl_Home.TabIndex = 0;
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Home.ForeColor = Color.Black;
            lbl_Home.Location = new Point(393, 17);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(671, 42);
            lbl_Home.TabIndex = 1;
            lbl_Home.Text = "Chào Mừng Bạn Đến Với FPOLY  T-SHIRT";
            // 
            // btn_X
            // 
            btn_X.BackColor = Color.FromArgb(224, 224, 224);
            btn_X.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_X.ForeColor = SystemColors.ActiveCaptionText;
            btn_X.Location = new Point(1597, 17);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(40, 39);
            btn_X.TabIndex = 0;
            btn_X.Text = "X";
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += btn_X_Click;
            // 
            // pnl_ManChinh
            // 
            pnl_ManChinh.Controls.Add(pictureBox2);
            pnl_ManChinh.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            pnl_ManChinh.Location = new Point(206, 79);
            pnl_ManChinh.Margin = new Padding(4, 3, 4, 3);
            pnl_ManChinh.Name = "pnl_ManChinh";
            pnl_ManChinh.Size = new Size(1651, 796);
            pnl_ManChinh.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            pnl_Menu.BackColor = Color.FromArgb(224, 224, 224);
            pnl_Menu.Controls.Add(pictureBox1);
            pnl_Menu.Controls.Add(btn_Thoat);
            pnl_Menu.Controls.Add(btn_HoaDon);
            pnl_Menu.Controls.Add(btn_BanHang);
            pnl_Menu.Controls.Add(btn_TrangChu);
            pnl_Menu.Location = new Point(3, 3);
            pnl_Menu.Name = "pnl_Menu";
            pnl_Menu.Size = new Size(196, 872);
            pnl_Menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_logo_on_selling_t_shirts_png_image_4357278;
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Thoat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Thoat.Location = new Point(6, 816);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(185, 42);
            btn_Thoat.TabIndex = 2;
            btn_Thoat.Text = "THOÁT";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_HoaDon
            // 
            btn_HoaDon.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_HoaDon.Image = Properties.Resources.icons8_paid_bill_32;
            btn_HoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HoaDon.Location = new Point(6, 247);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Size = new Size(185, 42);
            btn_HoaDon.TabIndex = 2;
            btn_HoaDon.Text = "HÓA ĐƠN";
            btn_HoaDon.UseVisualStyleBackColor = true;
            btn_HoaDon.Click += btn_HoaDon_Click;
            // 
            // btn_BanHang
            // 
            btn_BanHang.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BanHang.Image = Properties.Resources.icons8_add_shopping_cart_30;
            btn_BanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_BanHang.Location = new Point(6, 199);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(185, 42);
            btn_BanHang.TabIndex = 2;
            btn_BanHang.Text = "BÁN HÀNG";
            btn_BanHang.UseVisualStyleBackColor = true;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // btn_TrangChu
            // 
            btn_TrangChu.BackColor = Color.White;
            btn_TrangChu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TrangChu.Image = Properties.Resources.icons8_home_page_32;
            btn_TrangChu.ImageAlign = ContentAlignment.TopLeft;
            btn_TrangChu.Location = new Point(6, 151);
            btn_TrangChu.Name = "btn_TrangChu";
            btn_TrangChu.Size = new Size(185, 42);
            btn_TrangChu.TabIndex = 1;
            btn_TrangChu.Text = "TRANG CHỦ";
            btn_TrangChu.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.background;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1648, 793);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormMenuNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 903);
            Controls.Add(panel1);
            Name = "FormMenuNhanVien";
            Text = "FormMenuNhanVien";
            panel1.ResumeLayout(false);
            pnl_Home.ResumeLayout(false);
            pnl_Home.PerformLayout();
            pnl_ManChinh.ResumeLayout(false);
            pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnl_Home;
        private Label lbl_Home;
        private Button btn_X;
        private Panel pnl_ManChinh;
        private Panel pnl_Menu;
        private PictureBox pictureBox1;
        private Button btn_Thoat;
        private Button btn_HoaDon;
        private Button btn_BanHang;
        private Button btn_TrangChu;
        private PictureBox pictureBox2;
    }
}