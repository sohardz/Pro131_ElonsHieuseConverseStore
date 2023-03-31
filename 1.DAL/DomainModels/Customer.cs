namespace _1.DAL.DomainModels;

public class Customer
{
    public Guid Id { get; set; }
    public string Ma { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int Status { get; set; }
    public ICollection<Bill> Bills { get; set; }
}
