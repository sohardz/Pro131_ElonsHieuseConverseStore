using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface ICustomerRepo
{
    bool Add(Customer obj);
    bool Update(Customer obj);
    bool Delete(Customer obj);
    List<Customer> GetAll();
}
