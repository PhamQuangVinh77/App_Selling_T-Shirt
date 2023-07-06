using _1_DAL_QUANLY.Models;
using _2.BUS.Services;
using _2_BUS_QUANLY.IServices;
using _2_BUS_QUANLY.Services;
using _2_BUS_QUANLY.ViewModel;
using OfficeOpenXml;
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
        }

        private void LoadMauSac()
        {
            cbb_mauSac.Items.Clear();
            cbb_mauSac.Items.Add("Tất cả");
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
            cbb_hangSX.Items.Add("Tất cả");
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
            cbb_size.Items.Add("Tất cả");
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
            dtgv_DSSP.Columns[1].Name = "Mã SP";
            dtgv_DSSP.Columns[2].Name = "Tên SP";
            dtgv_DSSP.Columns[3].Name = "Hãng SX";
            dtgv_DSSP.Columns[4].Name = "Màu sắc";
            dtgv_DSSP.Columns[5].Name = "Size";
            dtgv_DSSP.Columns[6].Name = "Giá bán";
            dtgv_DSSP.Columns[7].Name = "SL tồn";
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


            };
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
                MessageBox.Show("Sản phẩm tạm thời hết hàng!");
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
                    MessageBox.Show("Bạn đã mua hết số lượng hàng trong kho!");
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
            dtgv_gioHang.Columns[1].Name = "Mã SP";
            dtgv_gioHang.Columns[2].Name = "Tên SP";
            dtgv_gioHang.Columns[3].Name = "Số lượng";
            dtgv_gioHang.Columns[4].Name = "Đơn giá";

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
                    MessageBox.Show("Hãy chọn sản phẩm trong giỏ hàng cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!");
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
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!");
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
                MessageBox.Show("Vui lòng nhập đủ thông tin khách hàng!");
                return;
            }

            if (ValidateInput.CheckSDT(txt_SDT.Text) == false)
            {
                MessageBox.Show("Sai định dạng SĐT!");
                return;
            }

            var listKH = _qlKhachHang.GetkhachHangFromDB();
            foreach (var item in listKH)
            {
                if (txt_SDT.Text == item.SDT_KH)
                {
                    MessageBox.Show("SĐT đã được đăng ký! Vui lòng sử dụng SĐT khác!");
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
            MessageBox.Show("Thêm khách hàng mới thành công!");

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
                MessageBox.Show("Hãy chọn khách hàng!");
                return;
            }
            if (gioHang.Any())
            {
                // Xem trong danh sách đơn hàng chờ đã có đơn nào của khách hàng hiện tại hay chưa
                var existHD = _qlhoaDon.GetHoaDonFromDB().Where(x => x.trangThai == false).Where(x => x.ghiChu == "Chờ thanh toán...").FirstOrDefault(x => x.SDT_KH == txt_SDT.Text);
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
                    MessageBox.Show("Đã gộp với hóa đơn chờ có sẵn!");
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
                        ghiChu = "Chờ thanh toán...",
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
                    MessageBox.Show("Tạo hóa đơn thành công!");
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
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!");
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
            dtgv_HoadonCho.Columns[0].Name = "ID hóa đơn";
            dtgv_HoadonCho.Columns[0].Visible = false;
            dtgv_HoadonCho.Columns[1].Name = "SĐT khách hàng";
            dtgv_HoadonCho.Columns[2].Name = "Tên khách hàng";
            dtgv_HoadonCho.Columns[3].Name = "ID nhân viên";
            dtgv_HoadonCho.Columns[3].Visible = false;
            dtgv_HoadonCho.Columns[4].Name = "Thời gian tạo";

            dtgv_HoadonCho.Rows.Clear();
            var hdCho = _qlhoaDon.getViewhoaDon().Where(x => x.hoaDons.trangThai == false).Where(x => x.hoaDons.ghiChu == "Chờ thanh toán...");
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
            txt_GhiChu.Text = "Đã thanh toán";
        }

        private void btn_huyDon_Click(object sender, EventArgs e)
        {
            var donHangCho = _qlhoaDon.GetHoaDonFromDB().FirstOrDefault(x => x.IDHoaDon == IdinDonHangCho);
            if (donHangCho == null)
            {
                MessageBox.Show("Hãy chọn đơn hàng cần hủy!");
            }
            else
            {
                donHangCho.ghiChu = "Đã hủy đơn";
                _qlhoaDon.UpdateHoaDon(donHangCho);

                // Trả lại số lượng các sp trong đơn bị hủy về kho
                var lstSP = _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(x => x.IDHoaDon == IdinDonHangCho);
                foreach (var item in lstSP)
                {
                    var sp = _qlSanPhamCT.GetSanPhamCTFromDB().FirstOrDefault(x => x.IDSanPhamChiTiet == item.IDSanPham);
                    sp.soLuong += item.Soluong;
                    if(sp.trangThai == false) sp.trangThai = true;
                    _qlSanPhamCT.UpdateSanPham(sp);
                }
                MessageBox.Show("Hủy đơn hàng thành công!");
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
                    MessageBox.Show("Nhập lỗi! Chỉ được phép nhập số!");
                    txt_giamGia.Text = "0";
                    return;
                }
            }
            if (Convert.ToInt32(txt_giamGia.Text) > _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == HoaDon.SDT_KH).diemTichluy)
            {
                MessageBox.Show("Không đủ điểm tích lũy để sử dụng thêm!");
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
                    MessageBox.Show("Nhập lỗi! Chỉ được phép nhập số!");
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
                MessageBox.Show("Hãy chọn hóa đơn để thanh toán!");
            }
            else if (txt_TienThua.Text == "")
            {
                MessageBox.Show("Khách chưa trả đủ tiền!");
            }
            else
            {
                // Trừ số điểm tích lũy đã dùng + điểm tích lũy cộng thêm
                var kh = _qlKhachHang.GetkhachHangFromDB().FirstOrDefault(x => x.SDT_KH == txt_SDT.Text);
                if (kh.TenKH != "Khách lẻ")
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
                MessageBox.Show($"Thanh toán thành công!");
                LoadSanPham();
                InHoaDon();
            }
        }
        private void btn_thanhtoanngay_Click(object sender, EventArgs e)
        {
            if (cbb_KhachHang.Text == "")
            {
                MessageBox.Show("Hãy chọn khách hàng!");
                return;
            };
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
                    ghiChu = "Chờ thanh toán...",
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
                txt_GhiChu.Text = "Đã thanh toán";
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
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn!");
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

            //lấy chiều rộng của giấy
            var w = pdhd.DefaultPageSettings.PaperSize.Width;
            //
            e.Graphics.DrawString("FPOLY TSHIRT", new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, 20));

            e.Graphics.DrawString(String.Format("Mã Hóa Đơn : {0}", hd.IDHoaDon), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, 20));
            e.Graphics.DrawString(String.Format(" {0}", DateTime.Now.ToString()), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, 45));

            //
            Pen pn = new Pen(Color.Black, 1);

            var y = 70;
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(pn, p1, p2);
            y += 10;
            e.Graphics.DrawString(String.Format("HÓA ĐƠN BÁN HÀNG"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 - 100, y));
            y += 50;
            e.Graphics.DrawString(String.Format("Tên Khách Hàng: {0}", kh.TenKH), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
            e.Graphics.DrawString(String.Format("SĐT: {0}", kh.SDT_KH), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y + 30));
            y += 70;
            e.Graphics.DrawString(String.Format("STT"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
            e.Graphics.DrawString(String.Format("Tên Sản Phẩm"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, y));
            e.Graphics.DrawString(String.Format("Số Lượng"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2, y));
            e.Graphics.DrawString(String.Format("Đơn Giá"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y));
            e.Graphics.DrawString(String.Format("Thành Tiền"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
            /////
            ///
            int stt = 1;
            y += 20;

            foreach (var x in _qlhoaDonChiTiet.GetHoaDonChiTietFromDB().Where(c => c.IDHoaDon == oID))
            {
                var a = _qlSanPhamCT.GetSanPhamCTFromDB().FirstOrDefault(p => p.IDSanPhamChiTiet == x.IDSanPham).TenSP;
                var thanhtien = x.Soluong * x.donGia;
                e.Graphics.DrawString(String.Format("{0}", stt++), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(10, y));
                e.Graphics.DrawString(String.Format("{0}", a), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, y));
                e.Graphics.DrawString(String.Format("{0}", x.Soluong), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2, y));
                e.Graphics.DrawString(String.Format("{0}", x.donGia), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y));
                e.Graphics.DrawString(String.Format("{0}", thanhtien), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y));
                y += 20;
            }
            y += 20;
            e.Graphics.DrawLine(pn, p1, p2);
            y += 20;
            e.Graphics.DrawString(String.Format("TỔNG TIỀN: {0} VNĐ", hd.tongTien), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y));
            y += 100;
            e.Graphics.DrawString(String.Format("CẢM ƠN QUÝ KHÁCH!"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 - 100, y));
        }
    }
}
