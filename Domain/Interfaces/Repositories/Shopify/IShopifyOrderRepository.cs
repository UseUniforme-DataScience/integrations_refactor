using Domain.Entities.Shopify;

namespace Domain.Interfaces.Repositories.Shopify;

public interface IShopifyOrderRepository
{
    Task<ShopifyOrder> AddOrderAsync(
        ShopifyOrder order,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyOrder?> UpdateOrderAsync(
        ShopifyOrder order,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyOrder?> DeleteOrderAsync(long id, CancellationToken cancellationToken = default);
    Task<ShopifyOrder?> GetOrderByIdAsync(long id, CancellationToken cancellationToken = default);

    Task<ShopifyOrder?> GetOrderByCpfAsync(
        string cpf,
        CancellationToken cancellationToken = default
    );
}
