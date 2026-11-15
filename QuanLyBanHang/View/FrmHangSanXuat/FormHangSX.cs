using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;

namespace QuanLyBanHang.View.FrmHangSanXuat
{
    public partial class FormHangSX : Form
    {
        private IQLhangSXServices _qLhangSXServices;
        private hangSX _hangSX;
        public FormHangSX()
        {
            _qLhangSXServices = new QLhangSXServices();
            _hangSX = new hangSX();
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            dtgv_HangSX.ColumnCount = 3;
            dtgv_HangSX.Columns[0].Name = "ID";
            dtgv_HangSX.Columns[1].Name = "Manufacturer";
            dtgv_HangSX.Columns[2].Name = "Status";

            dtgv_HangSX.Rows.Clear();
            foreach (var item in _qLhangSXServices.GetHangSXFromDB())
            {
                dtgv_HangSX.Rows.Add(item.IDHangSX, item.tenHangSX,
                    item.trangThai == true ? "In Stock" : "Out of Stock");

            }
            txt_TenHangSX.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenHangSX.Text == "")
            {
                MessageBox.Show("Please enter the manufacturer!");
            }
            else
            {
                hangSX hsx = _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(p => p.tenHangSX.ToLower() == txt_TenHangSX.Text.ToLower());
                if (hsx != null)
                {
                    MessageBox.Show("Manufacturer already exists!");
                }
                else
                {
                    hangSX addhangSX = new hangSX()
                    {
                        tenHangSX = txt_TenHangSX.Text,
                        trangThai = rdb_conHang.Checked,
                    };
                    _qLhangSXServices.addHangSX(addhangSX);
                    MessageBox.Show("Added successfully!");
                    loadData();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenHangSX.Text == "")
            {
                MessageBox.Show("Please enter the manufacturer!");
            }
            else if (_hangSX == null)
            {
                MessageBox.Show("Please select a manufacturer to update!");
            }
            else
            {
                if (_hangSX.tenHangSX.ToLower() == txt_TenHangSX.Text.ToLower()
                    || (_hangSX.tenHangSX.ToLower() != txt_TenHangSX.Text.ToLower() && _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.tenHangSX.ToLower() == txt_TenHangSX.Text.ToLower()) == null))
                {
                    _hangSX.tenHangSX = txt_TenHangSX.Text;
                    _hangSX.trangThai = rdb_conHang.Checked;
                    _qLhangSXServices.UpdateHangSX(_hangSX);
                    MessageBox.Show("Updated successfully!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Manufacturer already exists!");
                }
            }
        }

        private void dtgv_HangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _qLhangSXServices.GetHangSXFromDB().Count) return;
            DataGridViewRow row = dtgv_HangSX.Rows[e.RowIndex];
            _hangSX = _qLhangSXServices.GetHangSXFromDB().FirstOrDefault(x => x.IDHangSX == Convert.ToInt32(row.Cells[0].Value));
            txt_TenHangSX.Text = row.Cells[1].Value.ToString();
            rdb_conHang.Checked = row.Cells[2].Value.ToString() == "In Stock" ? true : false;
            rdb_hetHang.Checked = row.Cells[2].Value.ToString() == "Out of Stock" ? true : false;
        }
    }
}
