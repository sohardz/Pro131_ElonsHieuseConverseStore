using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class ShoesService : IShoesService
{
    private IShoesRepo shoesRepo;
    private IColorRepo colorRepo;
    private ICategoryRepo categoryRepo;
    private IMaterialRepo materialRepo;
    private ISizeRepo sizeRepo;

    private IColorService colorService;
    private ICategoryService categoryService;
    private IMaterialService materialService;
    private ISizeService sizeService;

    public ShoesService()
    {
        shoesRepo = new ShoesRepo();
        colorRepo = new ColorRepo();
        categoryRepo = new CategoryRepo();
        materialRepo = new MaterialRepo();
        sizeRepo = new SizeRepo();

        colorService = new ColorService();
        categoryService = new CategoryService();
        materialService = new MaterialService();
        sizeService = new SizeService();
    }

    public string Add(ShoesView obj)
    {
        if (obj != null)
        {
            var shoes = new Shoes()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                Name = obj.Name,
                Description = obj.Description,
                Stock = obj.Stock,
                CostPrice = obj.CostPrice,
                SalePrice = obj.SalePrice,
                ImageDirection = obj.ImageDirection,
                ColorId = colorService.GetId(obj.MaColor),
                CategoryId = categoryService.GetId(obj.MaCategory),
                MaterialId = materialService.GetId(obj.MaMaterial),
                SizeId = sizeService.GetId(obj.MaSize),
                Status = obj.Status,
            };
            return shoesRepo.Add(shoes) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";

    }

    public string Update(ShoesView obj)
    {
        if (obj != null)
        {
            var shoes = GetModel(GetId(obj.Ma));
            shoes.Name = obj.Name;
            shoes.Description = obj.Description;
            shoes.Stock = obj.Stock;
            shoes.CostPrice = obj.CostPrice;
            shoes.SalePrice = obj.SalePrice;
            shoes.ImageDirection = obj.ImageDirection;
            shoes.ColorId = colorService.GetId(obj.MaColor);
            shoes.CategoryId = categoryService.GetId(obj.MaCategory);
            shoes.MaterialId = materialService.GetId(obj.MaMaterial);
            shoes.SizeId = sizeService.GetId(obj.MaSize);
            shoes.Status = obj.Status;
            return shoesRepo.Update(shoes) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(ShoesView obj)
    {
        if (obj != null)
        {
            var shoes = GetModel(GetId(obj.Ma));
            return shoesRepo.Delete(shoes) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<ShoesView> GetAll()
    {
        var lst = new List<ShoesView>();
        lst =
            (
                from a in shoesRepo.GetAll()
                join b in categoryRepo.GetAll() on a.CategoryId equals b.Id
                join c in colorRepo.GetAll() on a.ColorId equals c.Id
                join d in materialRepo.GetAll() on a.MaterialId equals d.Id
                join e in sizeRepo.GetAll() on a.SizeId equals e.Id
                select new ShoesView()
                {
                    Ma = a.Ma,
                    Name = a.Name,
                    Description = a.Description,
                    Stock = a.Stock,
                    CostPrice = a.CostPrice,
                    SalePrice = a.SalePrice,
                    ImageDirection = a.ImageDirection,
                    MaCategory = b.Ma,
                    CategoryName = b.Name,
                    MaColor = c.Ma,
                    ColorName = c.Name,
                    MaMaterial = d.Ma,
                    MaterialName = d.Name,
                    MaSize = e.Ma,
                    SizeNumber = e.SizeNumber,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<ShoesView> GetAll(string input)
    {
        return string.IsNullOrEmpty(input)
            ? GetAll()
            : GetAll().Where(c => c.Name.Contains(input)).ToList();
    }

    public Shoes GetModel(Guid id)
    {
        return shoesRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return shoesRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
