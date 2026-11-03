using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IkhachHangRepositories
    {
        List<khachHang> GetkhachHangFromDB();
        bool addkhachHang(khachHang KhachHang);
        bool RemoveKhachHang(khachHang KhachHang);
        bool UpdateKhachHang(khachHang KhachHang);
    }
}
