using System.Text.Json;
using Application.Constants;
using Application.Constants.Caching;
using Application.Dtos.Shopify.Order;
using Application.Interfaces.Shopify;
using Domain.Interfaces;

namespace Application.Services.Shopify;

public class ShopifyOrderService(IShopifyClient shopifyClient, IRedisService redisService)
    : IShopifyOrderService
{
    public async Task<ShopifyOrderDto?> GetOrderByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    )
    {
        var key = $"{ShopifyConstants.ShopifyOrder}:{id}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<ShopifyOrderDto>(cached);
        }
        else
        {
            var order = await shopifyClient
                .GetOrderAsync(id, cancellationToken)
                .ConfigureAwait(false);
            if (order is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(order),
                    CacheDurations.ShopifyOrder
                );
                return order;
            }
            return null;
        }
    }

    public async Task<List<ShopifyOrderDto>?> GetOrdersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    )
    {
        var updatedBeforeString = updatedBefore is not null
            ? updatedBefore.Value.ToUniversalTime()
            : DateTime.Now.AddDays(-7).ToUniversalTime();
        var updatedAfterString = updatedAfter is not null
            ? updatedAfter.Value.ToUniversalTime()
            : DateTime.Now.ToUniversalTime();

        var key = $"{ShopifyConstants.ShopifyOrders}:{updatedBeforeString}:{updatedAfterString}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<List<ShopifyOrderDto>>(cached);
        }
        else
        {
            var orders = await shopifyClient
                .GetOrdersAsync(updatedBeforeString, updatedAfterString, cancellationToken)
                .ConfigureAwait(false);
            if (orders is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(orders),
                    CacheDurations.ShopifyOrders
                );
                return orders;
            }
            return null;
        }
    }

    public async Task<ShopifyOrderDto?> UpdateOrderAsync(
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
