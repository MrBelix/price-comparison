using PriceComparison.Domain.Brands;
using PriceComparison.Domain.Categories;
using PriceComparison.Domain.Common.Primitives;
using PriceComparison.Domain.Common.ValueObjects;
using PriceComparison.Domain.Stores;

namespace PriceComparison.Domain.Products;

public class Product : Entity<ProductId>, IAggregateRoot
{
    private readonly List<ProductStorePrice> _prices = new();
    
    public Slug Slug { get; private set;}
    
    public BrandId BrandId { get; private set; }
    
    public CategoryId CategoryId { get; private set; }
    
    public Sku Sku { get; private set; }

    public Ean Ean { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;
    
    public IReadOnlyList<ProductStorePrice> Prices => _prices.AsReadOnly();

    private Product()
    {
    }

    private Product(
        ProductId productId,
        string name,
        string description,
        Slug slug,
        BrandId brandId,
        CategoryId categoryId,
        Sku sku,
        Ean ean) : this()
    {
        Id = productId;
        Slug = slug;
        BrandId = brandId;
        CategoryId = categoryId;
        Sku = sku;
        Ean = ean;
        Name = name;
        Description = description;
    }

    public static Product Create(
        string name,
        string description,
        Slug slug,
        BrandId brandId,
        CategoryId categoryId,
        Sku sku,
        Ean ean)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentNullException(nameof(description));
        }

        if (slug is null)
        {
            throw new ArgumentNullException(nameof(slug));
        }

        if (brandId is null)
        {
            throw new ArgumentNullException(nameof(brandId));
        }

        if (categoryId is null)
        {
            throw new ArgumentNullException(nameof(categoryId));
        }

        if (sku is null)
        {
            throw new ArgumentNullException(nameof(sku));
        }

        if (ean is null)
        {
            throw new ArgumentNullException(nameof(ean));
        }
        
        return new Product(
            new ProductId(Guid.NewGuid()),
            name,
            description,
            slug,
            brandId,
            categoryId,
            sku,
            ean);
    }

    public void CreateOrUpdatePrice(StoreId storeId, Money price)
    {
        var storePrice = _prices.FirstOrDefault(sp => sp.StoreId == storeId);

        if (storePrice is null)
        {
            _prices.Add(ProductStorePrice.Create(Id, storeId, price));
        }
        else
        {
            storePrice.UpdatePrice(price);
        }
    }
}