﻿namespace QuanLyBanHang.View.FrmHangSanXuat
{
    partial class FormHangSX
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
            groupBox3 = new GroupBox();
            dtgv_HangSX = new DataGridView();
            groupBox1 = new GroupBox();
            rdb_hetHang = new RadioButton();
            rdb_conHang = new RadioButton();
            txt_TenHangSX = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Sua = new Button();
            btn_Them = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_HangSX).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_HangSX);
            groupBox3.Location = new Point(15, 209);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(881, 295);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dtgv_HangSX
            // 
            dtgv_HangSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_HangSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_HangSX.Location = new Point(8, 25);
            dtgv_HangSX.Margin = new Padding(4, 3, 4, 3);
            dtgv_HangSX.Name = "dtgv_HangSX";
            dtgv_HangSX.RowHeadersWidth = 51;
            dtgv_HangSX.RowTemplate.Height = 29;
            dtgv_HangSX.Size = new Size(866, 254);
            dtgv_HangSX.TabIndex = 0;
            dtgv_HangSX.CellClick += dtgv_HangSX_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_hetHang);
            groupBox1.Controls.Add(rdb_conHang);
            groupBox1.Controls.Add(txt_TenHangSX);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 11);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(595, 192);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hãng sản xuất";
            // 
            // rdb_hetHang
            // 
            rdb_hetHang.AutoSize = true;
            rdb_hetHang.Location = new Point(400, 98);
            rdb_hetHang.Margin = new Padding(4, 3, 4, 3);
            rdb_hetHang.Name = "rdb_hetHang";
            rdb_hetHang.Size = new Size(96, 23);
            rdb_hetHang.TabIndex = 4;
            rdb_hetHang.TabStop = true;
            rdb_hetHang.Text = "Hết hàng";
            rdb_hetHang.UseVisualStyleBackColor = true;
            // 
            // rdb_conHang
            // 
            rdb_conHang.AutoSize = true;
            rdb_conHang.Location = new Point(246, 98);
            rdb_conHang.Margin = new Padding(4, 3, 4, 3);
            rdb_conHang.Name = "rdb_conHang";
            rdb_conHang.Size = new Size(99, 23);
            rdb_conHang.TabIndex = 3;
            rdb_conHang.TabStop = true;
            rdb_conHang.Text = "Còn hàng";
            rdb_conHang.UseVisualStyleBackColor = true;
            // 
            // txt_TenHangSX
            // 
            txt_TenHangSX.Location = new Point(246, 46);
            txt_TenHangSX.Margin = new Padding(4, 3, 4, 3);
            txt_TenHangSX.Name = "txt_TenHangSX";
            txt_TenHangSX.Size = new Size(320, 27);
            txt_TenHangSX.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên hãng sản xuất :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Location = new Point(618, 11);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(279, 192);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(52, 112);
            btn_Sua.Margin = new Padding(4, 3, 4, 3);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(181, 39);
            btn_Sua.TabIndex = 1;
            btn_Sua.Text = "CẬP NHẬP";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(52, 48);
            btn_Them.Margin = new Padding(4, 3, 4, 3);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(181, 39);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "THÊM";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // FormHangSX
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 560);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormHangSX";
            Text = "FormHangSX";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_HangSX).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dtgv_HangSX;
        private GroupBox groupBox1;
        private RadioButton rdb_hetHang;
        private RadioButton rdb_conHang;
        private TextBox txt_TenHangSX;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_Sua;
        private Button btn_Them;
    }
}