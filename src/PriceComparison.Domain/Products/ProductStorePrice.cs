using PriceComparison.Domain.Common.Primitives;
using PriceComparison.Domain.Stores;

namespace PriceComparison.Domain.Products;

public class ProductStorePrice : Entity<ProductStorePriceId>
{
    public ProductId ProductId { get; private set; }
    
    public StoreId StoreId { get; private set; }
    
    public Money Price { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }

    private ProductStorePrice(ProductStorePriceId id, ProductId productId, StoreId storeId, Money price, DateTime updatedAt)
    {
        Id = id;
        ProductId = productId;
        StoreId = storeId;
        Price = price;
        UpdatedAt = updatedAt;
    }

    public static ProductStorePrice Create(ProductId productId, StoreId storeId, Money price)
    {
        return new ProductStorePrice(
            new ProductStorePriceId(Guid.NewGuid()),
            productId,
            storeId,
            price,
            DateTime.Now);
    }

    public void UpdatePrice(Money price)
    {
        Price = price;
        UpdatedAt = DateTime.Now;
    }
}