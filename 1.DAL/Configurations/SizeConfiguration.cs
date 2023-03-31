using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations;
internal class SizeConfiguration : IEntityTypeConfiguration<Size>
{
    public void Configure(EntityTypeBuilder<Size> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Ma).HasColumnType("varchar(30)").IsRequired();
        builder.Property(p => p.SizeNumber).HasColumnType("int").IsRequired();
        builder.Property(p => p.Status).HasColumnType("int").IsRequired();
    }
}
