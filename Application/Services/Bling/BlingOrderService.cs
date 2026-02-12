using Application.Dtos.Bling;
using Application.Interfaces.Bling;

namespace Application.Services.Bling;

public class BlingOrderService(IBlingClient blingClient) : IBlingOrderService
{
    public async Task<BlingOrderResponseDto> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken = default
    )
    {
        return await blingClient.GetOrderByIdAsync(orderId, cancellationToken)
            ?? throw new InvalidOperationException($"Order {orderId} not found.");
    }

    public async Task<BlingOrderSearchResponseDto> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken = default
    )
    {
        return await blingClient.SearchOrderbyShopiyIdAsync(shopifyId, cancellationToken)
            ?? throw new InvalidOperationException($"Order {shopifyId} not found.");
    }
}
