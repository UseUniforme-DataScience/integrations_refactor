using Application.Dtos.Shopify.Order;
using Application.Interfaces.Shopify;

namespace Application.Services.Shopify;

public class ShopifyOrderService(IShopifyClient shopifyClient) : IShopifyOrderService
{
    public async Task<ShopifyOrderDto> GetOrderByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var order = await shopifyClient.GetOrderAsync(id, cancellationToken).ConfigureAwait(false);
        return order ?? throw new InvalidOperationException($"Order {id} not found.");
    }

    public async Task<List<ShopifyOrderDto>> GetOrdersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    )
    {
        var orders = await shopifyClient
            .GetOrdersAsync(updatedBefore, updatedAfter, cancellationToken)
            .ConfigureAwait(false);
        return orders ?? [];
    }

    public async Task<ShopifyOrderDto> UpdateOrderAsync(
        ShopifyOrderRequestDto order,
        CancellationToken cancellationToken = default
    )
    {
        var updated = await shopifyClient
            .PutOrderAsync(order.Id, order, cancellationToken)
            .ConfigureAwait(false);
        return updated ?? throw new InvalidOperationException($"Order {order.Id} not found.");
    }
}
