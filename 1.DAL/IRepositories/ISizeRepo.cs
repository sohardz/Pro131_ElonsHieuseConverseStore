using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface ISizeRepo
{
    bool Add(Size obj);
    bool Update(Size obj);
    bool Delete(Size obj);
    List<Size> GetAll();
}
