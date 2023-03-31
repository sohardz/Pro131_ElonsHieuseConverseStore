using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class CustomerService : ICustomerService
{
    private ICustomerRepo customerRepo;

    public CustomerService()
    {
        customerRepo = new CustomerRepo();
    }

    public string Add(CustomerView obj)
    {
        if (obj != null)
        {
            var Customer = new Customer()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                FirstName = obj.FirstName,
                MiddleName = obj.MiddleName,
                LastName = obj.LastName,
                Address = obj.Address,
                PhoneNumber = obj.PhoneNumber,
                Status = obj.Status,
            };
            return customerRepo.Add(Customer) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";

    }

    public string Update(CustomerView obj)
    {
        if (obj != null)
        {
            var customer = GetModel(GetId(obj.Ma));
            customer.FirstName = obj.FirstName;
            customer.MiddleName = obj.MiddleName;
            customer.LastName = obj.LastName;
            customer.Address = obj.Address;
            customer.PhoneNumber = obj.PhoneNumber;
            customer.Status = obj.Status;
            return customerRepo.Update(customer) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(CustomerView obj)
    {
        if (obj != null)
        {
            var customer = GetModel(GetId(obj.Ma));
            return customerRepo.Delete(customer) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<CustomerView> GetAll()
    {
        var lst = new List<CustomerView>();
        lst =
            (
                from a in customerRepo.GetAll()
                select new CustomerView()
                {
                    Ma = a.Ma,
                    FirstName = a.FirstName,
                    MiddleName = a.MiddleName,
                    LastName = a.LastName,
                    Address = a.Address,
                    PhoneNumber = a.PhoneNumber,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<CustomerView> GetAll(string input)
    {
        return string.IsNullOrEmpty(input)
            ? GetAll()
            : GetAll().Where(c => c.FirstName.Contains(input)).ToList();
    }

    public Customer GetModel(Guid id)
    {
        return customerRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return customerRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
