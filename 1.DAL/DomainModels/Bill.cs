namespace _1.DAL.DomainModels;
public class Bill
{
    public Guid Id { get; set; }
    public string Ma { get; set; }
    public DateTime DateofCreation { get; set; }
    public DateTime? DateofPayment { get; set; }
    public int Status { get; set; }
    public Guid CustomerId { get; set; }
    public Guid StaffId { get; set; }
    public virtual Customer? Customer { get; set; }
    public virtual Staff? Staff { get; set; }
    public ICollection<BillDetail> BillDetails { get; set; }
}
