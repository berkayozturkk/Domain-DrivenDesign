namespace Domain_DrivenDesign.Domain.Users;

public sealed record Password
{
    public string Value { get; set; }

    public Password(string value)
    {
        if (value == null) throw new ArgumentNullException("null value");
        if (value.Length < 6) throw new ArgumentOutOfRangeException("min 3 lenght");
        if (!ContainsUpperCase(value)) throw new ArgumentException(nameof(value), "Password must contain at least one uppercase letter");
        if (!ContainsLowerCase(value)) throw new ArgumentException(nameof(value), "Password must contain at least one lowercase letter");

        Value = value;
    }

    private static bool ContainsUpperCase(string value)
    {
        return value.Any(char.IsUpper);
    }

    private static bool ContainsLowerCase(string value)
    {
        return value.Any(char.IsLower);
    }
}
