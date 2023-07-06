namespace QuanLyBanHang.View.FrmHoaDon
{
    partial class FormHoaDon
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
            dtgv_HoaDon = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            txt_TimKiem = new TextBox();
            btn_TimKiem = new Button();
            groupBox2 = new GroupBox();
            dtgv_CTHD = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_HoaDon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_CTHD).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgv_HoaDon);
            groupBox1.Controls.Add(txt_TimKiem);
            groupBox1.Controls.Add(btn_TimKiem);
            groupBox1.Location = new Point(15, 11);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1341, 318);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // dtgv_HoaDon
            // 
            dtgv_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_HoaDon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dtgv_HoaDon.Location = new Point(8, 49);
            dtgv_HoaDon.Margin = new Padding(4, 3, 4, 3);
            dtgv_HoaDon.Name = "dtgv_HoaDon";
            dtgv_HoaDon.RowHeadersWidth = 51;
            dtgv_HoaDon.RowTemplate.Height = 29;
            dtgv_HoaDon.Size = new Size(1326, 263);
            dtgv_HoaDon.TabIndex = 2;
            dtgv_HoaDon.CellClick += dtgv_HoaDon_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hóa đơn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã nhân viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Sdt khách hàng";
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
            Column5.HeaderText = "Ngày bán ";
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
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(918, 16);
            txt_TimKiem.Margin = new Padding(4, 3, 4, 3);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.PlaceholderText = "Tìm kiếm ở đây ...";
            txt_TimKiem.Size = new Size(290, 27);
            txt_TimKiem.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(1216, 16);
            btn_TimKiem.Margin = new Padding(4, 3, 4, 3);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(118, 28);
            btn_TimKiem.TabIndex = 0;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgv_CTHD);
            groupBox2.Location = new Point(15, 347);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(1341, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtgv_CTHD
            // 
            dtgv_CTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_CTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_CTHD.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column11, Column12 });
            dtgv_CTHD.Location = new Point(8, 25);
            dtgv_CTHD.Margin = new Padding(4, 3, 4, 3);
            dtgv_CTHD.Name = "dtgv_CTHD";
            dtgv_CTHD.RowHeadersWidth = 51;
            dtgv_CTHD.RowTemplate.Height = 29;
            dtgv_CTHD.Size = new Size(1326, 303);
            dtgv_CTHD.TabIndex = 3;
            // 
            // Column9
            // 
            Column9.HeaderText = "Mã sản phẩm";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Tên sản phẩm";
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
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1845, 692);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_HoaDon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_CTHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
        private DataGridView dtgv_HoaDon;
        private DataGridView dtgv_CTHD;
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
    }
}