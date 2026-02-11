using Application.Dtos.Shopify;

namespace Application.Interfaces.Shopify;

public interface IShopifyOrderService
{
    Task<ShopifyOrderDto> GetOrderByIdAsync(long id, CancellationToken cancellationToken = default);
    Task<ShopifyOrderDto> UpdateOrderAsync(
        ShopifyOrderDto order,
        CancellationToken cancellationToken = default
    );
}
