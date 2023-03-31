using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations;
internal class ShoesConfiguration : IEntityTypeConfiguration<Shoes>
{
    public void Configure(EntityTypeBuilder<Shoes> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Ma).HasColumnType("varchar(30)").IsRequired();
        builder.Property(p => p.Name).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(p => p.Description).HasColumnType("nvarchar(1000)").IsRequired();
        builder.Property(p => p.Stock).HasColumnType("int").IsRequired();
        builder.Property(p => p.CostPrice).HasColumnType("decimal").IsRequired();
        builder.Property(p => p.SalePrice).HasColumnType("decimal").IsRequired();
        builder.Property(p => p.ImageDirection).HasColumnType("varchar(500)");
        builder.Property(p => p.Status).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.Color).WithMany(p => p.Shoes).HasForeignKey(p => p.ColorId);
        builder.HasOne(p => p.Category).WithMany(p => p.Shoes).HasForeignKey(p => p.CategoryId);
        builder.HasOne(p => p.Material).WithMany(p => p.Shoes).HasForeignKey(p => p.MaterialId);
        builder.HasOne(p => p.Size).WithMany(p => p.Shoes).HasForeignKey(p => p.SizeId);
    }
}
