using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using QuanLyBanHang.Utilities;

namespace QuanLyBanHang.View.FrmKhachHang
{
    public partial class FormKhachHang : Form
    {
        private IQLkhachHangServices _QLkhachHangServices;
        private khachHang _khachHang;
        public FormKhachHang()
        {
            InitializeComponent();
            _QLkhachHangServices = new QLkhachHangServices();
            _khachHang = new khachHang();
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            dtgv_khachHang.ColumnCount = 5;
            dtgv_khachHang.Columns[0].Name = "Phone Number";
            dtgv_khachHang.Columns[1].Name = "Name";
            dtgv_khachHang.Columns[2].Name = "Gender";
            dtgv_khachHang.Columns[3].Name = "Address";
            dtgv_khachHang.Columns[4].Name = "Loyalty Points";
            dtgv_khachHang.Rows.Clear();
            foreach (var item in _QLkhachHangServices.GetkhachHangFromDB())
            {
                dtgv_khachHang.Rows.Add(item.SDT_KH, item.TenKH, item.gioiTinh == false ? "Male" : "Female", item.diaChi, item.diemTichluy);
            }

            txt_TenKH.Text = "";
            txt_Sdt.Text = "";
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;
            txt_diaChi.Text = "";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            khachHang accKH = _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault(p => p.SDT_KH == txt_Sdt.Text);
            if (txt_Sdt.Text == "" || txt_TenKH.Text == "" || txt_Sdt.Text == "")
            {
                MessageBox.Show("Please enter all required information!");
            }
            else if (accKH != null)
            {
                MessageBox.Show("Phone number already in use!");
            }
            else if (ValidateInput.CheckSDT(txt_Sdt.Text) == false)
            {
                MessageBox.Show("Invalid phone number format!");
            }
            else
            {
                khachHang addKH = new khachHang()
                {
                    SDT_KH = txt_Sdt.Text,
                    TenKH = txt_TenKH.Text,
                    diaChi = txt_diaChi.Text,
                    trangThai = true,
                    gioiTinh = rdb_Nu.Checked == true ? true : false,
                    diemTichluy = 0,
                };
                _QLkhachHangServices.addkhachHang(addKH);
                MessageBox.Show("Added successfully!");
                LoadDuLieu();
            }
        }

        private void dtgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _QLkhachHangServices.GetkhachHangFromDB().Count) return;
            DataGridViewRow row = dtgv_khachHang.Rows[e.RowIndex];
            _khachHang = _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == row.Cells[0].Value);

            txt_Sdt.Text = row.Cells[0].Value.ToString();
            txt_TenKH.Text = row.Cells[1].Value.ToString();
            rdb_Nam.Checked = row.Cells[2].Value.ToString() == "Male" ? true : false;
            rdb_Nu.Checked = row.Cells[2].Value.ToString() == "Female" ? true : false;
            txt_diaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_Sdt.Text == "" || txt_TenKH.Text == "" || txt_diaChi.Text == "")
            {
                MessageBox.Show("Please enter all required information!");
            }
            else if (ValidateInput.CheckSDT(txt_Sdt.Text) == false)
            {
                MessageBox.Show("Invalid phone number format!");
            }
            else if (_khachHang == null)
            {
                MessageBox.Show("Please select a customer to update information!");
            }
            else
            {
                if (_khachHang.SDT_KH == txt_Sdt.Text
                   || (_khachHang.SDT_KH != txt_Sdt.Text && _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == txt_Sdt.Text) == null))
                {
                    _khachHang.SDT_KH = txt_Sdt.Text;
                    _khachHang.TenKH = txt_TenKH.Text;
                    _khachHang.diaChi = txt_diaChi.Text;
                    _khachHang.gioiTinh = rdb_Nu.Checked == true ? true : false;
                    _QLkhachHangServices.UpdateKhachHang(_khachHang);
                    MessageBox.Show("Updated successfully!");
                    LoadDuLieu();
                }
                else
                {
                    MessageBox.Show("Phone number already in use!");
                }
            }
        }
    }
}
