using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices;

public interface IStaffService
{
    string Add(StaffView obj);
    string Update(StaffView obj);
    string Delete(StaffView obj);
    List<StaffView> GetAll();
    List<StaffView> GetAll(string input);
    Staff GetModel(Guid id);
    Guid GetId(string input);
}
