using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IsanPhamRepositories
    {
        List<sanPham> GetsanPhamFromDB();
        bool addsanPham(sanPham SanPham);
        bool RemovesanPham(sanPham SanPham);
        bool UpdatesanPham(sanPham SanPham);
    }
}
