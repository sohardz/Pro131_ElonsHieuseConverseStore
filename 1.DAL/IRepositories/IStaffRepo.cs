using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface IStaffRepo
{
    bool Add(Staff obj);
    bool Update(Staff obj);
    bool Delete(Staff obj);
    List<Staff> GetAll();
}
