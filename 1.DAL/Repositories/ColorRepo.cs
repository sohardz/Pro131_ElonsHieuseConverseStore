using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class ColorRepo : IColorRepo
{
    private StoreDbContext _context;

    public ColorRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Color obj)
    {
        if (obj != null)
        {
            _context.Colors.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Color obj)
    {
        if (obj != null)
        {
            var temp = _context.Colors.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Color> GetAll()
    {
        return _context.Colors.ToList();
    }

    public bool Update(Color obj)
    {
        if (obj != null)
        {
            var temp = _context.Colors.FirstOrDefault(c => c.Id == obj.Id);
            temp.Name = obj.Name;
            temp.Status = obj.Status;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
