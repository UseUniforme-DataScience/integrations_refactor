using Application.Dtos.Bling.Order;
using Application.Interfaces.Bling;

namespace Application.Services.Bling;

public class BlingOrderService(IBlingClient blingClient) : IBlingOrderService
{
    public async Task<BlingOrderDto?> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken = default
    )
    {
        return await blingClient.GetOrderByIdAsync(orderId, cancellationToken)
            ?? throw new InvalidOperationException($"Order {orderId} not found.");
    }

    public async Task<List<BlingOrderSearchDto>?> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken = default
    )
    {
        return await blingClient.SearchOrderbyShopiyIdAsync(shopifyId, cancellationToken)
            ?? throw new InvalidOperationException($"Order {shopifyId} not found.");
    }
}
