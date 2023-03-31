using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface IBillService
{
    string Add(BillView obj);
    string Update(BillView obj);
    string Delete(BillView obj);
    List<BillView> GetAll();
    Bill GetModel(Guid id);
    Guid GetId(string input);
}
