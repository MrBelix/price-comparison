using PriceComparison.Application.Abstractions;
using PriceComparison.Domain.Common.ValueObjects;
using PriceComparison.Domain.Products;

namespace PriceComparison.Application.Products;

public interface IProductReadService
{
    Task<IPagedList<ProductResponse>> SearchAsync(string search, int page, int pageSize);

    Task<ProductResponse> GetBySlugAsync(string slug);
}