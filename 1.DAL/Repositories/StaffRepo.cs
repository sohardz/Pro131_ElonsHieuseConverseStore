using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories;
public class StaffRepo : IStaffRepo
{
    private StoreDbContext _context;

    public StaffRepo()
    {
        _context = new StoreDbContext();
    }

    public bool Add(Staff obj)
    {
        if (obj != null)
        {
            _context.Staffs.Add(obj);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Delete(Staff obj)
    {
        if (obj != null)
        {
            var temp = _context.Staffs.FirstOrDefault(c => c.Id == obj.Id);
            _context.Remove(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Staff> GetAll()
    {
        return _context.Staffs.ToList();
    }

    public bool Update(Staff obj)
    {
        if (obj != null)
        {
            var temp = _context.Staffs.FirstOrDefault(c => c.Id == obj.Id);
            temp.FirstName = obj.FirstName;
            temp.MiddleName = obj.MiddleName;
            temp.LastName = obj.LastName;
            temp.Sex = obj.Sex;
            temp.Dob = obj.Dob;
            temp.Email = obj.Email;
            temp.Password = obj.Password;
            temp.PhoneNumber = obj.PhoneNumber;
            temp.Address = obj.Address;
            temp.Status = obj.Status;
            temp.ImageDirection = obj.ImageDirection;
            _context.Update(temp);
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
