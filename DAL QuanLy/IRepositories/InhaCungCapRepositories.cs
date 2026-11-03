using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface InhaCungCapRepositories
    {
        List<nhaCungCap> GetnhaCungCapFromDB();
        bool addnhaCungCap(nhaCungCap NhaCungCap);
        bool RemovenhaCungCap(nhaCungCap NhaCungCap);
        bool UpdatenhaCungCap(nhaCungCap NhaCungCap);
    }
}
