using Domain_DrivenDesign.Domain.Abstraction;

namespace Domain_DrivenDesign.Domain.Users;

public class User : Entity
{
    public User(Guid id) : base(id) { }
    public string Name { get; set; }
    public string EMail { get; set; }
    public string Password { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string FullAddress { get; set; }
    public string PostalCode { get; set; }
}
