using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations;
internal class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Ma).HasColumnType("varchar(30)").IsRequired();
        builder.Property(p => p.FirstName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(p => p.MiddleName).HasColumnType("nvarchar(50)");
        builder.Property(p => p.LastName).HasColumnType("nvarchar(15)").IsRequired();
        builder.Property(p => p.Sex).HasColumnType("int").IsRequired();
        builder.Property(p => p.Dob).HasColumnType("date").IsRequired();
        builder.Property(p => p.Address).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(p => p.PhoneNumber).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.Email).HasColumnType("varchar(150)").IsRequired();
        builder.Property(p => p.Password).HasColumnType("varchar(15)").IsRequired();
        builder.Property(p => p.ImageDirection).HasColumnType("varchar(500)");
        builder.Property(p => p.Status).HasColumnType("int").IsRequired();
    }
}
