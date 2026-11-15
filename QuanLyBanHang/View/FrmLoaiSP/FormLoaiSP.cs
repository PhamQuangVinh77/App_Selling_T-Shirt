using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;

namespace QuanLyBanHang.View.FrmLoaiSP
{
    public partial class FormLoaiSP : Form
    {
        private IQLsanPhamServices _sanPhamServices;
        private sanPham _sp;
        public FormLoaiSP()
        {
            InitializeComponent();
            _sanPhamServices = new QLsanPhamServices();
            _sp = new sanPham();
            LoadData();
        }

        private void LoadData()
        {
            dtgv_LoaiSP.Rows.Clear();
            foreach (var item in _sanPhamServices.GetsanPhamFromDB())
            {
                dtgv_LoaiSP.Rows.Add(item.IDsanPham, item.tenSanPham,
                    item.trangThai == true ? "In Stock" : "Out of Stock");
            }

            txt_TenLoaiSP.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var existLoaiSP = _sanPhamServices.GetsanPhamFromDB().FirstOrDefault(p => p.tenSanPham == txt_TenLoaiSP.Text);
            if (txt_TenLoaiSP.Text == "")
            {
                MessageBox.Show("Please enter a category!");
            }
            else if (existLoaiSP != null)
            {
                MessageBox.Show("Category already exists!");
            }
            else
            {
                sanPham sp = new sanPham()
                {
                    tenSanPham = txt_TenLoaiSP.Text,
                    trangThai = rdb_conHang.Checked,
                };
                _sanPhamServices.addsanPham(sp);
                MessageBox.Show("Added successfully!");
                LoadData();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiSP.Text == "")
            {
                MessageBox.Show("Please enter a category!");
            }
            else if (_sp == null)
            {
                MessageBox.Show("Please select a category to update!");
            }
            else
            {
                if (_sp.tenSanPham == txt_TenLoaiSP.Text || (_sp.tenSanPham != txt_TenLoaiSP.Text && _sanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.tenSanPham == txt_TenLoaiSP.Text) == null))
                {
                    _sp.tenSanPham = txt_TenLoaiSP.Text;
                    _sp.trangThai = rdb_conHang.Checked;
                    _sanPhamServices.UpdatesanPham(_sp);
                    MessageBox.Show("Updated successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Category already exists!");
                }
            }
        }

        private void dtgv_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _sanPhamServices.GetsanPhamFromDB().Count) return;
            DataGridViewRow row = dtgv_LoaiSP.Rows[e.RowIndex];
            _sp = _sanPhamServices.GetsanPhamFromDB().FirstOrDefault(x => x.IDsanPham == Convert.ToInt32(row.Cells[0].Value));
            txt_TenLoaiSP.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Còn hàng")
            {
                rdb_conHang.Checked = true;
            }
            else
            {
                rdb_hetHang.Checked = true;
            }
        }
    }
}
