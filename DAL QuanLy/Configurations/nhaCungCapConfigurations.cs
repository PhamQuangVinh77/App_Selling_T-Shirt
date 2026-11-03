using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_QUANLY.Configurations
{
    public class nhaCungCapConfigurations : IEntityTypeConfiguration<nhaCungCap>
    {
        public void Configure(EntityTypeBuilder<nhaCungCap> builder)
        {
            // Đặt tên bảng
            builder.ToTable("nhaCungCap");
            // Set khóa chính
            builder.HasKey(x => x.IDNhaCungCap);
            builder.Property(x => x.IDNhaCungCap).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenNhaCungCap).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
