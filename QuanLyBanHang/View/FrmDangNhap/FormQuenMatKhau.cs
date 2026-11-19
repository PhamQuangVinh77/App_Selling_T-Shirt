using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using System.Net;
using System.Net.Mail;

namespace QuanLyBanHang.View.FrmDangNhap
{
    public partial class FormQuenMatKhau : Form
    {
        private IQLnhanVienServices qLnhanVienServices;
        Random random = new Random();
        int otp;
        public FormQuenMatKhau()
        {
            InitializeComponent();
            qLnhanVienServices = new QLnhanVienServices();
            this.CenterToScreen();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                var listNhanVien = qLnhanVienServices.GetNhanVienFromDB();

                if (txt_Email.Text == "")
                {
                    MessageBox.Show("Enter your email to receive the OTP.");
                }
                else if (listNhanVien.FindIndex(x => x.nhanViens.email == txt_Email.Text) == -1)
                {
                    MessageBox.Show("Email does not exist!");
                }
                else
                {
                    otp = random.Next(100000, 1000000);
                    var fromEmail = new MailAddress(listNhanVien.FirstOrDefault(x => x.chucVus.tenCV == "Manager").nhanViens.email);
                    var toEmail = new MailAddress(txt_Email.Text);
                    const string pass = "ovyjzjadxgfskvsd";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromEmail.Address, pass),
                        Timeout = 200000,
                    };

                    string staffName = listNhanVien.FirstOrDefault(x => x.nhanViens.email == txt_Email.Text).nhanViens.tenNV;
                    using (var message = new MailMessage(fromEmail, toEmail)
                    {
                        Subject = "OTP Verification - Password Reset",
                        Body = $"Hi {staffName},\n\n" +
                               $"Your OTP code to reset your password is: {otp}\n" +
                               $"Please enter this code within 5 minutes to complete the verification.\n\n" +
                               $"If you didn't request this, you can ignore this message.\n\n" +
                               $"Have a great day,\n" +
                               $"Manager"
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("OTP has been sent to your email!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (otp == null)
            {
                MessageBox.Show("OTP has not been generated!");
            }
            else if (txt_otp.Text == "")
            {
                MessageBox.Show("Please enter the OTP!");
            }
            else
            {
                if (txt_otp.Text == otp.ToString())
                {
                    this.Close();
                    FormDoiMatKhau frm = new FormDoiMatKhau(txt_Email.Text);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("OTP is incorrect!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap frm = new FormDangNhap();
            frm.Show();
        }
    }
}
