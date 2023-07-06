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

namespace QuanLyBanHang.View.FrmNhaCungCap
{
    public partial class FormNhaCungCap : Form
    {
        public IQLnhaCungCapServices qLnhaCungCapServices;
        public nhaCungCap nhaCC;
        public FormNhaCungCap()
        {
            InitializeComponent();
            qLnhaCungCapServices = new QLnhaCungCapServices();
            LoadData();
        }
        public void LoadData()
        {
            dtgv_nhaCC.ColumnCount = 3;
            dtgv_nhaCC.Columns[0].Name = "ID Nhà cung cấp";
            dtgv_nhaCC.Columns[1].Name = "Tên nhà cung cấp";
            dtgv_nhaCC.Columns[2].Name = "Trạng thái";
            dtgv_nhaCC.Rows.Clear();

            var listNCC = qLnhaCungCapServices.GetNhaCungCapFromDB();
            foreach (var item in listNCC)
            {
                dtgv_nhaCC.Rows.Add(item.IDNhaCungCap, item.tenNhaCungCap,
                    item.trangThai == true ? "Đang cung cấp" : "Ngừng cung cấp");
            }
        }

        public void resetForm()
        {
            LoadData();
            txt_TenNhaCC.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenNhaCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
            }
            else
            {
                nhaCungCap nhaCC = qLnhaCungCapServices.GetNhaCungCapFromDB().FirstOrDefault(x => x.tenNhaCungCap.ToLower() == txt_TenNhaCC.Text.ToLower());
                if (nhaCC != null)
                {
                    MessageBox.Show("Hãng SX đã tồn tại!");
                }
                else
                {
                    var ncc = new nhaCungCap()
                    {
                        tenNhaCungCap = txt_TenNhaCC.Text,
                        trangThai = radioButton1.Checked,
                    };
                    qLnhaCungCapServices.addNhaCungCap(ncc);
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                    resetForm();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_TenNhaCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!");
            }
            else if (nhaCC == null)
            {
                MessageBox.Show("Vui lòng chọn tên nhà cung cấp cần sửa!");
            }
            else
            {
                if (nhaCC.tenNhaCungCap.ToLower() == txt_TenNhaCC.Text.ToLower()
                    || (nhaCC.tenNhaCungCap.ToLower() != txt_TenNhaCC.Text.ToLower() && qLnhaCungCapServices.GetNhaCungCapFromDB().FirstOrDefault(x => x.tenNhaCungCap.ToLower() == txt_TenNhaCC.Text.ToLower()) == null))
                {
                    nhaCC.tenNhaCungCap = txt_TenNhaCC.Text;
                    nhaCC.trangThai = radioButton1.Checked;
                    qLnhaCungCapServices.UpdatesNhaCungCap(nhaCC);
                    MessageBox.Show("Sửa thành công!");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Tên nhà cung cấp đã tồn tại!");
                }
            }
        }

        private void dtgv_nhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= qLnhaCungCapServices.GetNhaCungCapFromDB().Count) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_nhaCC.Rows[e.RowIndex];
            nhaCC = qLnhaCungCapServices.GetNhaCungCapFromDB().
                FirstOrDefault(x => x.IDNhaCungCap == Convert.ToInt32(row.Cells[0].Value));
            txt_TenNhaCC.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Đang cung cấp")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }
    }
}
