using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class SizeRepo : ISizeRepo
{
    private StoreDbContext _context;

    public SizeRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Size obj)
    {
        if (obj != null)
        {
            _context.Sizes.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Size obj)
    {
        if (obj != null)
        {
            var temp = _context.Sizes.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Size> GetAll()
    {
        return _context.Sizes.ToList();
    }

    public bool Update(Size obj)
    {
        if (obj != null)
        {
            var temp = _context.Sizes.FirstOrDefault(c => c.Id == obj.Id);
            temp.SizeNumber = obj.SizeNumber;
            temp.Status = obj.Status;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
