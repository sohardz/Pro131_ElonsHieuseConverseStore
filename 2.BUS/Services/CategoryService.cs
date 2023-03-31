using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class CategoryService : ICategoryService
{
    private ICategoryRepo categoryRepo;

    public CategoryService()
    {
        categoryRepo = new CategoryRepo();
    }

    public string Add(CategoryView obj)
    {
        if (obj != null)
        {
            var category = new Category()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                Name = obj.Name,
                Status = obj.Status,
            };
            return categoryRepo.Add(category) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";

    }

    public string Update(CategoryView obj)
    {
        if (obj != null)
        {
            var category = GetModel(GetId(obj.Ma));
            category.Name = obj.Name;
            category.Status = obj.Status;
            return categoryRepo.Update(category) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(CategoryView obj)
    {
        if (obj != null)
        {
            var category = GetModel(GetId(obj.Ma));
            return categoryRepo.Delete(category) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<CategoryView> GetAll()
    {
        var lst = new List<CategoryView>();
        lst =
            (
                from a in categoryRepo.GetAll()
                select new CategoryView()
                {
                    Ma = a.Ma,
                    Name = a.Name,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<CategoryView> GetAll(string input)
    {
        return string.IsNullOrEmpty(input)
            ? GetAll()
            : GetAll().Where(c => c.Name.Contains(input)).ToList();
    }

    public Category GetModel(Guid id)
    {
        return categoryRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return categoryRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
