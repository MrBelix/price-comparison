namespace PriceComparison.Domain.Products;

public record Ean
{
    public string Value { get; init; }

    private Ean(string value) => Value = value;

    public static Ean? Create(string value)
    {
        return new Ean(value);
    }
}