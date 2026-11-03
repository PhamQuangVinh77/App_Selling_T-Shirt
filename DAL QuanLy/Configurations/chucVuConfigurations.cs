using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_QUANLY.Configurations
{
    public class chucVuConfigurations : IEntityTypeConfiguration<chucVu>
    {
        public void Configure(EntityTypeBuilder<chucVu> builder)
        {
            //đặt tên bảng
            builder.ToTable("chucVu");
            //đặt khóa chính
            builder.HasKey(x => x.IDChucVu);
            builder.Property(X => X.IDChucVu).UseIdentityColumn(1, 1);
            //đặt ràng buộc
            builder.Property(x => x.tenCV).IsRequired();
        }
    }
}
