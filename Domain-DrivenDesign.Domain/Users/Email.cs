namespace Domain_DrivenDesign.Domain.Users;

public sealed record Email
{
    public string Value { get; set; }

    public Email(string value)
    {
        if (value == null) throw new ArgumentNullException("null value");
        if (value.Length < 3) throw new ArgumentOutOfRangeException("min 3 lenght");
        if (!value.Contains("@")) throw new ArgumentException("invalid email");
        
        Value = value;
    }
}
