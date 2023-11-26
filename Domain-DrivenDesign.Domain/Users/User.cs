using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Shared;

namespace Domain_DrivenDesign.Domain.Users;

public class User : Entity
{
    private User(Guid id,Name name, Email eMail, Password password, Address address)
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

    public static User CreateUser(string name, string email, string password, string country, string city, string street, string postalCode, string fullAddress)
    {
        //business ruless

        User user = new(
            id: Guid.NewGuid(),
            name: new(name),
            eMail: new(email),
            password: new(password),
            address: new(country, city, street, fullAddress, postalCode));

        return user;
    }

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
