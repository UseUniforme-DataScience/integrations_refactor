using Domain.Entities.Shopify;
using Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<ShopifyCustomer> ShopifyCustomers => Set<ShopifyCustomer>();

    public DbSet<ShopifyProducts> ShopifyProducts => Set<ShopifyProducts>();

    public DbSet<ShopifyOrder> ShopifyOrders => Set<ShopifyOrder>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        modelBuilder.UseSnakeCaseNames();
        base.OnModelCreating(modelBuilder);
    }
}
