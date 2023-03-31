using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface IMaterialService
{
    string Add(MaterialView obj);
    string Update(MaterialView obj);
    string Delete(MaterialView obj);
    List<MaterialView> GetAll();
    List<MaterialView> GetAll(string input);
    Material GetModel(Guid id);
    Guid GetId(string input);
}
