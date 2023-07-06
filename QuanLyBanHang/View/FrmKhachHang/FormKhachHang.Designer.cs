namespace QuanLyBanHang.View.FrmKhachHang
{
    partial class FormKhachHang
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
            rdb_Nu = new RadioButton();
            rdb_Nam = new RadioButton();
            txt_diaChi = new TextBox();
            txt_Sdt = new TextBox();
            groupBox3 = new GroupBox();
            btn_update = new Button();
            btn_Them = new Button();
            txt_TenKH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgv_khachHang = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_khachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_Nu);
            groupBox1.Controls.Add(rdb_Nam);
            groupBox1.Controls.Add(txt_diaChi);
            groupBox1.Controls.Add(txt_Sdt);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txt_TenKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // rdb_Nu
            // 
            rdb_Nu.AutoSize = true;
            rdb_Nu.Location = new Point(270, 137);
            rdb_Nu.Name = "rdb_Nu";
            rdb_Nu.Size = new Size(52, 23);
            rdb_Nu.TabIndex = 9;
            rdb_Nu.TabStop = true;
            rdb_Nu.Text = "Nữ";
            rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_Nam
            // 
            rdb_Nam.AutoSize = true;
            rdb_Nam.Location = new Point(148, 137);
            rdb_Nam.Name = "rdb_Nam";
            rdb_Nam.Size = new Size(64, 23);
            rdb_Nam.TabIndex = 8;
            rdb_Nam.TabStop = true;
            rdb_Nam.Text = "Nam";
            rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_diaChi
            // 
            txt_diaChi.Location = new Point(148, 185);
            txt_diaChi.Name = "txt_diaChi";
            txt_diaChi.Size = new Size(240, 27);
            txt_diaChi.TabIndex = 7;
            // 
            // txt_Sdt
            // 
            txt_Sdt.Location = new Point(148, 89);
            txt_Sdt.Name = "txt_Sdt";
            txt_Sdt.Size = new Size(240, 27);
            txt_Sdt.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_update);
            groupBox3.Controls.Add(btn_Them);
            groupBox3.Location = new Point(512, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(202, 221);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(33, 111);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(135, 45);
            btn_update.TabIndex = 1;
            btn_update.Text = "CẬP NHẬP";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(33, 41);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(135, 45);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "THÊM";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // txt_TenKH
            // 
            txt_TenKH.Location = new Point(148, 43);
            txt_TenKH.Name = "txt_TenKH";
            txt_TenKH.Size = new Size(240, 27);
            txt_TenKH.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 137);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 2;
            label3.Text = "Giới tính :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 92);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 46);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgv_khachHang);
            groupBox2.Location = new Point(12, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(757, 321);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // dtgv_khachHang
            // 
            dtgv_khachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_khachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_khachHang.Location = new Point(6, 26);
            dtgv_khachHang.Name = "dtgv_khachHang";
            dtgv_khachHang.RowHeadersWidth = 51;
            dtgv_khachHang.RowTemplate.Height = 29;
            dtgv_khachHang.Size = new Size(745, 289);
            dtgv_khachHang.TabIndex = 0;
            dtgv_khachHang.CellClick += dtgv_khachHang_CellClick;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 679);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_khachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgv_khachHang;
        private GroupBox groupBox3;
        private TextBox txt_TenKH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdb_Nu;
        private RadioButton rdb_Nam;
        private TextBox txt_diaChi;
        private TextBox txt_Sdt;
        private Button btn_update;
        private Button btn_Them;
    }
}