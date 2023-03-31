using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface IBillRepo
{
    bool Add(Bill obj);
    bool Update(Bill obj);
    bool Delete(Bill obj);
    List<Bill> GetAll();
}
