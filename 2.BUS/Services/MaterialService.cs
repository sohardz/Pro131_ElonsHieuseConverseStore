using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class MaterialService : IMaterialService
{
    private IMaterialRepo materialRepo;

    public MaterialService()
    {
        materialRepo = new MaterialRepo();
    }

    public string Add(MaterialView obj)
    {
        if (obj != null)
        {
            var material = new Material()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                Name = obj.Name,
                Status = obj.Status,
            };
            return materialRepo.Add(material) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";

    }

    public string Update(MaterialView obj)
    {
        if (obj != null)
        {
            var material = GetModel(GetId(obj.Ma));
            material.Name = obj.Name;
            material.Status = obj.Status;
            return materialRepo.Update(material) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(MaterialView obj)
    {
        if (obj != null)
        {
            var material = GetModel(GetId(obj.Ma));
            return materialRepo.Delete(material) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<MaterialView> GetAll()
    {
        var lst = new List<MaterialView>();
        lst =
            (
                from a in materialRepo.GetAll()
                select new MaterialView()
                {
                    Ma = a.Ma,
                    Name = a.Name,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<MaterialView> GetAll(string input)
    {
        return string.IsNullOrEmpty(input)
            ? GetAll()
            : GetAll().Where(c => c.Name.Contains(input)).ToList();
    }

    public Material GetModel(Guid id)
    {
        return materialRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return materialRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
