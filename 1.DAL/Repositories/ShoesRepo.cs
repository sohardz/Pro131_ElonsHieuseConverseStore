using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class ShoesRepo : IShoesRepo
{
    private StoreDbContext _context;

    public ShoesRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Shoes obj)
    {
        if (obj != null)
        {
            _context.Shoes.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Shoes obj)
    {
        if (obj != null)
        {
            var temp = _context.Shoes.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Shoes> GetAll()
    {
        return _context.Shoes.ToList();
    }

    public bool Update(Shoes obj)
    {
        if (obj != null)
        {
            var temp = _context.Shoes.FirstOrDefault(c => c.Id == obj.Id);
            temp.Name = obj.Name;
            temp.Description = obj.Description;
            temp.CostPrice = obj.CostPrice;
            temp.SalePrice = obj.SalePrice;
            temp.SizeId = obj.SizeId;
            temp.ColorId = obj.ColorId;
            temp.MaterialId = obj.MaterialId;
            temp.CategoryId = obj.CategoryId;
            temp.Status = obj.Status;
            temp.ImageDirection = obj.ImageDirection;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
