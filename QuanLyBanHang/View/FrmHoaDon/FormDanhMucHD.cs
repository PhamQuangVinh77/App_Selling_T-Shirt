using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.View.FrmHoaDon
{
    public partial class FormDanhMucHD : Form
    {
        IQLhoaDonServices _HDservices;
        IQLhoaDonChiTietServices _hdctServices;
        List<hoaDon> _lstOrder;
        int _idHD;
        public FormDanhMucHD()
        {
            InitializeComponent();
            _HDservices = new QLhoaDonServices();;
            _hdctServices = new QLhoaDonChiTietServices();
            _lstOrder = _HDservices.GetHoaDonFromDB();
            LoadHD();
        }

        private void LoadHD()
        {
            dtgv_HoaDon.Rows.Clear();
            foreach (var i in _lstOrder)
            {
                dtgv_HoaDon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : i.ghiChu == "Đã hủy đơn" ? "Đã hủy đơn" : "Chờ thanh toán...");
            }
        }
        public void LoadHDCT(int maHoaDon)
        {
            _idHD = maHoaDon;
            dtgv_ChiTietHoaDon.Rows.Clear();
            foreach (var i in _hdctServices.getViewHoaDonChiTiet(maHoaDon))
            {
                dtgv_ChiTietHoaDon.Rows.Add(i.maSanPham, i.tenSanPham, i.soLuong, i.donGia);
            }
        }

        private void dtgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_HoaDon.RowCount - 1)
            {
                DataGridViewRow r = dtgv_HoaDon.Rows[e.RowIndex];
                LoadHDCT(Convert.ToInt32(r.Cells[0].Value));
                txt_MaHD.Text = r.Cells[0].Value.ToString();
                txt_MaNV.Text = r.Cells[1].Value.ToString();
                txt_SDTKH.Text = r.Cells[2].Value.ToString();
                txt_TongTien.Text = r.Cells[3].Value.ToString();
                dtp_ngayBan.Text = r.Cells[4].Value.ToString();
                txt_ghiChu.Text = r.Cells[5].Value.ToString();
                if (r.Cells[6].Value.ToString() == "Đã thanh toán")
                {
                    rdb_DaThanhToan.Checked = true;
                }
                else
                {
                    rdb_ChuaThanhToan.Checked = true;
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dtgv_HoaDon.Rows.Clear();
            dtgv_ChiTietHoaDon.Rows.Clear();
            int value;
            if (txt_timKiem.Text != "")
            {
                if (int.TryParse(txt_timKiem.Text, out value))
                {
                    var items = _lstOrder.Where(x => x.IDHoaDon.ToString().Contains(value.ToString()));
                    if (items.Any())
                    {
                        foreach (var i in items)
                        {
                            dtgv_HoaDon.Rows.Add(i.IDHoaDon, i.IDNhanVien, i.SDT_KH, i.tongTien, i.ngayBan, i.ghiChu, i.trangThai == true ? "Đã thanh toán" : i.ghiChu == "Đã hủy đơn" ? "Đã hủy đơn" : "Chờ thanh toán...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn tương ứng");
                        LoadHD();
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu kiểm tra lại thông tin cần tìm");
                    txt_timKiem.Text = "";
                    LoadHD();
                }
            }
            else
            {
                LoadHD();
            }
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            var _hoaDon = _HDservices.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == _idHD);
            if (_hoaDon == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn cần cập nhật thông tin!");
                return;
            }
            _hoaDon.ghiChu = txt_ghiChu.Text;
            _hoaDon.trangThai = rdb_DaThanhToan.Checked;
            _HDservices.UpdateHoaDon(_hoaDon);
            MessageBox.Show("Cập nhật thành công");
            LoadHD();
            dtgv_ChiTietHoaDon.Rows.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var _hoaDon = _HDservices.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == _idHD);
            if (_hoaDon == null)
            {
                MessageBox.Show("Hãy chọn hóa đơn cần xóa!");
                return;
            }
            _HDservices.RemoveHoaDon(_hoaDon);
            MessageBox.Show("Xóa thành công");
            LoadHD();
            dtgv_ChiTietHoaDon.Rows.Clear();

        }
    }
}
