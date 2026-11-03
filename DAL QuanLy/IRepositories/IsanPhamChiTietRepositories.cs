using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IsanPhamChiTietRepositories
    {
        List<sanPhamChiTiet> GetSanPhamFromDB();
        bool addsanPham(sanPhamChiTiet sanPhamCT);
        bool RemoveSanPham(sanPhamChiTiet sanPhamCT);
        bool UpdateSanPham(sanPhamChiTiet sanPhamCT);
    }
}
