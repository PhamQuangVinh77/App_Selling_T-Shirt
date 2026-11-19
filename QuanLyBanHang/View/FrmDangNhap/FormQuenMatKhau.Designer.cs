namespace QuanLyBanHang.View.FrmDangNhap
{
    partial class FormQuenMatKhau
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
            button1 = new Button();
            btn_submit = new Button();
            txt_otp = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btn_Send = new Button();
            label2 = new Label();
            txt_Email = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_submit);
            panel1.Controls.Add(txt_otp);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Send);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Email);
            panel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(45, 38);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 249);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(321, 184);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(181, 37);
            button1.TabIndex = 8;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_submit.Location = new Point(116, 184);
            btn_submit.Margin = new Padding(4, 3, 4, 3);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(181, 37);
            btn_submit.TabIndex = 7;
            btn_submit.Text = "Confirm";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // txt_otp
            // 
            txt_otp.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_otp.Location = new Point(116, 117);
            txt_otp.Margin = new Padding(4, 3, 4, 3);
            txt_otp.Name = "txt_otp";
            txt_otp.Size = new Size(386, 27);
            txt_otp.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 5;
            label3.Text = "OTP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(129, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter your email to receive the OTP";
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Send.Location = new Point(535, 60);
            btn_Send.Margin = new Padding(4, 3, 4, 3);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(134, 28);
            btn_Send.TabIndex = 2;
            btn_Send.Text = "SEND OTP";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 4;
            label2.Text = "Email:";
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Email.Location = new Point(116, 61);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(386, 27);
            txt_Email.TabIndex = 1;
            // 
            // FormQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 326);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormQuenMatKhau";
            Text = "Forgot Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_submit;
        private TextBox txt_otp;
        private Label label3;
        private Label label1;
        private Button btn_Send;
        private Label label2;
        private TextBox txt_Email;
        private Button button1;
    }
}