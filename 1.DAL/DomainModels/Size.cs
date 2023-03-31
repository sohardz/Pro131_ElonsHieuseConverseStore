namespace _1.DAL.DomainModels;

public class Size
{
    public Guid Id { get; set; }
    public string Ma { get; set; }
    public int SizeNumber { get; set; }
    public int Status { get; set; }
    public ICollection<Shoes> Shoes { get; set; }
}
