using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.ViewModel;

namespace QuanLyBanHang.View.FrmNhanVien
{
    public partial class FormNhanVien : Form
    {
        public IQLnhanVienServices qLnhanVienServices;
        public IQLchucVuServices qLchucVuServices;
        public ViewHienThi viewNV;
        public FormNhanVien()
        {
            InitializeComponent();
            qLnhanVienServices = new QLnhanVienServices();
            qLchucVuServices = new QLchucVuServices();
            viewNV = new ViewHienThi();
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            foreach (var item in qLchucVuServices.GetchucVuFromDB())
            {
                cbb_ChucVu.Items.Add(item.tenCV);
            }
            cbb_ChucVu.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dtgv_NhanVien.ColumnCount = 8;
            dtgv_NhanVien.Columns[0].Name = "ID";
            dtgv_NhanVien.Columns[1].Name = "Name";
            dtgv_NhanVien.Columns[2].Name = "Address";
            dtgv_NhanVien.Columns[3].Name = "Phone";
            dtgv_NhanVien.Columns[4].Name = "Email";
            dtgv_NhanVien.Columns[5].Name = "Password";
            dtgv_NhanVien.Columns[6].Name = "Position";
            dtgv_NhanVien.Columns[7].Name = "Status";
            dtgv_NhanVien.Rows.Clear();

            var listViewNV = qLnhanVienServices.GetNhanVienFromDB();
            foreach (var item in listViewNV)
            {
                dtgv_NhanVien.Rows.Add(
                    item.nhanViens.IDNhanVien,
                    item.nhanViens.tenNV,
                    item.nhanViens.diaChi,
                    item.nhanViens.SDT,
                    item.nhanViens.email,
                    item.nhanViens.matKhau,
                    item.chucVus.tenCV,
                    item.nhanViens.tinhTrang == true ? "Active" : "Inactive"
                    );
            }
        }
        public void ResetForm()
        {
            LoadData();
            txt_tenNV.Text = "";
            txt_diaChi.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
            txt_MatKhau.Text = "";
            cbb_ChucVu.SelectedIndex = 0;
            rdb_HD.Checked = false;
            rdb_khongHD.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_tenNV.Text == "" || txt_diaChi.Text == "" || txt_SDT.Text == "" || txt_Email.Text == "" || txt_MatKhau.Text == "")
            {
                MessageBox.Show("Please complete all information!");
            }
            else
            {
                var nv = new ViewHienThi()
                {
                    nhanViens = new nhanVien()
                    {
                        tenNV = txt_tenNV.Text,
                        diaChi = txt_diaChi.Text,
                        SDT = txt_SDT.Text,
                        email = txt_Email.Text,
                        matKhau = txt_MatKhau.Text,
                        IDChucVu = cbb_ChucVu.SelectedIndex + 1,
                        tinhTrang = rdb_HD.Checked,
                    }
                };
                qLnhanVienServices.addNhanVien(nv);
                MessageBox.Show("Added successfully!");
                ResetForm();
            }
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            if (txt_tenNV.Text == "" || txt_diaChi.Text == "" || txt_SDT.Text == "" ||
               txt_Email.Text == "" || txt_MatKhau.Text == "")
            {
                MessageBox.Show("Please complete all information!");
            }
            else if (viewNV == null)
            {
                MessageBox.Show("Please select the staff to update!");
            }
            else
            {
                viewNV.nhanViens.tenNV = txt_tenNV.Text;
                viewNV.nhanViens.diaChi = txt_diaChi.Text;
                viewNV.nhanViens.SDT = txt_SDT.Text;
                viewNV.nhanViens.email = txt_Email.Text;
                viewNV.nhanViens.matKhau = txt_MatKhau.Text;
                viewNV.nhanViens.IDChucVu = cbb_ChucVu.SelectedIndex + 1;
                viewNV.nhanViens.tinhTrang = rdb_HD.Checked;
                qLnhanVienServices.UpdateNhanVien(viewNV);
                MessageBox.Show("Updated successfully!");
                ResetForm();

            }
        }

        private void dtgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLnhanVienServices.GetNhanVienFromDB().Count) return;
            DataGridViewRow r = new DataGridViewRow();
            r = dtgv_NhanVien.Rows[e.RowIndex];
            viewNV = qLnhanVienServices.GetNhanVienFromDB().
                FirstOrDefault(x => x.nhanViens.IDNhanVien == Convert.ToInt32(r.Cells[0].Value));
            txt_tenNV.Text = r.Cells[1].Value.ToString();
            txt_diaChi.Text = r.Cells[2].Value.ToString();
            txt_SDT.Text = r.Cells[3].Value.ToString();
            txt_Email.Text = r.Cells[4].Value.ToString();
            txt_MatKhau.Text = r.Cells[5].Value.ToString();
            cbb_ChucVu.SelectedIndex = cbb_ChucVu.FindStringExact(r.Cells[6].Value.ToString());
            if (r.Cells[7].Value.ToString() == "Active")
            {
                rdb_HD.Checked = true;
            }
            else
            {
                rdb_khongHD.Checked = true;
            }
        }
    }
}
