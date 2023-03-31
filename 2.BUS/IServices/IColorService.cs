using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface IColorService
{
    string Add(ColorView obj);
    string Update(ColorView obj);
    string Delete(ColorView obj);
    List<ColorView> GetAll();
    List<ColorView> GetAll(string input);
    Color GetModel(Guid id);
    Guid GetId(string input);
}
