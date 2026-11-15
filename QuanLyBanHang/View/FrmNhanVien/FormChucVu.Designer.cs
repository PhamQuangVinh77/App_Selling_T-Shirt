namespace QuanLyBanHang.View.FrmNhanVien
{
    partial class FormChucVu
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
            tb_tencv = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btn_Sua = new Button();
            btn_Them = new Button();
            groupBox3 = new GroupBox();
            dtg_show = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_tencv);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 102);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "POSITIONS";
            // 
            // tb_tencv
            // 
            tb_tencv.Location = new Point(132, 44);
            tb_tencv.Name = "tb_tencv";
            tb_tencv.Size = new Size(211, 27);
            tb_tencv.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 47);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 1;
            label2.Text = "Position";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(408, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 102);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "ACTIONS";
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(177, 28);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(139, 57);
            btn_Sua.TabIndex = 39;
            btn_Sua.Text = "UPDATE";
            btn_Sua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(17, 28);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(145, 57);
            btn_Them.TabIndex = 38;
            btn_Them.Text = "ADD NEW";
            btn_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtg_show);
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(30, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(713, 330);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "DETAILS";
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(3, 23);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(704, 301);
            dtg_show.TabIndex = 0;
            // 
            // FormChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormChucVu";
            Text = "FormChucVu";
            Load += FormChucVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_tencv;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_Sua;
        private Button btn_Them;
        private GroupBox groupBox3;
        private DataGridView dtg_show;
    }
}