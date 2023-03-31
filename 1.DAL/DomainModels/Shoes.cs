namespace _1.DAL.DomainModels;
public class Shoes
{
    public Guid Id { get; set; }
    public string Ma { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Stock { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SalePrice { get; set; }
    public string? ImageDirection { get; set; }
    public int Status { get; set; }
    public Guid SizeId { get; set; }
    public Guid ColorId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid MaterialId { get; set; }
    public virtual Size? Size { get; set; }
    public virtual Color? Color { get; set; }
    public virtual Category? Category { get; set; }
    public virtual Material? Material { get; set; }
    public ICollection<BillDetail> BillDetails { get; set; }
}
