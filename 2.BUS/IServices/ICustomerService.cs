using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface ICustomerService
{
    string Add(CustomerView obj);
    string Update(CustomerView obj);
    string Delete(CustomerView obj);
    List<CustomerView> GetAll();
    List<CustomerView> GetAll(string input);
    Customer GetModel(Guid id);
    Guid GetId(string input);
}
