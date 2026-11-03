using _1_DAL_QUANLY.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_QUANLY.Configurations
{
    public class hangSXConfigurations : IEntityTypeConfiguration<hangSX>
    {
        public void Configure(EntityTypeBuilder<hangSX> builder)
        {
            // Đặt tên bảng
            builder.ToTable("hangSX");
            // Set khóa chính
            builder.HasKey(x => x.IDHangSX);
            builder.Property(x => x.IDHangSX).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.tenHangSX).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
