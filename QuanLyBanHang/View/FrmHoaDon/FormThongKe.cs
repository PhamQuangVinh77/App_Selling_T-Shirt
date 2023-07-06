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
using OfficeOpenXml;

namespace QuanLyBanHang.View.FrmHoaDon
{
    public partial class FormThongKe : Form
    {
        private IQLhoaDonServices _order;
        private IQLkhachHangServices _customer;
        public List<hoaDon> _lstOrder;
        public FormThongKe()
        {
            InitializeComponent();
            _order = new QLhoaDonServices();
            _customer = new QLkhachHangServices();
            _lstOrder = _order.GetHoaDonFromDB();
            loadDate();
            loadData();
        }
        private void loadData()
        {
            dtgv_hanghoa.ColumnCount = 5;
            dtgv_hanghoa.Columns[0].Name = "Mã hóa đơn";
            dtgv_hanghoa.Columns[1].Name = "Tên khách hàng";
            dtgv_hanghoa.Columns[2].Name = "Tổng tiền";
            dtgv_hanghoa.Columns[3].Name = "Ngày tạo";
            dtgv_hanghoa.Columns[4].Name = "Trạng thái";
            dtgv_hanghoa.Rows.Clear();

            int tongSoHD = 0;
            int soHDdaThanhToan = 0;
            float doanhThu = 0;
            List<string> lstKhachLe = new List<string>();
            List<string> lstKhachQuen = new List<string>();

            foreach (var item in _lstOrder)
            {
                dtgv_hanghoa.Rows.Add(
                    item.IDHoaDon,
                    _customer.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == item.SDT_KH).TenKH,
                    item.tongTien,
                    item.ngayBan,
                    item.trangThai == true ? "Đã thanh toán" : item.ghiChu == "Đã hủy đơn" ? "Đã hủy đơn" : "Chờ thanh toán...");
                tongSoHD++;
                if (item.trangThai == true)
                {
                    soHDdaThanhToan++;
                    doanhThu += item.tongTien;
                    if (item.SDT_KH == "0000000000")
                    {
                        lstKhachLe.Add(item.SDT_KH);
                    }
                    else
                    {
                        lstKhachQuen.Add(item.SDT_KH);
                    }
                }


            }

            lbl_soHD.Text = tongSoHD.ToString();
            lbl_chuaTT.Text = soHDdaThanhToan.ToString();
            lbl_doanhthu.Text = doanhThu.ToString();
            lbl_tongKH.Text = (lstKhachLe.Count() + lstKhachQuen.Distinct().Count()).ToString();
        }
        private void loadDate()
        {
            cbb_Thang.Items.Add("-");
            for (int i = 1; i <= 12; i++)
            {
                cbb_Thang.Items.Add(i);
            }
            for (int i = 2000; i < 2100; i++)
            {
                cbb_Nam.Items.Add(i);
            }
        }

        private void dtp_thongKeTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            _lstOrder = _order.GetHoaDonFromDB().Where(x => x.ngayBan.ToString("dd-MM-yyyy") == dtp_thongKeTheoNgay.Value.ToString("dd-MM-yyyy")).ToList();
            loadData();
        }

        private void LocTheoThangNam()
        {
            if (cbb_Nam.Text == "") return;
            if (cbb_Thang.SelectedIndex != 0 && cbb_Thang.Text != "")
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => (x.ngayBan.Month.ToString() == cbb_Thang.Text && x.ngayBan.Year.ToString() == cbb_Nam.Text)).ToList();
                loadData();
            }
            else
            {
                _lstOrder = _order.GetHoaDonFromDB().Where(x => x.ngayBan.Year.ToString() == cbb_Nam.Text).ToList();
                loadData();
            }
        }


        private void cbb_Thang_TextChanged(object sender, EventArgs e)
        {
            LocTheoThangNam();
        }

        private void cbb_Nam_TextChanged(object sender, EventArgs e)
        {
            LocTheoThangNam();
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            _lstOrder = _order.GetHoaDonFromDB().Where(x => x.SDT_KH.StartsWith(txt_sdt.Text)).ToList();
            loadData();
        }

        private void btn_xuatEx_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = "Thong ke";

            for (int i = 0; i < dtgv_hanghoa.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dtgv_hanghoa.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgv_hanghoa.Rows.Count; i++)
            {
                for (int j = 0; j < dtgv_hanghoa.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dtgv_hanghoa.Rows[i].Cells[j].Value;
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }

            excel.Quit();
        }
    }
}
