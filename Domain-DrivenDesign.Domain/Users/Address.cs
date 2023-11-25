namespace Domain_DrivenDesign.Domain.Users;

public sealed record Address(
    string Country,
    string City,
    string Street,
    string FullAddress, string PostalCode);
