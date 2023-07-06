using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
using QuanLyBanHang.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dtgv_khachHang.Columns[0].Name = "Số Điện Thoại";
            dtgv_khachHang.Columns[1].Name = "Tên Khách Hàng";
            dtgv_khachHang.Columns[2].Name = "Giới Tính";
            dtgv_khachHang.Columns[3].Name = "Địa Chỉ";
            dtgv_khachHang.Columns[4].Name = "Điểm tích lũy";
            dtgv_khachHang.Rows.Clear();
            foreach (var item in _QLkhachHangServices.GetkhachHangFromDB())
            {
                dtgv_khachHang.Rows.Add(item.SDT_KH, item.TenKH, item.gioiTinh == false ? "Nam" : "Nữ", item.diaChi, item.diemTichluy);
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
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accKH != null)
            {
                MessageBox.Show("Số điện thoại khách hàng đã tồn tại");
            }
            else if (ValidateInput.CheckSDT(txt_Sdt.Text) == false)
            {
                MessageBox.Show("Sai định dạng SĐT");
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
                MessageBox.Show("Thêm khách hàng thành công");
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
            rdb_Nam.Checked = row.Cells[2].Value.ToString() == "Nam" ? true : false;
            rdb_Nu.Checked = row.Cells[2].Value.ToString() == "Nữ" ? true : false;
            txt_diaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_Sdt.Text == "" || txt_TenKH.Text == "" || txt_diaChi.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (ValidateInput.CheckSDT(txt_Sdt.Text) == false)
            {
                MessageBox.Show("Sai định dạng SĐT");
            }
            else if (_khachHang == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa thông tin");
            }
            else
            {
                if (_khachHang.SDT_KH == txt_Sdt.Text
                   || (_khachHang.SDT_KH != txt_Sdt.Text  && _QLkhachHangServices.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == txt_Sdt.Text) == null))
                {
                    _khachHang.SDT_KH = txt_Sdt.Text;
                    _khachHang.TenKH = txt_TenKH.Text;
                    _khachHang.diaChi = txt_diaChi.Text;
                    _khachHang.gioiTinh = rdb_Nu.Checked == true ? true : false;
                    _QLkhachHangServices.UpdateKhachHang(_khachHang);
                    MessageBox.Show("Sửa thành công!");
                    LoadDuLieu();
                }
                else
                {
                    MessageBox.Show("SDT khách hàng đã tồn tại!");
                }
            }
        }
    }
}
