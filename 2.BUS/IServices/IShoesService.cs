using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface IShoesService
{
    string Add(ShoesView obj);
    string Update(ShoesView obj);
    string Delete(ShoesView obj);
    List<ShoesView> GetAll();
    List<ShoesView> GetAll(string input);
    Shoes GetModel(Guid id);
    Guid GetId(string input);
}
