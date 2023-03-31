namespace _1.DAL.DomainModels;
public class Material
{
    public Guid Id { get; set; }
    public string Ma { get; set; }
    public string Name { get; set; }
    public int Status { get; set; }
    public ICollection<Shoes> Shoes { get; set; }
}
