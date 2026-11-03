using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IhoaDonChiTietRepositories
    {
        List<hoaDonChiTiet> GetHoaDonChiTietFromDB();
        bool addHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool RemoveHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
        bool UpdateHoaDonChiTiet(hoaDonChiTiet HoaDonChiTiet);
    }
}
