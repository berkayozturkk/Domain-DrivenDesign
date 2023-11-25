namespace Domain_DrivenDesign.Domain.Shared;

public sealed record Name
{
    public string Value { get; set; }
    public Name(string value)
    {
        if (value == null) throw new ArgumentNullException("null value");
        if (value.Length < 3) throw new ArgumentOutOfRangeException("min 3 lenght");

        Value = value;
    }
}

public sealed record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("Usd");
    public static readonly Currency TRY = new("TRY");
    public string Code { get; init; }

    private Currency(string code)
    {
        Code = code;
    }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code) ??
            throw new ArgumentException("Valid currency");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, TRY };
}

public sealed record Money(decimal Amount,Currency Currency)
{
    public static Money operator +(Money a,Money b)
    {
        if (a.Currency != b.Currency)
            throw new ArgumentException("We cannot collect two different units");

        return new(a.Amount + b.Amount, a.Currency);
    }

    public static Money Zero() => new(0, Currency.None);
    public static Money Zero(Currency currency) => new(0, currency);

    public bool IsZero() => this == Zero(Currency);
}
