using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface InhanVienRepositories
    {
        List<nhanVien> GetnhanVienFromDB();
        bool addNhanVien(nhanVien NhanVien);
        bool RemoveNhanVien(nhanVien NhanVien);
        bool UpdateNhanVien(nhanVien NhanVien);
    }
}
