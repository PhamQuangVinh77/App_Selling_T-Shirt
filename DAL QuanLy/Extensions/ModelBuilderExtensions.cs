using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Extensions
{
    public static class ModelBuilderExtensions
    {
        // Những dữ liệu này sẽ được mặc định thêm vào Database khi khởi tạo
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chucVu>().HasData
                (
                new chucVu() {IDChucVu = 0, tenCV = "Quản lý" },
                new chucVu() { IDChucVu = 1, tenCV = "Nhân viên"}
                );
            modelBuilder.Entity<nhanVien>().HasData
                (
                new nhanVien() { IDNhanVien = 0, tenNV = "Admin", IDChucVu = 0, diaChi ="Hà Nội",SDT = "0902096529", email = "admin@gmail.com", matKhau = "1", tinhTrang = true  }
                );
            modelBuilder.Entity<khachHang>().HasData
                ( 
                new khachHang() { SDT_KH = "0000000000", TenKH = "Khách lẻ", gioiTinh = false, diaChi = "Hà Nội", trangThai = true, diemTichluy = 0}
                );
        }
    }
}
