namespace _2.BUS.ViewModels;

public class BillView
{
    public string Ma { get; set; }
    public DateTime DateofCreation { get; set; }
    public DateTime? DateofPayment { get; set; }
    public string MaKh { get; set; }
    public string CustomerName { get; set; }
    public string MaNv { get; set; }
    public string StaffName { get; set; }
    public int Status { get; set; }
    public decimal TotalCost { get; set; }
}
