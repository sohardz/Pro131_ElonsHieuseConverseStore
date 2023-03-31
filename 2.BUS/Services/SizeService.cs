using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class SizeService : ISizeService
{
    private ISizeRepo sizeRepo;

    public SizeService()
    {
        sizeRepo = new SizeRepo();
    }

    public string Add(SizeView obj)
    {
        if (obj != null)
        {
            var Size = new Size()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                SizeNumber = obj.SizeNumber,
                Status = obj.Status,
            };
            return sizeRepo.Add(Size) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";

    }

    public string Update(SizeView obj)
    {
        if (obj != null)
        {
            var dongSp = GetModel(GetId(obj.Ma));
            dongSp.SizeNumber = obj.SizeNumber;
            dongSp.Status = obj.Status;
            return sizeRepo.Update(dongSp) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(SizeView obj)
    {
        if (obj != null)
        {
            var dongSp = GetModel(GetId(obj.Ma));
            return sizeRepo.Delete(dongSp) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<SizeView> GetAll()
    {
        var lst = new List<SizeView>();
        lst =
            (
                from a in sizeRepo.GetAll()
                select new SizeView()
                {
                    Ma = a.Ma,
                    SizeNumber = a.SizeNumber,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<SizeView> GetAll(string input)
    {
        return string.IsNullOrEmpty(input)
            ? GetAll()
            : GetAll().Where(c => c.SizeNumber == Convert.ToInt32(input)).ToList();
    }

    public Size GetModel(Guid id)
    {
        return sizeRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return sizeRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
