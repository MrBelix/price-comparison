using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PriceComparison.Domain.Products;

namespace PriceComparison.Persistence.Configurations;

public class ProductStorePriceConfiguration: IEntityTypeConfiguration<ProductStorePrice>
{
    public void Configure(EntityTypeBuilder<ProductStorePrice> builder)
    {
        throw new NotImplementedException();
    }
}