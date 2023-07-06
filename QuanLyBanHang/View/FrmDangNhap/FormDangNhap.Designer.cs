namespace QuanLyBanHang.View.FrmDangNhap
{
    partial class FormDangNhap
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btn_dangNhap = new Button();
            llForgotpassword = new LinkLabel();
            txt_taiKhoan = new TextBox();
            txt_matKhau = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_dangNhap);
            panel1.Controls.Add(llForgotpassword);
            panel1.Controls.Add(txt_taiKhoan);
            panel1.Controls.Add(txt_matKhau);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(97, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 324);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 153);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 9;
            label2.Text = "MẬT KHẨU :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 104);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 8;
            label1.Text = "TÀI KHOẢN : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(148, 26);
            label3.Name = "label3";
            label3.Size = new Size(305, 42);
            label3.TabIndex = 4;
            label3.Text = "LOGIN SYSTEM";
            // 
            // btn_dangNhap
            // 
            btn_dangNhap.BackColor = Color.Turquoise;
            btn_dangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangNhap.Image = Properties.Resources.icons8_login_32;
            btn_dangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangNhap.Location = new Point(216, 234);
            btn_dangNhap.Name = "btn_dangNhap";
            btn_dangNhap.Size = new Size(170, 49);
            btn_dangNhap.TabIndex = 5;
            btn_dangNhap.Text = "ĐĂNG NHẬP";
            btn_dangNhap.TextAlign = ContentAlignment.MiddleRight;
            btn_dangNhap.UseVisualStyleBackColor = false;
            btn_dangNhap.Click += btn_dangNhap_Click;
            // 
            // llForgotpassword
            // 
            llForgotpassword.AutoSize = true;
            llForgotpassword.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            llForgotpassword.LinkColor = Color.FromArgb(128, 128, 255);
            llForgotpassword.Location = new Point(350, 186);
            llForgotpassword.Name = "llForgotpassword";
            llForgotpassword.Size = new Size(142, 22);
            llForgotpassword.TabIndex = 7;
            llForgotpassword.TabStop = true;
            llForgotpassword.Text = "Quên mật khẩu?";
            llForgotpassword.LinkClicked += llForgotpassword_LinkClicked;
            // 
            // txt_taiKhoan
            // 
            txt_taiKhoan.Location = new Point(168, 101);
            txt_taiKhoan.Name = "txt_taiKhoan";
            txt_taiKhoan.Size = new Size(325, 30);
            txt_taiKhoan.TabIndex = 1;
            // 
            // txt_matKhau
            // 
            txt_matKhau.Location = new Point(168, 150);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.PasswordChar = '*';
            txt_matKhau.Size = new Size(324, 30);
            txt_matKhau.TabIndex = 3;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btn_dangNhap;
        private LinkLabel llForgotpassword;
        private TextBox txt_taiKhoan;
        private TextBox txt_matKhau;
    }
}