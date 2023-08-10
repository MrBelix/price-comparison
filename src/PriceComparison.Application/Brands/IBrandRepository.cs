using PriceComparison.Application.Abstractions;
using PriceComparison.Application.Brands.Search;
using PriceComparison.Domain.Brands;

namespace PriceComparison.Application.Brands;

public interface IBrandRepository : IRepository<Brand>
{
    Task<Brand?> GetByIdAsync(BrandId brandId);
}