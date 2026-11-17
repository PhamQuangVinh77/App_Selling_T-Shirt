using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using QuanLyBanHang.View.FrmBanHang;
using QuanLyBanHang.View.FrmDangNhap;
using QuanLyBanHang.View.FrmHoaDon;

namespace QuanLyBanHang.View.FrmTrangChu
{
    public partial class FormMenuNhanVien : Form
    {
        private FormDangNhap _formDangNhap;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private IQLnhanVienServices _qLnhanVien;
        public FormMenuNhanVien(FormDangNhap formDangNhap)
        {
            _qLnhanVien = new QLnhanVienServices();
            _formDangNhap = formDangNhap;
            _formDangNhap.Hide();
            InitializeComponent();
            random = new Random();
            btn_X.Visible = false;
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Reset();
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
                    btn_X.Visible = true;
                }
            }
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

        private void btn_X_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            string staffName = _qLnhanVien.GetNhanVienFromDB().
                    FirstOrDefault(x => x.nhanViens.email == Properties.Settings.Default.email).nhanViens.tenNV;
            lbl_Home.Text = $"Hello, {staffName}! Wishing you a productive day.";
            currentButton = null;
            btn_X.Visible = false;
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

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(), sender);
            lbl_Home.Text = btn_BanHang.Text;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon(), sender);
            lbl_Home.Text = btn_HoaDon.Text;
        }
    }

}
