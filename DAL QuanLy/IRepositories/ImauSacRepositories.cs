using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface ImauSacRepositories
    {
        List<mauSac> GetMauSacFromDB();
        bool addMauSac(mauSac MauSac);
        bool RemoveMauSac(mauSac MauSac);
        bool UpdateMauSac(mauSac MauSac);
    }
}
