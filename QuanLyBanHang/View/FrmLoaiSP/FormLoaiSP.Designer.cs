namespace QuanLyBanHang.View.FrmLoaiSP
{
    partial class FormLoaiSP
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
            label1 = new Label();
            groupBox3 = new GroupBox();
            dtgv_LoaiSP = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btn_Sua = new Button();
            btn_Them = new Button();
            groupBox1 = new GroupBox();
            rdb_hetHang = new RadioButton();
            rdb_conHang = new RadioButton();
            txt_TenLoaiSP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_LoaiSP).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 102);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgv_LoaiSP);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(13, 210);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(881, 295);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dtgv_LoaiSP
            // 
            dtgv_LoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_LoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_LoaiSP.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dtgv_LoaiSP.Location = new Point(8, 25);
            dtgv_LoaiSP.Margin = new Padding(4, 3, 4, 3);
            dtgv_LoaiSP.Name = "dtgv_LoaiSP";
            dtgv_LoaiSP.RowHeadersWidth = 51;
            dtgv_LoaiSP.RowTemplate.Height = 29;
            dtgv_LoaiSP.Size = new Size(866, 254);
            dtgv_LoaiSP.TabIndex = 0;
            dtgv_LoaiSP.CellClick += dtgv_LoaiSP_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Loại SP";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên SP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Trạng thái";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(616, 12);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(279, 192);
            groupBox2.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_hetHang);
            groupBox1.Controls.Add(rdb_conHang);
            groupBox1.Controls.Add(txt_TenLoaiSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(595, 192);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại sản phẩm";
            // 
            // rdb_hetHang
            // 
            rdb_hetHang.AutoSize = true;
            rdb_hetHang.Location = new Point(365, 98);
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
            rdb_conHang.Location = new Point(191, 98);
            rdb_conHang.Margin = new Padding(4, 3, 4, 3);
            rdb_conHang.Name = "rdb_conHang";
            rdb_conHang.Size = new Size(99, 23);
            rdb_conHang.TabIndex = 3;
            rdb_conHang.TabStop = true;
            rdb_conHang.Text = "Còn hàng";
            rdb_conHang.UseVisualStyleBackColor = true;
            // 
            // txt_TenLoaiSP
            // 
            txt_TenLoaiSP.Location = new Point(190, 46);
            txt_TenLoaiSP.Margin = new Padding(4, 3, 4, 3);
            txt_TenLoaiSP.Name = "txt_TenLoaiSP";
            txt_TenLoaiSP.Size = new Size(320, 27);
            txt_TenLoaiSP.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 0;
            label3.Text = "Tên loại SP:";
            // 
            // FormLoaiSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 546);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormLoaiSP";
            Text = "FormLoaiSP";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_LoaiSP).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dtgv_LoaiSP;
        private GroupBox groupBox2;
        private Button btn_Sua;
        private Button btn_Them;
        private GroupBox groupBox1;
        private RadioButton rdb_hetHang;
        private RadioButton rdb_conHang;
        private TextBox txt_TenLoaiSP;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}