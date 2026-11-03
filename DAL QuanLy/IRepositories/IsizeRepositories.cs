using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IsizeRepositories
    {
        List<size> GetSizeFromDB();
        bool addsize(size Size);
        bool RemoveSize(size Size);
        bool UpdateSize(size Size);
    }
}
