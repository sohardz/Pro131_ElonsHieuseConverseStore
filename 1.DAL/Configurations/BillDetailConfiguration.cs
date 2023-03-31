using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations;
internal class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
{
    public void Configure(EntityTypeBuilder<BillDetail> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Ma).HasColumnType("varchar(30)").IsRequired();
        builder.Property(p => p.Quantity).HasColumnType("int").IsRequired();
        builder.Property(p => p.UnitPrice).HasColumnType("decimal").IsRequired();
        builder.Property(p => p.Status).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.Bill).WithMany(p => p.BillDetails).HasForeignKey(p => p.BillId);
        builder.HasOne(p => p.Shoes).WithMany(p => p.BillDetails).HasForeignKey(p => p.ShoesId);
    }
}
