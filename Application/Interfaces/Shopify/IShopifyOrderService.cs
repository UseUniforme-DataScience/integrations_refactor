using Application.Dtos.Shopify.Order;

namespace Application.Interfaces.Shopify;

public interface IShopifyOrderService
{
    Task<ShopifyOrderDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken = default);
    Task<ShopifyOrderDto> UpdateOrderAsync(
        ShopifyOrderRequestDto order,
        CancellationToken cancellationToken = default
    );
}
