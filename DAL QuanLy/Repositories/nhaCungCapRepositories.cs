
using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using DAL_QuanLy.Context;

namespace _1_DAL_QUANLY.Repositories
{
    public class nhaCungCapRepositories : InhaCungCapRepositories
    {
        private List<nhaCungCap> _lstnhaCungCap;
        private DatabaseContext _context;
        public nhaCungCapRepositories()
        {
            _lstnhaCungCap = new List<nhaCungCap>();
            _context = new DatabaseContext();
        }
        public bool addnhaCungCap(nhaCungCap NhaCungCap)
        {
            _context.Add(NhaCungCap);
            _context.SaveChanges();
            return true;
        }

        public List<nhaCungCap> GetnhaCungCapFromDB()
        {
            _lstnhaCungCap = _context.nhaCungCaps.ToList();
            return _lstnhaCungCap;
        }

        public bool RemovenhaCungCap(nhaCungCap NhaCungCap)
        {
            _context.Remove(NhaCungCap);
            _context.SaveChanges();
            return true;
        }

        public bool UpdatenhaCungCap(nhaCungCap NhaCungCap)
        {
            _context.Update(NhaCungCap);
            _context.SaveChanges();
            return true;
        }
    }
}
