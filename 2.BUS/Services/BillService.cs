using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services;

public class BillService : IBillService
{
    private IBillRepo billRepo;
    private CustomerRepo customerRepo;
    private StaffRepo staffRepo;

    private ICustomerService customerService;
    private IStaffService staffService;

    public BillService()
    {
        billRepo = new BillRepo();
        customerRepo = new CustomerRepo();
        staffRepo = new StaffRepo();

        customerService = new CustomerService();
        staffService = new StaffService();
    }

    public string Add(BillView obj)
    {
        if (obj != null)
        {
            var bill = new Bill()
            {
                Id = Guid.Empty,
                Ma = obj.Ma,
                CustomerId = customerService.GetId(obj.MaKh),
                StaffId = staffService.GetId(obj.MaNv),
                DateofCreation = obj.DateofCreation,
                DateofPayment = obj.DateofPayment,
                Status = obj.Status,
            };
            return billRepo.Add(bill) ? "thêm thành công" : "thêm thất bại";
        }
        return "thêm thất bại";
    }

    public string Update(BillView obj)
    {
        if (obj != null)
        {
            var bill = GetModel(GetId(obj.Ma));
            bill.CustomerId = string.IsNullOrEmpty(obj.MaKh) ? Guid.Empty : customerService.GetId(obj.MaKh);
            bill.StaffId = staffService.GetId(obj.MaNv);
            bill.DateofCreation = obj.DateofCreation;
            bill.DateofPayment = obj.DateofPayment;
            bill.Status = obj.Status;
            return billRepo.Update(bill) ? "sửa thành công" : "sửa thất bại";
        }
        return "sửa thất bại";
    }

    public string Delete(BillView obj)
    {
        if (obj != null)
        {
            var Bill = GetModel(GetId(obj.Ma));
            return billRepo.Delete(Bill) ? "xóa thành công" : "xóa thất bại";
        }
        return "xóa thất bại";
    }

    public List<BillView> GetAll()
    {
        var lst = new List<BillView>();
        lst =
            (
                from a in billRepo.GetAll()
                join b in customerRepo.GetAll() on a.CustomerId equals b.Id
                join c in staffRepo.GetAll() on a.StaffId equals c.Id
                select new BillView()
                {
                    Ma = a.Ma,
                    MaNv = c.Ma,
                    MaKh = b.Ma,
                    DateofCreation = a.DateofCreation,
                    DateofPayment = a.DateofPayment,
                    CustomerName = b.FirstName,
                    StaffName = c.FirstName,
                    Status = a.Status,
                }
            ).ToList();
        return lst;
    }

    public Bill GetModel(Guid id)
    {
        return billRepo.GetAll().FirstOrDefault(c => c.Id == id);
    }

    public Guid GetId(string input)
    {
        return billRepo.GetAll().FirstOrDefault(c => c.Ma == input).Id;
    }
}
