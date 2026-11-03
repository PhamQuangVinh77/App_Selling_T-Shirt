
using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using DAL_QuanLy.Context;

namespace _1_DAL_QUANLY.Repositories
{
    public class chucVuRepositories : IchucVuRepositories
    {
        private List<chucVu> _lstChucVu;
        private DatabaseContext _context;
        public chucVuRepositories()
        {
            _lstChucVu = new List<chucVu>();
            _context = new DatabaseContext();
        }
        public bool addChucVu(chucVu ChucVu)
        {
            _context.Add(ChucVu);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveChucVu(chucVu ChucVu)
        {
            _context.Remove(ChucVu);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateChucVu(chucVu ChucVu)
        {
            _context.Update(ChucVu);
            _context.SaveChanges();
            return true;
        }

        public List<chucVu> GetchucVuFromDB()
        {
            _lstChucVu = _context.chucVus.ToList();
            return _lstChucVu;
        }
    }
}
