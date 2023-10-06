using PriceComparison.Domain.Common.Primitives;


namespace PriceComparison.Domain.Stores;

public class Store: Entity<StoreId>, IAggregateRoot
{
    public string Name { get; private set; }

    private Store(StoreId storeId, string name)
    {
        Id = storeId;
        Name = name;
    }

    public static Store Create(string name)
    {
        return new Store(new StoreId(Guid.NewGuid()), name);
    }
}