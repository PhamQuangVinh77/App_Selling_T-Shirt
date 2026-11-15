using _1_DAL_QUANLY.Models;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;

namespace QuanLyBanHang.View.FrmChatLieu
{
    public partial class FormChatLieu : Form
    {
        public IQLchatLieuServices qLchatLieuServices;
        public chatLieu chatLieu;
        public FormChatLieu()
        {
            InitializeComponent();
            qLchatLieuServices = new QLchatLieuServices();
            LoadData();
        }
        private void LoadData()
        {
            dtgv_ChatLieu.ColumnCount = 3;
            dtgv_ChatLieu.Columns[0].Name = "ID";
            dtgv_ChatLieu.Columns[1].Name = "Material";
            dtgv_ChatLieu.Columns[2].Name = "Status";
            dtgv_ChatLieu.Rows.Clear();

            var listChatLieu = qLchatLieuServices.GetChatLieuFromDB();
            foreach (var item in listChatLieu)
            {
                dtgv_ChatLieu.Rows.Add(item.IDchatLieu, item.tenChatLieu,
                    item.trangThai == true ? "In Stock" : "Out of Stock");
            }
        }
        private void resetForm()
        {
            LoadData();
            txt_TenChatLieu.Text = "";
            rdb_conHang.Checked = false;
            rdb_hetHang.Checked = false;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenChatLieu.Text == "")
            {
                MessageBox.Show("Please enter the material!");
            }
            else
            {
                chatLieu cl = qLchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu.ToLower() == txt_TenChatLieu.Text.ToLower());
                if (cl != null)
                {
                    MessageBox.Show("Material already exists!");
                }
                else
                {
                    var c = new chatLieu()
                    {
                        tenChatLieu = txt_TenChatLieu.Text,
                        trangThai = rdb_conHang.Checked,
                    };
                    qLchatLieuServices.addChatLieu(c);
                    MessageBox.Show("Added successfully!");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenChatLieu.Text == "")
            {
                MessageBox.Show("Please enter the material!");
            }
            else if (chatLieu == null)
            {
                MessageBox.Show("Please select the material to edit!");
            }
            else
            {
                if (chatLieu.tenChatLieu.ToLower() == txt_TenChatLieu.Text.ToLower()
                    || (chatLieu.tenChatLieu.ToLower() != txt_TenChatLieu.Text.ToLower() && qLchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu.ToLower() == txt_TenChatLieu.Text.ToLower()) == null))
                {
                    chatLieu.tenChatLieu = txt_TenChatLieu.Text;
                    chatLieu.trangThai = rdb_conHang.Checked;
                    qLchatLieuServices.UpdateChatLieu(chatLieu);
                    MessageBox.Show("Updated successfully!");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Material already exists!");
                }
            }
        }

        private void dtgv_ChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLchatLieuServices.GetChatLieuFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_ChatLieu.Rows[e.RowIndex];
            chatLieu = qLchatLieuServices.GetChatLieuFromDB().
                FirstOrDefault(x => x.IDchatLieu == Convert.ToInt32(row.Cells[0].Value));
            txt_TenChatLieu.Text = row.Cells[1].Value.ToString();
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
