using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dtgv_ChatLieu.Columns[0].Name = "ID Chất liệu";
            dtgv_ChatLieu.Columns[1].Name = "Tên chất liệu";
            dtgv_ChatLieu.Columns[2].Name = "Trạng thái";
            dtgv_ChatLieu.Rows.Clear();

            var listChatLieu = qLchatLieuServices.GetChatLieuFromDB();
            foreach (var item in listChatLieu)
            {
                dtgv_ChatLieu.Rows.Add(item.IDchatLieu, item.tenChatLieu,
                    item.trangThai == true ? "Còn hàng" : "Hết hàng");
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
                MessageBox.Show("Vui lòng nhập tên chất liệu!");
            }
            else
            {
                chatLieu cl = qLchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu.ToLower() == txt_TenChatLieu.Text.ToLower());
                if(cl != null)
                {
                    MessageBox.Show("Chất liệu đã tồn tại!");
                }
                else
                {
                    var c = new chatLieu()
                    {
                        tenChatLieu = txt_TenChatLieu.Text,
                        trangThai = rdb_conHang.Checked,
                    };
                    qLchatLieuServices.addChatLieu(c);
                    MessageBox.Show("Thêm thành công!");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenChatLieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chất liệu!");
            }
            else if (chatLieu == null)
            {
                MessageBox.Show("Vui lòng chọn chất liệu cần sửa!");
            }
            else
            {
                if (chatLieu.tenChatLieu.ToLower() == txt_TenChatLieu.Text.ToLower()
                    || (chatLieu.tenChatLieu.ToLower() != txt_TenChatLieu.Text.ToLower() && qLchatLieuServices.GetChatLieuFromDB().FirstOrDefault(x => x.tenChatLieu.ToLower() == txt_TenChatLieu.Text.ToLower()) == null))
                {
                    chatLieu.tenChatLieu = txt_TenChatLieu.Text;
                    chatLieu.trangThai = rdb_conHang.Checked;
                    qLchatLieuServices.UpdateChatLieu(chatLieu);
                    MessageBox.Show("Sửa thành công!");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Chất liệu đã tồn tại!");
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
