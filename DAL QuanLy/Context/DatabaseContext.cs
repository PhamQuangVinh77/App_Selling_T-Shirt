﻿using _1_DAL_QUANLY.Configurations;
using _1_DAL_QUANLY.Extensions;
using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<chucVu> chucVus { get; set; }
        public DbSet<hangSX> hangSXs { get; set; }
        public DbSet<nhaCungCap> nhaCungCaps { get; set; }
        public DbSet<chatLieu> chatLieus { get; set; }
        public DbSet<mauSac> mauSacs { get; set; }
        public DbSet<size> sizes { get; set; }
        public DbSet<hoaDon> hoaDons { get; set; }
        public DbSet<hoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<sanPham> sanPhams { get; set; }
        public DbSet<sanPhamChiTiet> sanPhamCTs { get; set; }
        public DbSet<nhanVien> nhanViens { get; set; }
        public DbSet<khachHang> khachHangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8LST6U5\SQLEXPRESS;Initial Catalog=TSHIRT_SHOP_DATA;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Chạy file Configuraions

            //Seeding data - Add data từ file ModelBuilderExtensions vào model sau khi khởi tạo
            modelBuilder.Seed();

        }
    }
}
