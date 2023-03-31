using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface ICategoryService
{
    string Add(CategoryView obj);
    string Update(CategoryView obj);
    string Delete(CategoryView obj);
    List<CategoryView> GetAll();
    List<CategoryView> GetAll(string input);
    Category GetModel(Guid id);
    Guid GetId(string input);
}
