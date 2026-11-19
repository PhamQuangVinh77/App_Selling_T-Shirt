using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_QUANLY.Extensions
{
    public static class ModelBuilderExtensions
    {
        // Những dữ liệu này sẽ được mặc định thêm vào Database khi khởi tạo
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chucVu>().HasData
                (
                new chucVu() { IDChucVu = 1, tenCV = "Manager" },
                new chucVu() { IDChucVu = 2, tenCV = "Staff" }
                );
            modelBuilder.Entity<nhanVien>().HasData
                (
                new nhanVien() { IDNhanVien = 1, tenNV = "Manager", IDChucVu = 1, diaChi = "", SDT = "0902096529", email = "manager@gmail.com", matKhau = "1", tinhTrang = true }
                );
            modelBuilder.Entity<khachHang>().HasData
                (
                new khachHang() { SDT_KH = "0000000000", TenKH = "Guest", gioiTinh = false, diaChi = "", trangThai = true, diemTichluy = 0 }
                );
        }
    }
}
