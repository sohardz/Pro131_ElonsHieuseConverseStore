using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations;
internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Ma).HasColumnType("varchar(30)").IsRequired();
        builder.Property(p => p.FirstName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(p => p.MiddleName).HasColumnType("nvarchar(50)");
        builder.Property(p => p.LastName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(p => p.PhoneNumber).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.Address).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(p => p.Status).HasColumnType("int").IsRequired();
    }
}
