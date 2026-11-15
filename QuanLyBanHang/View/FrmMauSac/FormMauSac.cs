using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;

namespace QuanLyBanHang.View.FrmMauSac
{
    public partial class FormMauSac : Form
    {
        public IQLmauSacServices qLmauSacServices;
        public mauSac ms;
        public FormMauSac()
        {
            qLmauSacServices = new QLmauSacServices();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dtgv_MauSac.ColumnCount = 3;
            dtgv_MauSac.Columns[0].Name = "ID";
            dtgv_MauSac.Columns[1].Name = "Color";
            dtgv_MauSac.Columns[2].Name = "Status";
            dtgv_MauSac.Rows.Clear();

            var listMauSac = qLmauSacServices.GetMauSacFromDB();
            foreach (var item in listMauSac)
            {
                dtgv_MauSac.Rows.Add(item.IDMauSac, item.tenMau,
                    item.trangThai == true ? "In Stock" : "Out of Stock");
            }
        }

        private void resetForm()
        {
            LoadData();
            txt_TenMauSac.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Please enter a color!");
            }
            else
            {
                mauSac _ms = qLmauSacServices.GetMauSacFromDB().FirstOrDefault(p => p.tenMau.ToLower() == txt_TenMauSac.Text.ToLower());
                if (_ms != null)
                {
                    MessageBox.Show("Color already exists!");
                }
                else
                {
                    var mausac = new mauSac()
                    {
                        tenMau = txt_TenMauSac.Text,
                        trangThai = rdb_conHang.Checked,
                    };
                    qLmauSacServices.addMauSac(mausac);
                    MessageBox.Show("Added successfully!");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenMauSac.Text == "")
            {
                MessageBox.Show("Please enter a color!");
            }
            else if (ms == null)
            {
                MessageBox.Show("Please select a color to update!");
            }
            else
            {
                if (ms.tenMau.ToLower() == txt_TenMauSac.Text.ToLower()
                    || (ms.tenMau.ToLower() != txt_TenMauSac.Text.ToLower() && qLmauSacServices.GetMauSacFromDB().FirstOrDefault(p => p.tenMau.ToLower() == txt_TenMauSac.Text.ToLower()) == null))
                {
                    ms.tenMau = txt_TenMauSac.Text;
                    ms.trangThai = rdb_conHang.Checked;
                    qLmauSacServices.UpdateMauSac(ms);
                    MessageBox.Show("Updated successfully!");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Color already exists!");
                }
            }
        }

        private void dtgv_MauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLmauSacServices.GetMauSacFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_MauSac.Rows[e.RowIndex];
            ms = qLmauSacServices.GetMauSacFromDB().
                FirstOrDefault(x => x.IDMauSac == Convert.ToInt32(row.Cells[0].Value));
            txt_TenMauSac.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "In Stock")
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
