using PriceComparison.Domain.Common.Primitives;
using PriceComparison.Domain.Common.ValueObjects;

namespace PriceComparison.Domain.Categories;

public class Category : Entity<CategoryId>, IAggregateRoot
{
    public Slug Slug { get; private set; }
    
    public string Name { get; private set; }

    private Category(CategoryId categoryId, string name, Slug slug)
    {
        Id = categoryId;
        Name = name;
        Slug = slug;
    }

    public static Category Create(string name, Slug slug)
    {
        return new Category(new CategoryId(Guid.NewGuid()), name, slug);
    }
}