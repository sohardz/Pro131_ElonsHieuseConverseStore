using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class CustomerRepo : ICustomerRepo
{
    private StoreDbContext _context;

    public CustomerRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Customer obj)
    {
        if (obj != null)
        {
            _context.Customers.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Customer obj)
    {
        if (obj != null)
        {
            var temp = _context.Customers.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Customer> GetAll()
    {
        return _context.Customers.ToList();
    }

    public bool Update(Customer obj)
    {
        if (obj != null)
        {
            var temp = _context.Customers.FirstOrDefault(c => c.Id == obj.Id);
            temp.FirstName = obj.FirstName;
            temp.MiddleName = obj.MiddleName;
            temp.LastName = obj.LastName;
            temp.PhoneNumber = obj.PhoneNumber;
            temp.Address = obj.Address;
            temp.Status = obj.Status;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
