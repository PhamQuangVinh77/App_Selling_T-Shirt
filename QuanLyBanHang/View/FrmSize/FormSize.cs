using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;

namespace QuanLyBanHang.View.FrmSize
{
    public partial class FormSize : Form
    {
        private IQLsizeServices _QLsizeServices;
        public size _size;
        public FormSize()
        {
            _QLsizeServices = new QLsizeServices();
            _size = new size();
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            dtgv_Size.Rows.Clear();
            foreach (var item in _QLsizeServices.GetSizeFromDB())
            {
                dtgv_Size.Rows.Add(item.IDSize, item.tenSize,
                    item.trangThai == true ? "In Stock" : "Out of Stock");
            }

            txt_TenSize.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            size accSize = _QLsizeServices.GetSizeFromDB().FirstOrDefault(p => p.tenSize == txt_TenSize.Text);
            if (txt_TenSize.Text == "")
            {
                MessageBox.Show("Please enter the size!");
            }
            else if (accSize != null)
            {
                MessageBox.Show("Size already exists!");
            }
            else
            {
                size addsize = new size()
                {
                    tenSize = txt_TenSize.Text,
                    trangThai = rdb_conHang.Checked,
                };
                _QLsizeServices.addsize(addsize);
                MessageBox.Show("Added successfully!");
                loadData();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenSize.Text == "")
            {
                MessageBox.Show("Please enter the size!");
            }
            else if (_size == null)
            {
                MessageBox.Show("Please select a size to update!");
            }
            else
            {
                if (_size.tenSize == txt_TenSize.Text || (_size.tenSize != txt_TenSize.Text && _QLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.tenSize == txt_TenSize.Text) == null))
                {
                    _size.tenSize = txt_TenSize.Text;
                    _size.trangThai = rdb_conHang.Checked;
                    _QLsizeServices.UpdateSize(_size);
                    MessageBox.Show("Updated successfully!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Size already exists!");
                }
            }
        }

        private void dtgv_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= _QLsizeServices.GetSizeFromDB().Count) return;
            DataGridViewRow row = dtgv_Size.Rows[e.RowIndex];
            _size = _QLsizeServices.GetSizeFromDB().FirstOrDefault(x => x.IDSize == Convert.ToInt32(row.Cells[0].Value));
            txt_TenSize.Text = row.Cells[1].Value.ToString();
            rdb_conHang.Checked = row.Cells[2].Value.ToString() == "In Stock" ? true : false;
            rdb_hetHang.Checked = row.Cells[2].Value.ToString() == "Out of Stock" ? true : false;
        }
    }
}
