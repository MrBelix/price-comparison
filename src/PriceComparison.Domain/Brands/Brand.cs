using PriceComparison.Domain.Common.Primitives;
using PriceComparison.Domain.Common.ValueObjects;

namespace PriceComparison.Domain.Brands;

public class Brand : Entity<BrandId>, IAggregateRoot
{
    public Slug Slug { get; private set; }
    
    public string Name { get; private set; }

    private Brand(BrandId id, string name, Slug slug)
    {
        Id = id;
        Name = name;
        Slug = slug;
    }

    public static Brand Create(string name, Slug slug)
    {
        return new Brand(new BrandId(Guid.NewGuid()), name, slug);
    }
}