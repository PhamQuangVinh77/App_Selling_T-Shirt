using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;

namespace QuanLyBanHang.View.FrmDangNhap
{
    public partial class FormDoiMatKhau : Form
    {
        private IQLnhanVienServices qLnhanVienServices;
        private string email;
        public FormDoiMatKhau(string emailDoiMK)
        {
            InitializeComponent();
            qLnhanVienServices = new QLnhanVienServices();
            this.CenterToScreen();
            email = emailDoiMK;
        }

        private void btn_doiMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_matKhauMoi.Text == "" || txt_xacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Please fill out all fields!");
            }
            else if (txt_xacNhanMatKhau.Text != txt_matKhauMoi.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            else
            {
                var nv = qLnhanVienServices.GetNhanVienFromDB().FirstOrDefault(x => x.nhanViens.email == email);
                nv.nhanViens.matKhau = txt_matKhauMoi.Text;
                qLnhanVienServices.UpdateNhanVien(nv);
                MessageBox.Show("Password changed successfully!");
                this.Hide();
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.ShowDialog();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cb_hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienMatKhau.Checked == true)
            {
                txt_matKhauMoi.UseSystemPasswordChar = false;
                txt_xacNhanMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matKhauMoi.UseSystemPasswordChar = true;
                txt_xacNhanMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
