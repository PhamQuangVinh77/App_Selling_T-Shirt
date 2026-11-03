using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IhangSXRepositories
    {
        List<hangSX> GetHangSXFromDB();
        bool addHangSX(hangSX HangSX);
        bool RemoveHangSX(hangSX HangSX);
        bool UpdateHangSX(hangSX HangSX);
    }
}
