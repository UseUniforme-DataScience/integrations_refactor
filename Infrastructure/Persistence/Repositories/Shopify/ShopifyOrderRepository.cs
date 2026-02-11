using Domain.Entities.Shopify;
using Domain.Interfaces.Repositories.Shopify;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Shopify;

public class ShopifyOrderRepository(AppDbContext context) : IShopifyOrderRepository
{
    public async Task<ShopifyOrder> AddOrderAsync(
        ShopifyOrder order,
        CancellationToken cancellationToken = default
    )
    {
        await context.ShopifyOrders.AddAsync(order, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        return order;
    }

    public async Task<ShopifyOrder?> DeleteOrderAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var order =
            await context.ShopifyOrders.FirstOrDefaultAsync(x => x.Id == id, cancellationToken)
            ?? throw new InvalidOperationException($"Order {id} not found in database.");

        context.ShopifyOrders.Remove(order);
        await context.SaveChangesAsync(cancellationToken);
        return order;
    }

    public async Task<ShopifyOrder?> GetOrderByCpfAsync(
        string cpf,
        CancellationToken cancellationToken = default
    )
    {
        return await context
                .ShopifyOrders.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Cpf == cpf, cancellationToken)
            ?? throw new InvalidOperationException($"Order {cpf} not found in database.");
    }

    public async Task<ShopifyOrder?> GetOrderByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        return await context
                .ShopifyOrders.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken)
            ?? throw new InvalidOperationException($"Order {id} not found in database.");
    }

    public async Task<ShopifyOrder?> UpdateOrderAsync(
        ShopifyOrder order,
        CancellationToken cancellationToken = default
    )
    {
        var existingOrder =
            await context
                .ShopifyOrders.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == order.Id, cancellationToken)
            ?? throw new InvalidOperationException($"Order {order.Id} not found in database.");

        context.Entry(existingOrder).CurrentValues.SetValues(order);

        context.ShopifyOrders.Remove(existingOrder);

        await context.SaveChangesAsync(cancellationToken);
        return existingOrder;
    }
}
