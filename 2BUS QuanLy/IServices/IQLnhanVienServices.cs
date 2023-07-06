using _1_DAL_QUANLY.Models;
using _2_BUS_QUANLY.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLnhanVienServices
    {
        List<ViewHienThi> GetNhanVienFromDB();
        string addNhanVien(ViewHienThi NhanVien);
        string RemoveNhanVien(ViewHienThi NhanVien);
        string UpdateNhanVien(ViewHienThi NhanVien);
        //List<ViewHienThi> getViewNhanVien();
        List<nhanVien> GetAll();
    }
}  
