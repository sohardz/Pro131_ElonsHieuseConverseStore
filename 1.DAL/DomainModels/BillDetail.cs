namespace _1.DAL.DomainModels;
public class BillDetail
{
    public Guid Id { get; set; }
    public string Ma { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public int Status { get; set; }
    public Guid ShoesId { get; set; }
    public Guid BillId { get; set; }
    public virtual Shoes? Shoes { get; set; }
    public virtual Bill? Bill { get; set; }
}
