using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface IShoesRepo
{
    bool Add(Shoes obj);
    bool Update(Shoes obj);
    bool Delete(Shoes obj);
    List<Shoes> GetAll();
}
