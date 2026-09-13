namespace Bookify.Domain.Shared;

public record Money(decimal Amount, Currency Currency)
{

    public static Money operator +(Money first, Money second) => Add(first, second);
    public static Money Add(Money first, Money second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        return first.Currency == second.Currency 
            ? new Money(first.Amount + second.Amount, first.Currency) 
            : throw new InvalidOperationException("Currencies have to be equal");
    }
    public static Money Zero() => new(0, Currency.None);
    public static Money Zero(Currency currency) => new(0, currency);
    public bool IsZero() => this == Zero(Currency);

}