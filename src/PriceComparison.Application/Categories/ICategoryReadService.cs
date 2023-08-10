using PriceComparison.Application.Abstractions;
using PriceComparison.Domain.Common.ValueObjects;

namespace PriceComparison.Application.Categories;

public interface ICategoryReadService
{
    Task<IPagedList<CategoryResponse>> SearchAsync(string search, int page, int pageSize);
    
    Task<CategoryResponse> GetBySlugAsync(string slug);
}