using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.ViewModel;
using QuanLyBanHang.Utilities;
using System.Data;

namespace QuanLyBanHang.View.FrmBanHang
{
    public partial class FormBanHang : Form
    {
        private IQLsanPhamServices _qlSanPham;
        private IQLhoaDonServices _qlhoaDon;
        private IQLhoaDonChiTietServices _qlhoaDonChiTiet;
        private IQLsanPhamChiTietServices _qlSanPhamCT;
        private IQLnhanVienServices _qLnhanVien;
        private IQLkhachHangServices _qlKhachHang;
        private IQLhangSXServices _qlhangSX;
        private IQLmauSacServices _qlMauSac;
        private IQLsizeServices _qlsize;
        public List<ViewHoaDonCT> gioHang;
        public int IdSPinGioHang;
        public int IdinDonHangCho;
        public hoaDon HoaDon;
        public khachHang KH;
        public int oID;
        public FormBanHang()
        {
            InitializeComponent();
            _qlMauSac = new QLmauSacServices();
            _qlsize = new QLsizeServices();
            _qlhangSX = new QLhangSXServices();
            _qlSanPham = new QLsanPhamServices();
            _qlSanPhamCT = new QLsanPhamChiTietServices();
            _qlhoaDon = new QLhoaDonServices();
            _qlhoaDonChiTiet = new QLhoaDonChiTietServices();
            _qlKhachHang = new QLkhachHangServices();
            _qLnhanVien = new QLnhanVienServices();
            gioHang = new List<ViewHoaDonCT>();
            KH = new khachHang();
            oID = -1;
            LoadSanPham();
            LoadHangSX();
            LoadMauSac();
            LoadSize();
            LoadKhachHang();
            loadHDcho();
            this.CenterToScreen();
        }

        private void LoadMauSac()
        {
            cbb_mauSac.Items.Clear();
            cbb_mauSac.Items.Add("All");
            var ms = _qlMauSac.GetMauSacFromDB().Where(x => x.trangThai == true);
            foreach (var item in ms)
            {
                cbb_mauSac.Items.Add(item.tenMau);
            }
            cbb_mauSac.SelectedIndex = 0;
        }

        private void LoadHangSX()
        {
            cbb_hangSX.Items.Clear();
            cbb_hangSX.Items.Add("All");
            var hsx = _qlhangSX.GetHangSXFromDB().Where(x => x.trangThai == true);
            foreach (var item in hsx)
            {
                cbb_hangSX.Items.Add(item.tenHangSX);
            }
            cbb_hangSX.SelectedIndex = 0;
        }

        private void LoadSize()
        {
            cbb_size.Items.Clear();
            cbb_size.Items.Add("All");
            var sz = _qlsize.GetSizeFromDB().Where(x => x.trangThai == true);
            foreach (var item in sz)
            {
                cbb_size.Items.Add(item.tenSize);
            }
            cbb_size.SelectedIndex = 0;
        }

        private void LoadSanPham()
        {
            dtgv_DSSP.ColumnCount = 8;
            dtgv_DSSP.Columns[0].Name = "ID";
            dtgv_DSSP.Columns[0].Visible = false;
            dtgv_DSSP.Columns[1].Name = "Product Code";
            dtgv_DSSP.Columns[2].Name = "Product Name";
            dtgv_DSSP.Columns[3].Name = "Manufacturer";
            dtgv_DSSP.Columns[4].Name = "Color";
            dtgv_DSSP.Columns[5].Name = "Size";
            dtgv_DSSP.Columns[6].Name = "Price";
            dtgv_DSSP.Columns[7].Name = "Available Quantity";
            dtgv_DSSP.Rows.Clear();

            List<ViewHienThi> lstView = _qlSanPhamCT.getViewSPCT().Where(p => p.SanPhamChiTiets.trangThai == true).ToList();
            foreach (ViewHienThi item in lstView)
            {
                if (item.chatLieus.trangThai && item.hangSXs.trangThai && item.mauSacs.trangThai && item.nhaCungCaps.trangThai && item.sizes.trangThai && item.sanPhams.trangThai)
                {
                    dtgv_DSSP.Rows.Add(
                        item.SanPhamChiTiets.IDSanPhamChiTiet,
                        item.SanPhamChiTiets.maSP,
                        item.SanPhamChiTiets.TenSP,
                        item.hangSXs.tenHangSX,
                        item.mauSacs.tenMau,
                        item.sizes.tenSize,
                        item.SanPhamChiTiets.giaBan,
                        item.SanPhamChiTiets.soLuong
                    );
                }


            }
            ;
        }

        private void LoadKhachHang()
        {
            cbb_KhachHang.Items.Clear();
            foreach (var item in _qlKhachHang.GetkhachHangFromDB())
            {
                cbb_KhachHang.Items.Add(item.TenKH);
            }
        }
        public void timKiemSPCT()
        {
            var listSPCT = _qlSanPhamCT.getViewSPCT().Where(x => x.SanPhamChiTiets.trangThai == true);
            if (cbb_size.SelectedIndex != 0)
            {
                listSPCT = listSPCT.Where(x => x.sizes.tenSize == cbb_size.Text);
            }
            if (cbb_mauSac.SelectedIndex != 0)
            {
                listSPCT = listSPCT.Where(x => x.mauSacs.tenMau == cbb_mauSac.Text);
            }
            if (cbb_hangSX.SelectedIndex != 0)
            {
                listSPCT = listSPCT.Where(x => x.hangSXs.tenHangSX == cbb_hangSX.Text);
            }
            if (txt_TimKiem.Text != "")
            {
                listSPCT = listSPCT.Where(x => x.SanPhamChiTiets.TenSP.ToLower().Contains(txt_TimKiem.Text.ToLower()));
            }
            dtgv_DSSP.Rows.Clear();
            foreach (var item in listSPCT)
            {
                if (item.chatLieus.trangThai && item.hangSXs.trangThai && item.mauSacs.trangThai && item.nhaCungCaps.trangThai && item.sizes.trangThai && item.sanPhams.trangThai)
                {
                    dtgv_DSSP.Rows.Add(
                        item.SanPhamChiTiets.IDSanPhamChiTiet,
                        item.SanPhamChiTiets.maSP,
                        item.SanPhamChiTiets.TenSP,
                        item.hangSXs.tenHangSX,
                        item.mauSacs.tenMau,
                        item.sizes.tenSize,
                        item.SanPhamChiTiets.giaBan,
                        item.SanPhamChiTiets.soLuong
                    );
                }
            }
        }

        private void cbb_size_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }
        private void cbb_mauSac_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }
        private void cbb_hangSX_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }
        private void txt_TimKiem_TextChanged_1(object sender, EventArgs e)
        {
            timKiemSPCT();
        }

        private void dtgv_DSSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = new DataGridViewRow();
            r = dtgv_DSSP.Rows[e.RowIndex];
            var spct = _qlSanPhamCT.GetSanPhamCTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == Convert.ToInt32(r.Cells[0].Value));
            if (spct != null)
            {
                themGioHang(spct.IDSanPhamChiTiet);
            }
        }

        private void themGioHang(int ID)
        {
            var spct = _qlSanPhamCT.getViewSPCT().FirstOrDefault(x => x.SanPhamChiTiets.IDSanPhamChiTiet == ID);
            if (spct.SanPhamChiTiets.soLuong == 0)
            {
                MessageBox.Show("Product is currently out of stock!");
                return;
            }
            var checkInGioHang = gioHang.FirstOrDefault(x => x.ID == spct.SanPhamChiTiets.IDSanPhamChiTiet);
            if (checkInGioHang == null) // Nếu SP đã chọn chưa có trong giỏ hàng thì thêm mới
            {
                ViewHoaDonCT gioHangChiTiet = new ViewHoaDonCT()
                {
                    ID = spct.SanPhamChiTiets.IDSanPhamChiTiet,
                    maSanPham = spct.SanPhamChiTiets.maSP,
                    tenSanPham = spct.SanPhamChiTiets.TenSP,
                    donGia = spct.SanPhamChiTiets.giaBan,
                    soLuong = 1,
                };
                gioHang.Add(gioHangChiTiet);
            }
            else // Nếu SP đã chọn đã có trong giỏ hàng
            {
                if (checkInGioHang.soLuong == spct.SanPhamChiTiets.soLuong)
                {
                    MessageBox.Show("You have reached the maximum available quantity in stock!");
                }
                else
                {
                    checkInGioHang.soLuong++;
                }
            }
            loadGioHang();
        }
        private void loadGioHang()
        {
            dtgv_gioHang.ColumnCount = 5;
            dtgv_gioHang.Columns[0].Name = "ID";
            dtgv_gioHang.Columns[0].Visible = false;
            dtgv_gioHang.Columns[1].Name = "Product Code";
            dtgv_gioHang.Columns[2].Name = "Product Name";
            dtgv_gioHang.Columns[3].Name = "Quantity";
            dtgv_gioHang.Columns[4].Name = "Unit Price";

            dtgv_gioHang.Rows.Clear();
            foreach (var item in gioHang)
            {
                dtgv_gioHang.Rows.Add(item.ID, item.maSanPham, item.tenSanPham, item.soLuong, item.donGia);
            }
        }
        private void dtgv_gioHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_gioHang.Rows[e.RowIndex];
            IdSPinGioHang = Convert.ToInt32(r.Cells[0].Value);
        }
        private void btn_XoaSP_Click_1(object sender, EventArgs e)
        {
            if (gioHang.Any()) // Nếu trong giỏ có hàng
            {
                if (gioHang.Find(x => x.ID == IdSPinGioHang) != null)
                {
                    var item = gioHang.FirstOrDefault(x => x.ID == IdSPinGioHang);
                    gioHang.Remove(item);
                    loadGioHang();
                }
                else
                {
                    MessageBox.Show("Please select a product in the cart to remove!");
                }
            }
            else
            {
                MessageBox.Show("Your cart is empty!");
            }
        }
        private void btn_XoaGH_Click_1(object sender, EventArgs e)
        {
            if (gioHang.Any()) // Nếu trong giỏ có hàng
            {
                gioHang = new List<ViewHoaDonCT>();
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Your cart is empty!");
            }
        }
        private void cbb_KhachHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbb_KhachHang.SelectedIndex == -1) { return; }
            var kh = _qlKhachHang.GetkhachHangFromDB()[cbb_KhachHang.SelectedIndex];
            if (kh.gioiTinh == true)
            {
                rdb_nu.Checked = true;
            }
            else
            {
                rdb_nam.Checked = true;
            }
            txt_SDT.Text = kh.SDT_KH;
            lbl_diemTichLuy.Text = kh.diemTichluy.ToString();
        }
        private void cbb_KhachHang_TextChanged_1(object sender, EventArgs e)
        {
            lbl_diemTichLuy.Text = "...";
        }
        private void btn_ThemKH_Click_1(object sender, EventArgs e)
        {
            if (txt_SDT.Text == "" || cbb_KhachHang.Text == "")
            {
                MessageBox.Show("Please enter customer information!");
                return;
            }

            if (ValidateInput.CheckSDT(txt_SDT.Text) == false)
            {
                MessageBox.Show("Invalid phone number!");
                return;
            }

            var listKH = _qlKhachHang.GetkhachHangFromDB();
            foreach (var item in listKH)
            {
                if (txt_SDT.Text == item.SDT_KH)
                {
                    MessageBox.Show("Phone number already exists! Please enter a different number!");
                    return;
                }
            }

            var kh = new khachHang();
            kh.SDT_KH = txt_SDT.Text;
            kh.TenKH = cbb_KhachHang.Text;
            kh.gioiTinh = rdb_nu.Checked;
            kh.diaChi = "";
            kh.trangThai = true;
            kh.diemTichluy = 0;
            _qlKhachHang.addkhachHang(kh);
            MessageBox.Show("Customer added successfully!");

            txt_SDT.Text = "";
            cbb_KhachHang.Text = "";
            lbl_diemTichLuy.Text = "...";
            rdb_nu.Checked = false;
            rdb_nam.Checked = false;
            LoadKhachHang();
        }
        private void btn_TaoHD_Click_1(object sender, EventArgs e)
        {
            if (cbb_KhachHang.Text == "")
            {
                MessageBox.Show("Please enter customer information!");
                return;
            }
            if (gioHang.Any())
            {
                // Xem trong danh sách đơn hàng chờ đã có đơn nào của khách hàng hiện tại hay chưa
                var existHD = _qlhoaDon.GetHoaDonFromDB().Where(x => x.trangThai == false).Where(x => x.ghiChu == "Awaiting payment...").FirstOrDefault(x => x.SDT_KH == txt_SDT.Text);
                if (existHD != null) // Thực hiện gộp đơn nếu đã có
                {
                    foreach (var item in gioHang)
                    {
                        var existHDCT = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == existHD.IDHoaDon).FirstOrDefault(x => x.IDSanPham == item.ID);
                        if (existHDCT != null)
                        {
                            existHDCT.Soluong += item.soLuong;
                            _qlhoaDonChiTiet.UpdateHoaDonChiTiet(existHDCT);
                            existHD.tongTien += item.donGia * item.soLuong;
                            _qlhoaDon.UpdateHoaDon(existHD);
                        }
                        else
                        {
                            var hdct = new hoaDonChiTiet()
                            {
                                IDHoaDon = existHD.IDHoaDon,
                                IDSanPham = item.ID,
                                Soluong = item.soLuong,
                                donGia = item.donGia,
                                Trangthai = true,
                            };
                            _qlhoaDonChiTiet.addHoaDonChiTiet(hdct);
                            existHD.tongTien += hdct.donGia * hdct.Soluong;
                            _qlhoaDon.UpdateHoaDon(existHD);
                        }
                    }
                    MessageBox.Show("Invoice merged with existing pending invoice!");
                }
                else // Tạo đơn mới nếu chưa có
                {
                    float money = 0;
                    var hoaDon = new hoaDon()
                    {
                        IDNhanVien = _qLnhanVien.GetNhanVienFromDB().
                                    FirstOrDefault(x => x.nhanViens.email == Properties.Settings.Default.email).nhanViens.IDNhanVien,
                        // IDNhanVien sẽ là ID của tài khoản đang đăng nhập hiện tại
                        SDT_KH = txt_SDT.Text,
                        ngayBan = DateTime.Now,
                        ghiChu = "Awaiting payment...",
                        trangThai = false,
                    };
                    _qlhoaDon.addHoaDon(hoaDon);
                    foreach (var item in gioHang)
                    {
                        var hdct = new hoaDonChiTiet()
                        {
                            IDHoaDon = hoaDon.IDHoaDon,
                            IDSanPham = item.ID,
                            Soluong = item.soLuong,
                            donGia = item.donGia,
                            Trangthai = true,
                        };
                        _qlhoaDonChiTiet.addHoaDonChiTiet(hdct);
                        money += hdct.donGia;
                    }
                    hoaDon.tongTien = money;
                    _qlhoaDon.UpdateHoaDon(hoaDon);
                    MessageBox.Show("Invoice created successfully!");
                }

                //// Trừ đi trong kho số lượng sp đã được mua
                foreach (var item in gioHang)
                {
                    var spct = _qlSanPhamCT.GetSanPhamCTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.ID);
                    spct.soLuong -= item.soLuong;
                    if (spct.soLuong <= 0) spct.trangThai = false;
                    _qlSanPhamCT.UpdateSanPham(spct);
                }

                gioHang = new List<ViewHoaDonCT>();
                IdSPinGioHang = -1;
                loadGioHang();
                loadHDcho();
                LoadSanPham();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Your cart is empty!");
            }
        }
        public void ClearForm()
        {
            // Clear thông tin nhân viên
            cbb_KhachHang.SelectedIndex = -1;
            rdb_nam.Checked = false;
            rdb_nu.Checked = false;
            txt_SDT.Text = "";
            lbl_diemTichLuy.Text = "...";

            // Clear hóa đơn
            txt_MaHD.Text = "";
            txt_giamGia.Text = "";
            txt_TongTien.Text = "";
            txt_khachDua.Text = "";
            txt_TienThua.Text = "";
            txt_GhiChu.Text = "";
        }

        public void loadHDcho()
        {
            dtgv_HoadonCho.ColumnCount = 5;
            dtgv_HoadonCho.Columns[0].Name = "Invoice Code";
            dtgv_HoadonCho.Columns[0].Visible = false;
            dtgv_HoadonCho.Columns[1].Name = "Customer Phone";
            dtgv_HoadonCho.Columns[2].Name = "Customer Name";
            dtgv_HoadonCho.Columns[3].Name = "Employee ID";
            dtgv_HoadonCho.Columns[3].Visible = false;
            dtgv_HoadonCho.Columns[4].Name = "Creation Time";

            dtgv_HoadonCho.Rows.Clear();
            var hdCho = _qlhoaDon.getViewhoaDon().Where(x => x.hoaDons.trangThai == false).Where(x => x.hoaDons.ghiChu == "Awaiting payment...");
            foreach (var item in hdCho)
            {
                dtgv_HoadonCho.Rows.Add(item.hoaDons.IDHoaDon, item.hoaDons.SDT_KH, item.khachHangs.TenKH, item.nhanViens.IDNhanVien, item.hoaDons.ngayBan);
            }
        }
        private void dtgv_HoadonCho_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dtgv_HoadonCho.Rows[e.RowIndex];
            HoaDon = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == Convert.ToInt32(r.Cells[0].Value));
            IdinDonHangCho = HoaDon.IDHoaDon;
            if (HoaDon == null) return;
            cbb_KhachHang.SelectedIndex = cbb_KhachHang.FindStringExact(_qlKhachHang.GetkhachHangFromDB()
                .FirstOrDefault(x => x.SDT_KH == r.Cells[1].Value.ToString()).TenKH);
            txt_MaHD.Text = HoaDon.IDHoaDon.ToString();
            float tongTien = 0;
            foreach (var item in _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == HoaDon.IDHoaDon))
            {
                tongTien += item.donGia * item.Soluong;
            }
            txt_TongTien.Text = tongTien.ToString();
            txt_khachDua.Text = "0";
            txt_giamGia.Text = "0";
            txt_GhiChu.Text = "Payment completed!";
        }

        private void btn_huyDon_Click(object sender, EventArgs e)
        {
            var donHangCho = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == IdinDonHangCho);
            if (donHangCho == null)
            {
                MessageBox.Show("Please select an order to cancel!");
            }
            else
            {
                donHangCho.ghiChu = "Cancelled";
                _qlhoaDon.UpdateHoaDon(donHangCho);

                // Trả lại số lượng các sp trong đơn bị hủy về kho
                var lstSP = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == IdinDonHangCho);
                foreach (var item in lstSP)
                {
                    var sp = _qlSanPhamCT.GetSanPhamCTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.IDSanPham);
                    sp.soLuong += item.Soluong;
                    if (sp.trangThai == false) sp.trangThai = true;
                    _qlSanPhamCT.UpdateSanPham(sp);
                }
                MessageBox.Show("Order cancelled successfully!");
                LoadSanPham();
                loadHDcho();
                ClearForm();
            }
        }

        private void txt_giamGia_TextChanged_1(object sender, EventArgs e)
        {
            if (HoaDon == null) return;
            if (txt_giamGia.Text == "")
            {
                txt_giamGia.Text = "0";
            }

            foreach (char item in txt_giamGia.Text)
            {
                if (!char.IsNumber(item))
                {
                    MessageBox.Show("Error! Only numbers are allowed!");
                    txt_giamGia.Text = "0";
                    return;
                }
            }
            if (Convert.ToInt32(txt_giamGia.Text) > _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HoaDon.SDT_KH).diemTichluy)
            {
                MessageBox.Show("Insufficient reward points!");
                txt_giamGia.Text = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HoaDon.SDT_KH).diemTichluy.ToString();
            }
            float tongTien = 0;
            foreach (var item in _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == HoaDon.IDHoaDon))
            {
                tongTien += item.donGia * item.Soluong;
            }
            if (Convert.ToDecimal(tongTien) - Convert.ToDecimal(txt_giamGia.Text) * 1000 < 0)
            {
                txt_TongTien.Text = "0";
            }
            else
            {
                txt_TongTien.Text = (Convert.ToDecimal(tongTien) - Convert.ToDecimal(txt_giamGia.Text) * 1000).ToString();
            }
            int tienThua = Convert.ToInt32(txt_khachDua.Text) - Convert.ToInt32(txt_TongTien.Text);
            if (tienThua < 0)
            {
                txt_TienThua.Text = "";
            }
            else
            {
                txt_TienThua.Text = tienThua.ToString();
            }
        }
        private void txt_khachDua_TextChanged_1(object sender, EventArgs e)
        {
            if (HoaDon == null) return;
            if (txt_khachDua.Text == "")
            {
                txt_khachDua.Text = "0";
            }
            if (txt_TongTien.Text == "")
            {
                txt_TongTien.Text = "0";
            }
            foreach (char item in txt_khachDua.Text)
            {
                if (!char.IsNumber(item))
                {
                    MessageBox.Show("Error! Only numbers are allowed!");
                    txt_khachDua.Text = "";
                    return;
                }
            }
            int tienThua = Convert.ToInt32(txt_khachDua.Text) - Convert.ToInt32(txt_TongTien.Text);
            if (tienThua < 0)
            {
                txt_TienThua.Text = "";
            }
            else
            {
                txt_TienThua.Text = tienThua.ToString();
            }
        }
        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (HoaDon == null)
            {
                MessageBox.Show("Please select an invoice to checkout!");
            }
            else if (txt_TienThua.Text == "")
            {
                MessageBox.Show("Customer has not paid enough!");
            }
            else
            {
                // Trừ số điểm tích lũy đã dùng + điểm tích lũy cộng thêm
                var kh = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == txt_SDT.Text);
                if (kh.TenKH != "Guest")
                {
                    var diemDaDung = Convert.ToInt32(txt_giamGia.Text);
                    var listHDCT = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == HoaDon.IDHoaDon);
                    int tongTien = 0;
                    foreach (var item in listHDCT)
                    {
                        tongTien += Convert.ToInt32(item.donGia) * item.Soluong;
                    }
                    var diemCongThem = tongTien / 10000;
                    kh.diemTichluy = kh.diemTichluy - diemDaDung + diemCongThem;
                    _qlKhachHang.UpdateKhachHang(kh);
                }

                HoaDon.IDNhanVien = _qLnhanVien.GetNhanVienFromDB().
                    FirstOrDefault(x => x.nhanViens.email == Properties.Settings.Default.email).nhanViens.IDNhanVien;
                // IDNhanVien sẽ là ID của tài khoản đang đăng nhập hiện tại
                HoaDon.trangThai = true;
                HoaDon.ngayBan = DateTime.Now;
                HoaDon.tongTien = Convert.ToInt32(txt_TongTien.Text);
                HoaDon.ghiChu = txt_GhiChu.Text;
                _qlhoaDon.UpdateHoaDon(HoaDon);
                oID = HoaDon.IDHoaDon;
                loadHDcho();
                ClearForm();
                HoaDon = null;
                MessageBox.Show($"Payment completed!");
                LoadSanPham();
                InHoaDon();
            }
        }
        private void btn_thanhtoanngay_Click(object sender, EventArgs e)
        {
            if (cbb_KhachHang.Text == "")
            {
                MessageBox.Show("Please enter customer information!");
                return;
            }
            ;
            float tongTien = 0;
            foreach (var item in gioHang)
            {
                tongTien += item.donGia * item.soLuong;
            }

            if (gioHang.Any())
            {
                var hoaDon = new hoaDon()
                {
                    IDNhanVien = _qLnhanVien.GetNhanVienFromDB().FirstOrDefault(x => x.nhanViens.email == Properties.Settings.Default.email).nhanViens.IDNhanVien,
                    SDT_KH = txt_SDT.Text,
                    ngayBan = DateTime.Now,
                    tongTien = tongTien,
                    ghiChu = "Awaiting payment...",
                    trangThai = false,
                };
                _qlhoaDon.addHoaDon(hoaDon);
                foreach (var item in gioHang)
                {
                    var hdct = new hoaDonChiTiet()
                    {
                        IDHoaDon = hoaDon.IDHoaDon,
                        IDSanPham = item.ID,
                        Soluong = item.soLuong,
                        donGia = item.donGia,
                        Trangthai = true,
                    };
                    _qlhoaDonChiTiet.addHoaDonChiTiet(hdct);
                }

                txt_MaHD.Text = hoaDon.IDHoaDon.ToString();
                txt_TongTien.Text = tongTien.ToString();
                txt_khachDua.Text = "0";
                txt_GhiChu.Text = "Payment completed!";
                txt_giamGia.Text = "0";

                // Trừ đi số lượng sản phẩm đã mua
                foreach (var item in gioHang)
                {
                    var spct = _qlSanPhamCT.GetSanPhamCTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.ID);
                    spct.soLuong -= item.soLuong;
                    if (spct.soLuong <= 0) spct.trangThai = false;
                    _qlSanPhamCT.UpdateSanPham(spct);
                }

                gioHang = new List<ViewHoaDonCT>();
                IdSPinGioHang = -1;
                HoaDon = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == hoaDon.IDHoaDon);
                LoadSanPham();
                loadGioHang();
                loadHDcho();
            }
            else
            {
                MessageBox.Show("No items added to invoice yet!");
            }
        }

        private void InHoaDon()
        {
            ppdhd.Document = pdhd;
            ppdhd.ShowDialog();
        }

        private void pdhd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hd = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(c => c.IDHoaDon == oID);
            var kh = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(c => c.SDT_KH == hd.SDT_KH);
            var nv = _qLnhanVien.GetNhanVienFromDB().FirstOrDefault(c => c.nhanViens.IDNhanVien == hd.IDNhanVien);

            // Lấy chiều rộng của trang giấy
            var w = pdhd.DefaultPageSettings.PaperSize.Width;
            int margin = 40; // Lề trái/phải an toàn
            int y = 30;

            // Khởi tạo Font và Pen dùng chung để tiết kiệm tài nguyên
            Font fontTitle = new Font("Times New Roman", 16, FontStyle.Bold);
            Font fontHeader = new Font("Times New Roman", 12, FontStyle.Bold);
            Font fontContent = new Font("Times New Roman", 12, FontStyle.Regular);
            Font fontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Pen pn = new Pen(Color.Black, 1);

            // --- 1. PHẦN HEADER (TIÊU ĐỀ & THÔNG TIN HÓA ĐƠN) ---
            e.Graphics.DrawString("FPOLY TSHIRT", fontTitle, Brushes.Black, new Point(margin, y));

            // Số hóa đơn và Ngày giờ căn lề phải
            string invoiceNum = $"Invoice: #{hd.IDHoaDon}";
            string dateStr = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            SizeF sizeInvoice = e.Graphics.MeasureString(invoiceNum, fontBold);
            SizeF sizeDate = e.Graphics.MeasureString(dateStr, fontContent);

            e.Graphics.DrawString(invoiceNum, fontBold, Brushes.Black, new Point(w - margin - (int)sizeInvoice.Width, y));
            e.Graphics.DrawString(dateStr, fontContent, Brushes.Black, new Point(w - margin - (int)sizeDate.Width, y + 25));

            y += 60;
            // Đường kẻ ngang phân cách header
            e.Graphics.DrawLine(pn, new Point(margin, y), new Point(w - margin, y));

            // --- 2. TIÊU ĐỀ HÓA ĐƠN & KHÁCH HÀNG ---
            y += 20;
            string title = "SALES INVOICE";
            SizeF sizeTitle = e.Graphics.MeasureString(title, fontTitle);
            e.Graphics.DrawString(title, fontTitle, Brushes.Black, new Point((w - (int)sizeTitle.Width) / 2, y));

            y += 40;
            e.Graphics.DrawString($"Customer Name: {kh.TenKH}", fontContent, Brushes.Black, new Point(margin, y));
            e.Graphics.DrawString($"Phone Number: {kh.SDT_KH}", fontContent, Brushes.Black, new Point(margin, y + 25));

            y += 60;
            // Đường kẻ trước bảng sản phẩm
            e.Graphics.DrawLine(pn, new Point(margin, y), new Point(w - margin, y));

            // --- 3. TIÊU ĐỀ BẢNG SẢN PHẨM ---
            y += 10;
            int colStt = margin;
            int colName = margin + 40;
            int colQty = w - 290;
            int colPrice = w - 200;
            int colTotal = w - 90;

            e.Graphics.DrawString("No.", fontHeader, Brushes.Black, new Point(colStt, y));
            e.Graphics.DrawString("Product Name", fontHeader, Brushes.Black, new Point(colName, y));
            e.Graphics.DrawString("Qty", fontHeader, Brushes.Black, new Point(colQty, y));
            e.Graphics.DrawString("Price", fontHeader, Brushes.Black, new Point(colPrice, y));
            e.Graphics.DrawString("Total", fontHeader, Brushes.Black, new Point(colTotal, y));

            y += 25;
            e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(margin, y), new Point(w - margin, y));

            // --- 4. DANH SÁCH CHI TIẾT SẢN PHẨM ---
            int stt = 1;
            y += 10;
            var listChiTiet = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(c => c.IDHoaDon == oID).ToList();

            foreach (var x in listChiTiet)
            {
                var sp = _qlSanPhamCT.GetSanPhamCTFromDB().FirstOrDefault(p => p.IDSanPhamChiTiet == x.IDSanPham);
                string productName = sp != null ? sp.TenSP : string.Empty;
                var thanhtien = x.Soluong * x.donGia;

                e.Graphics.DrawString(stt.ToString(), fontContent, Brushes.Black, new Point(colStt, y));

                if (productName.Length > 20) productName = productName.Substring(0, 17) + "...";
                e.Graphics.DrawString(productName, fontContent, Brushes.Black, new Point(colName, y));

                e.Graphics.DrawString(x.Soluong.ToString(), fontContent, Brushes.Black, new Point(colQty, y));
                e.Graphics.DrawString(x.donGia.ToString("N0"), fontContent, Brushes.Black, new Point(colPrice, y));
                e.Graphics.DrawString(thanhtien.ToString("N0"), fontContent, Brushes.Black, new Point(colTotal, y));

                y += 25;
            }

            // --- 5. TỔNG KẾT & CHÂN TRANG ---
            y += 10;
            e.Graphics.DrawLine(pn, new Point(margin, y), new Point(w - margin, y));

            y += 20;
            string totalText = $"Total Price: {hd.tongTien:N0} $";
            SizeF sizeTotal = e.Graphics.MeasureString(totalText, fontBold);
            e.Graphics.DrawString(totalText, fontBold, Brushes.Black, new Point(w - margin - (int)sizeTotal.Width, y));

            y += 50;
            string thankYou = "THANK YOU FOR YOUR BUSINESS!";
            SizeF sizeThanks = e.Graphics.MeasureString(thankYou, fontHeader);
            e.Graphics.DrawString(thankYou, fontHeader, Brushes.Black, new Point((w - (int)sizeThanks.Width) / 2, y));
        }
    }
}
