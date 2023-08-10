using System.Text.RegularExpressions;

namespace PriceComparison.Domain.Common.ValueObjects;

public partial record Slug
{
    [GeneratedRegex("[a-z0-9\\-]+")]
    private static partial Regex _regex();
    
    public string Value { get; init; }
    
    private Slug(string value) => Value = value;
    
    public static explicit operator string(Slug sku) => sku.Value;
    
    public static Slug? Create(string value)
    {
        if (string.IsNullOrEmpty(value) || _regex().IsMatch(value))
        {
            return null;
        }

        return new Slug(value);
    }
}