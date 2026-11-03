using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IhoaDonRepositories
    {
        List<hoaDon> GetHoaDonFromDB();
        bool addHoaDon(hoaDon HoaDon);
        bool RemoveHoaDon(hoaDon HoaDon);
        bool UpdateHoaDon(hoaDon HoaDon);
    }
}
