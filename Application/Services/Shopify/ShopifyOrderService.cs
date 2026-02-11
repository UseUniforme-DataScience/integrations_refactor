using Application.Dtos.Shopify;
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

    public async Task<ShopifyOrderDto> UpdateOrderAsync(
        ShopifyOrderDto order,
        CancellationToken cancellationToken = default
    )
    {
        var updated = await shopifyClient
            .PutOrderAsync(order.Id, order, cancellationToken)
            .ConfigureAwait(false);
        return updated ?? throw new InvalidOperationException($"Order {order.Id} not found.");
    }
}
