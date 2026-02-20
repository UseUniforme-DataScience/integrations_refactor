using System.Text.Json;
using Application.Constants;
using Application.Constants.Caching;
using Application.Dtos.Bling.Order;
using Application.Interfaces.Bling;
using Domain.Interfaces;

namespace Application.Services.Bling;

public class BlingOrderService(IBlingClient blingClient, IRedisService redisService)
    : IBlingOrderService
{
    public async Task<BlingOrderDto?> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken = default
    )
    {
        var key = $"{BlingConstants.BlingOrder}:{orderId}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<BlingOrderDto>(cached);
        }
        else
        {
            var order =
                await blingClient.GetOrderByIdAsync(orderId, cancellationToken)
                ?? throw new InvalidOperationException($"Order {orderId} not found.");
            if (order is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(order),
                    CacheDurations.BlingOrder
                );
                return order;
            }
            return null;
        }
    }

    public async Task<List<BlingOrderSearchDto>?> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken = default
    )
    {
        var key = $"{BlingConstants.BlingOrderSearch}:{shopifyId}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<List<BlingOrderSearchDto>>(cached);
        }
        else
        {
            var orders =
                await blingClient.SearchOrderbyShopiyIdAsync(shopifyId, cancellationToken)
                ?? throw new InvalidOperationException($"Order {shopifyId} not found.");
            if (orders.Count > 0)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(orders),
                    CacheDurations.BlingOrderSearch
                );
                return orders;
            }
            return [];
        }
    }
}
