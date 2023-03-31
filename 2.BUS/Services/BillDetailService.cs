using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class BillDetailService : IBillDetailService
{
    private IBillRepo billRepo;
    private IBillDetailRepo billDetailRepo;
    private IShoesRepo shoesRepo;

    private IShoesService shoesService;
    private IBillService billService;

    public BillDetailService()
    {
        billRepo = new BillRepo();
        billDetailRepo = new BillDetailRepo();
        shoesRepo = new ShoesRepo();

        shoesService = new ShoesService();
        billService = new BillService();
    }

    public string Add(BillDetailView obj)
    {
        if (obj != null)
        {
            var hoaDonChiTiet = new BillDetail()
            {
                Id = Guid.Empty,
                BillId = billService.GetId(obj.MaBill),
                ShoesId = shoesService.GetId(obj.MaShoes),
                Ma = obj.Ma,
                Quantity = obj.Quantity,
                UnitPrice = obj.UnitPrice,
                Status = obj.Status,
            };
            return billDetailRepo.Add(hoaDonChiTiet) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";
    }

    public string Update(BillDetailView obj)
    {
        if (obj != null)
        {
            var hoaDonChiTiet = GetModel(GetId(obj.Ma));
            hoaDonChiTiet.Quantity = obj.Quantity;
            hoaDonChiTiet.UnitPrice = obj.UnitPrice;
            hoaDonChiTiet.Status = obj.Status;
            return billDetailRepo.Update(hoaDonChiTiet) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(BillDetailView obj)
    {
        if (obj != null)
        {
            var hoaDonChiTiet = GetModel(GetId(obj.Ma));
            return billDetailRepo.Delete(hoaDonChiTiet) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<BillDetailView> GetAll()
    {
        var lst = new List<BillDetailView>();
        lst =
            (
                from a in billDetailRepo.GetAll()
                join b in billRepo.GetAll() on a.BillId equals b.Id
                join c in shoesRepo.GetAll() on a.ShoesId equals c.Id
                select new BillDetailView()
                {
                    Ma = a.Ma,
                    MaBill = b.Ma,
                    MaShoes = c.Ma,
                    Quantity = a.Quantity,
                    UnitPrice = a.UnitPrice,
                    Total = a.Quantity * a.UnitPrice,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<BillDetailView> GetAll(Guid id)
    {
        var lst = new List<BillDetailView>();
        lst =
            (
                from a in billDetailRepo.GetAll()
                join b in billRepo.GetAll() on a.BillId equals b.Id
                join c in shoesRepo.GetAll() on a.ShoesId equals c.Id
                where a.BillId == id
                select new BillDetailView()
                {
                    Ma = a.Ma,
                    MaBill = b.Ma,
                    MaShoes = c.Ma,
                    Quantity = a.Quantity,
                    UnitPrice = a.UnitPrice,
                    Total = a.Quantity * a.UnitPrice,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public List<BillDetailView> ShowHoadonChitiet(Guid id)
    {
        var lst = new List<BillDetailView>();
        lst =
            (
                from a in billDetailRepo.GetAll()
                join b in billRepo.GetAll() on a.BillId equals b.Id
                join c in shoesRepo.GetAll() on a.ShoesId equals c.Id
                where a.BillId == id
                select new BillDetailView()
                {
                    Ma = c.Ma,
                    ShoesName = c.Name,
                    Quantity = a.Quantity,
                    UnitPrice = a.UnitPrice,
                    Total = a.Quantity * a.UnitPrice,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public BillDetail GetModel(Guid id)
    {
        return billDetailRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return billDetailRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
