using PriceComparison.Application.Abstractions;
using PriceComparison.Application.Brands.Search;
using PriceComparison.Domain.Common.ValueObjects;

namespace PriceComparison.Application.Brands;

public interface IBrandReadService
{
    Task<IPagedList<BrandResponse>> SearchAsync(string search, int page, int pageSize);

    Task<BrandResponse> GetBySlugAsync(string slug);
}