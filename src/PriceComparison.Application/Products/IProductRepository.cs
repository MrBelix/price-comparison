using PriceComparison.Application.Abstractions;
using PriceComparison.Domain.Products;

namespace PriceComparison.Application.Products;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetByIdAsync(ProductId productId);
}