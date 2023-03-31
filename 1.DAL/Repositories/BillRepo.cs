using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class BillRepo : IBillRepo
{
    private StoreDbContext _context;

    public BillRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Bill obj)
    {
        if (obj != null)
        {
            _context.Bills.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Bill obj)
    {
        if (obj != null)
        {
            var temp = _context.Bills.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Bill> GetAll()
    {
        return _context.Bills.ToList();
    }

    public bool Update(Bill obj)
    {
        if (obj != null)
        {
            var temp = _context.Bills.FirstOrDefault(c => c.Id == obj.Id);
            temp.DateofPayment = obj.DateofPayment;
            temp.Status = obj.Status;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
