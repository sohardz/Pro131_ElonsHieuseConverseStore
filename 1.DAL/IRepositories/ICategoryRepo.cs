using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface ICategoryRepo
{
    bool Add(Category obj);
    bool Update(Category obj);
    bool Delete(Category obj);
    List<Category> GetAll();
}
