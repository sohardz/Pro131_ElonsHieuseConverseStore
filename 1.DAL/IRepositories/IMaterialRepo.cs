using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface IMaterialRepo
{
    bool Add(Material obj);
    bool Update(Material obj);
    bool Delete(Material obj);
    List<Material> GetAll();
}
