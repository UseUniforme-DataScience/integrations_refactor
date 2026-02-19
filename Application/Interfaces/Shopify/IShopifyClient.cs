using Application.Dtos.Shopify.Customer;
using Application.Dtos.Shopify.Order;
using Application.Dtos.Shopify.Product;

namespace Application.Interfaces.Shopify;

public interface IShopifyClient
{
    Task<ShopifyOrderDto?> GetOrderAsync(long id, CancellationToken cancellationToken = default);
    Task<List<ShopifyOrderDto>?> GetOrdersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyOrderDto?> PutOrderAsync(
        long id,
        ShopifyOrderRequestDto order,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyProductDto?> GetProductAsync(
        long id,
        CancellationToken cancellationToken = default
    );
    Task<List<ShopifyProductDto>?> GetProductsAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyProductDto?> PutProductAsync(
        long id,
        ShopifyProductRequestDto product,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyCustomerDto?> GetCustomerAsync(
        long id,
        CancellationToken cancellationToken = default
    );
    Task<List<ShopifyCustomerDto>?> GetCustomersAsync(
        DateTime? updatedBefore,
        DateTime? updatedAfter,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyCustomerDto?> PutCustomerAsync(
        long id,
        ShopifyCustomerRequestDto customer,
        CancellationToken cancellationToken = default
    );
}
