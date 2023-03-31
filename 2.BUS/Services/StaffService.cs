using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class StaffService : IStaffService
{
    private IStaffRepo staffRepo;

    public StaffService()
    {
        staffRepo = new StaffRepo();
    }

    public string Add(StaffView obj)
    {
        if (obj != null)
        {
            var staff = new Staff()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                FirstName = obj.FirstName,
                MiddleName = obj.MiddleName,
                LastName = obj.LastName,
                Sex = obj.Sex,
                Dob = obj.DoB,
                Address = obj.Address,
                PhoneNumber = obj.PhoneNumber,
                Email = obj.Email,
                Password = obj.Password,
                ImageDirection = obj.ImageDirection,
                Status = obj.Status,
            };
            return staffRepo.Add(staff) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";

    }

    public string Update(StaffView obj)
    {
        if (obj != null)
        {
            var staff = GetModel(GetId(obj.Ma));
            staff.FirstName = obj.FirstName;
            staff.MiddleName = obj.MiddleName;
            staff.LastName = obj.LastName;
            staff.Sex = obj.Sex;
            staff.Dob = obj.DoB;
            staff.Address = obj.Address;
            staff.PhoneNumber = obj.PhoneNumber;
            staff.Email = obj.Email;
            staff.Password = obj.Password;
            staff.ImageDirection = obj.ImageDirection;
            staff.Status = obj.Status;
            return staffRepo.Update(staff) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(StaffView obj)
    {
        if (obj != null)
        {
            var staff = GetModel(GetId(obj.Ma));
            return staffRepo.Delete(staff) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<StaffView> GetAll()
    {
        var lst = new List<StaffView>();
        lst =
            (
                from a in staffRepo.GetAll()
                select new StaffView()
                {
                    Ma = a.Ma,
                    FirstName = a.FirstName,
                    MiddleName = a.MiddleName,
                    LastName = a.LastName,
                    Sex = a.Sex,
                    DoB = a.Dob,
                    Address = a.Address,
                    PhoneNumber = a.PhoneNumber,
                    Email = a.Email,
                    Password = a.Password,
                    ImageDirection = a.ImageDirection,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<StaffView> GetAll(string input)
    {
        return string.IsNullOrEmpty(input)
            ? GetAll()
            : GetAll().Where(c => c.FirstName.Contains(input)).ToList();
    }

    public Staff GetModel(Guid id)
    {
        return staffRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return staffRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
