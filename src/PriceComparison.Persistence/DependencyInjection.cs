using Microsoft.Extensions.DependencyInjection;

namespace PriceComparison.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        return services;
    }
}