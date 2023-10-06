using Microsoft.EntityFrameworkCore;
using PriceComparison.Application.Abstractions;
using PriceComparison.Domain.Brands;
using PriceComparison.Domain.Categories;
using PriceComparison.Domain.Products;
using PriceComparison.Domain.Stores;

namespace PriceComparison.Persistence;

public class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
    
    public DbSet<Brand> Brands { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Product> Products { get; set; }
    
    public DbSet<ProductStorePrice> ProductStorePrices { get; set; }
    
    public DbSet<Store> Stores { get; set; }
    
}