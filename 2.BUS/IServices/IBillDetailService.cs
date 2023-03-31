using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface IBillDetailService
{
    string Add(BillDetailView obj);
    string Update(BillDetailView obj);
    string Delete(BillDetailView obj);
    List<BillDetailView> GetAll();
    List<BillDetailView> GetAll(Guid id);
    List<BillDetailView> ShowHoadonChitiet(Guid id);
    BillDetail GetModel(Guid id);
    Guid GetId(string input);
}
