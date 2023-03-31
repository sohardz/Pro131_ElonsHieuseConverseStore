using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class MaterialRepo : IMaterialRepo
{
    private StoreDbContext _context;

    public MaterialRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Material obj)
    {
        if (obj != null)
        {
            _context.Materials.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Material obj)
    {
        if (obj != null)
        {
            var temp = _context.Materials.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Material> GetAll()
    {
        return _context.Materials.ToList();
    }

    public bool Update(Material obj)
    {
        if (obj != null)
        {
            var temp = _context.Materials.FirstOrDefault(c => c.Id == obj.Id);
            temp.Name = obj.Name;
            temp.Status = obj.Status;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
