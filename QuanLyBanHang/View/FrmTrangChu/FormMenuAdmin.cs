using QuanLyBanHang.View.FrmBanHang;
using QuanLyBanHang.View.FrmChatLieu;
using QuanLyBanHang.View.FrmDangNhap;
using QuanLyBanHang.View.FrmHangSanXuat;
using QuanLyBanHang.View.FrmHoaDon;
using QuanLyBanHang.View.FrmKhachHang;
using QuanLyBanHang.View.FrmLoaiSP;
using QuanLyBanHang.View.FrmMauSac;
using QuanLyBanHang.View.FrmNhaCungCap;
using QuanLyBanHang.View.FrmNhanVien;
using QuanLyBanHang.View.FrmSanPham;
using QuanLyBanHang.View.FrmSize;

namespace QuanLyBanHang.View.FrmTrangChu
{
    public partial class FormMenuAdmin : Form
    {
        private FormDangNhap _formDangNhap;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMenuAdmin(FormDangNhap formDangNhap)
        {
            _formDangNhap = formDangNhap;
            _formDangNhap.Hide();
            InitializeComponent();
            random = new Random();
            button1.Visible = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnl_Home.BackColor = color;
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    button1.Visible = true;
                }
            }
        }
        public void FormNhanVien()
        {
            btn_NhanVien.Enabled = false;
            btn_ThongKe.Enabled = false;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnl_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_ManChinh.Controls.Add(childForm);
            this.pnl_ManChinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lb_home.Text = childForm.Text;
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(), sender);
            lbl_Home.Text = btn_BanHang.Text;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham(), sender);
            lbl_Home.Text = btn_SanPham.Text;
        }

        private void btn_loaiSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLoaiSP(), sender);
            lbl_Home.Text = btn_loaiSP.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lbl_Home.Text = "Hello, [Name]! Wishing you a productive day.";
            currentButton = null;
            button1.Visible = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                _formDangNhap.Show();
            }
            else
            {
                
            }
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhaCungCap(), sender);
            lbl_Home.Text = btn_NhaCungCap.Text;
        }

        private void btn_HangSanXuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHangSX(), sender);
            lbl_Home.Text = btn_HangSanXuat.Text;
        }

        private void btn_ChatLieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChatLieu(), sender);
            lbl_Home.Text = btn_ChatLieu.Text;
        }

        private void btn_MauSac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMauSac(), sender);
            lbl_Home.Text = btn_MauSac.Text;
        }

        private void btn_Size_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSize(), sender);
            lbl_Home.Text = btn_Size.Text;
        }

        private void btn_DanhMucHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhMucHD(), sender);
            lbl_Home.Text = btn_DanhMucHD.Text;
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien(), sender);
            lbl_Home.Text = btn_NhanVien.Text;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe(), sender);
            lbl_Home.Text = btn_ThongKe.Text;
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang(), sender);
            lbl_Home.Text = btn_khachHang.Text;
        }
    }
}
