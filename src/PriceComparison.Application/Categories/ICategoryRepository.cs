using PriceComparison.Application.Abstractions;
using PriceComparison.Domain.Categories;

namespace PriceComparison.Application.Categories;

public interface ICategoryRepository : IRepository<Category>
{
    Task<Category?> GetByIdAsync(CategoryId categoryId);
}