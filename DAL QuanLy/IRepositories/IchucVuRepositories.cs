using _1_DAL_QUANLY.Models;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IchucVuRepositories
    {
        List<chucVu> GetchucVuFromDB();
        bool addChucVu(chucVu ChucVu);
        bool RemoveChucVu(chucVu ChucVu);
        bool UpdateChucVu(chucVu ChucVu);
    }
}
