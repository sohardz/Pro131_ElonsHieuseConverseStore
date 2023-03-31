using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class BillDetailRepo : IBillDetailRepo
{
    private StoreDbContext _context;

    public BillDetailRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(BillDetail obj)
    {
        if (obj != null)
        {
            _context.BillDetails.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(BillDetail obj)
    {
        if (obj != null)
        {
            var temp = _context.BillDetails.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<BillDetail> GetAll()
    {
        return _context.BillDetails.ToList();
    }

    public bool Update(BillDetail obj)
    {
        if (obj != null)
        {
            var temp = _context.BillDetails.FirstOrDefault(c => c.Id == obj.Id);
            temp.Quantity = obj.Quantity;
            temp.UnitPrice = obj.UnitPrice;
            temp.Status = obj.Status;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
