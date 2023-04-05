using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace _1.DAL.Context;
internal class StoreDbContext : DbContext
{
    public virtual DbSet<Bill> Bills { get; set; }
    public virtual DbSet<BillDetail> BillDetails { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Color> Colors { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Material> Materials { get; set; }
    public virtual DbSet<Shoes> Shoes { get; set; }
    public virtual DbSet<Size> Sizes { get; set; }
    public virtual DbSet<Staff> Staffs { get; set; }

    public StoreDbContext()
    {
    }

    public StoreDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=DESKTOP-P5GSVI1\\SQLEXPRESS;Initial Catalog=ConverseStore;Persist Security Info=True;User ID=cuongnpm;Password=123456"));

        //base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=NKHOC\\SQLEXPRESS;Initial Catalog=ConverseStore;Persist Security Info=True;User ID=hocnk;Password=123456"));

        //base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=LEMINHHIEU\\SQLEXPRESS;Initial Catalog=ShoeStoreProjectOne;Persist Security Info=True;User ID=lmaohieu;Password=1"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
