using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories;
public interface IBillDetailRepo
{
    bool Add(BillDetail obj);
    bool Update(BillDetail obj);
    bool Delete(BillDetail obj);
    List<BillDetail> GetAll();
}
