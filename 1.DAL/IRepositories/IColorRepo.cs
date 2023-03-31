using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface IColorRepo
{
    bool Add(Color obj);
    bool Update(Color obj);
    bool Delete(Color obj);
    List<Color> GetAll();
}
