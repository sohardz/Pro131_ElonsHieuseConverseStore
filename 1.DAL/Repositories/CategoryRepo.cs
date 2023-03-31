using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class CategoryRepo : ICategoryRepo
{
    private StoreDbContext _context;

    public CategoryRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Category obj)
    {
        if (obj != null)
        {
            _context.Categories.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Category obj)
    {
        if (obj != null)
        {
            var temp = _context.Categories.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Category> GetAll()
    {
        return _context.Categories.ToList();
    }

    public bool Update(Category obj)
    {
        if (obj != null)
        {
            var temp = _context.Categories.FirstOrDefault(c => c.Id == obj.Id);
            temp.Name = obj.Name;
            temp.Status = obj.Status;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
