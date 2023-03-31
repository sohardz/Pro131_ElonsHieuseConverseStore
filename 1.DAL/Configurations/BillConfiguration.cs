using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations;
internal class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Ma).HasColumnType("varchar(30)").IsRequired();
        builder.Property(p => p.DateofCreation).HasColumnType("datetime").IsRequired();
        builder.Property(p => p.DateofPayment).HasColumnType("datetime");
        builder.Property(p => p.Status).HasColumnType("int").IsRequired();
        builder.HasOne(p => p.Customer).WithMany(p => p.Bills).HasForeignKey(p => p.CustomerId);
        builder.HasOne(p => p.Staff).WithMany(p => p.Bills).HasForeignKey(p => p.StaffId);
    }
}
