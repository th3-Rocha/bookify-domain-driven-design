namespace Bookify.Domain.Shared;

public class Currency
{
    public static readonly Currency None = new("");
    public static readonly Currency Usd = new("Usd");
    public static readonly Currency Eur = new("Eur");
    private Currency(string code) => Code = code;
    
    
    public string Code { get; init; }


    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code) ??
               throw new ArgumentException($"The currency code '{code}' is invalid.", nameof(code));
        
    }

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Usd,
        Eur
    };
}