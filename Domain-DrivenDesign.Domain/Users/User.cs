using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Shared;

namespace Domain_DrivenDesign.Domain.Users;

public class User : Entity
{
    public User(Guid id,Name name, Email eMail, Password password, Address address)
    : base(id)
    {
        Name = name;
        EMail = eMail;
        Password = password;
        Address = address;
    }

    public Name Name { get; private set; }
    public Email EMail { get; private set; }
    public Password Password { get; private set; }
    public Address Address { get; private set; }

    public void ChangeName(string name)
    {
        Name = new(name);
    }

    public void ChangeAddress(string country,string city,string street,
        string fullAddress, string postalCode)
    {
        Address = new(country, city, street, fullAddress, postalCode);
    }

    public void ChangePassword(string password)
    {
        Password = new(password);
    }

}
