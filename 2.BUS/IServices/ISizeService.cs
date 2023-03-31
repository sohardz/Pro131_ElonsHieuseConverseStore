using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface ISizeService
{
    string Add(SizeView obj);
    string Update(SizeView obj);
    string Delete(SizeView obj);
    List<SizeView> GetAll();
    List<SizeView> GetAll(string input);
    Size GetModel(Guid id);
    Guid GetId(string input);
}
