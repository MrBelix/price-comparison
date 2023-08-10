using PriceComparison.Application.Abstractions;
using PriceComparison.Domain.Stores;

namespace PriceComparison.Application.Stores;

public interface IStoreRepository : IRepository<Store>
{
    Task<Store?> GetByIdAsync(StoreId storeId);
}