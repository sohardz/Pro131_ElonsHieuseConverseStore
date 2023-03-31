using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class ColorService : IColorService
{
    private IColorRepo colorRepo;

    public ColorService()
    {
        colorRepo = new ColorRepo();
    }

    public string Add(ColorView obj)
    {
        if (obj != null)
        {
            var color = new Color()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                Name = obj.Name,
                Status = obj.Status,
            };
            return colorRepo.Add(color) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";

    }

    public string Update(ColorView obj)
    {
        if (obj != null)
        {
            var color = GetModel(GetId(obj.Ma));
            color.Name = obj.Name;
            color.Status = obj.Status;
            return colorRepo.Update(color) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(ColorView obj)
    {
        if (obj != null)
        {
            var color = GetModel(GetId(obj.Ma));
            return colorRepo.Delete(color) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<ColorView> GetAll()
    {
        var lst = new List<ColorView>();
        lst =
            (
                from a in colorRepo.GetAll()
                select new ColorView()
                {
                    Ma = a.Ma,
                    Name = a.Name,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<ColorView> GetAll(string input)
    {
        return string.IsNullOrEmpty(input)
            ? GetAll()
            : GetAll().Where(c => c.Name.Contains(input)).ToList();
    }

    public Color GetModel(Guid id)
    {
        return colorRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return colorRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }

}
