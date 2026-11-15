using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (txt_Email.Text == "")
                {
                    MessageBox.Show("Enter your email to receive the OTP.");
                }
                else if (qLnhanVienServices.GetNhanVienFromDB().FindIndex(x => x.nhanViens.email == txt_Email.Text) == -1)
                {
                    MessageBox.Show("Email does not exist!");
                }
                else
                {
                    otp = random.Next(100000, 1000000);
                    var fromEmail = new MailAddress(qLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(x => x.chucVus.tenCV == "Manager").nhanViens.email);
                    var toEmail = new MailAddress(txt_Email.Text);
                    const string pass = "ixnlzhmqsnoyborm";

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
                    using (var message = new MailMessage(fromEmail, toEmail)
                    {
                        Subject = "OTP Verification",
                        Body = "Your OTP is: " + otp.ToString()
                        + ", please verify to change your password.",
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
                    FormDoiMatKhau frm = new FormDoiMatKhau(txt_Email.Text);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("OTP is incorrect!");
                }
            }
        }
    }
}
