using Application.Dtos.Shopify;

namespace Application.Interfaces.Shopify;

public interface IShopifyClient
{
    Task<ShopifyOrderDto?> GetOrderAsync(long id, CancellationToken cancellationToken = default);
    Task<ShopifyOrderDto?> PutOrderAsync(
        long id,
        ShopifyOrderDto order,
        CancellationToken cancellationToken = default
    );

    Task<ShopifyProductDto?> GetProductAsync(
        long id,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyProductDto?> PutProductAsync(
        long id,
        ShopifyProductDto product,
        CancellationToken cancellationToken = default
    );

    Task<ShopifyCustomerDto?> GetCustomerAsync(
        long id,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyCustomerDto?> PutCustomerAsync(
        long id,
        ShopifyCustomerDto customer,
        CancellationToken cancellationToken = default
    );
}
