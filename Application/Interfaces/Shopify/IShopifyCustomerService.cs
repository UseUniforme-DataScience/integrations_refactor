using Application.Dtos.Shopify.Customer;

namespace Application.Interfaces.Shopify;

public interface IShopifyCustomerService
{
    Task<ShopifyCustomerDto> GetCustomerByIdAsync(
        long id,
        CancellationToken cancellationToken = default
    );
    Task<ShopifyCustomerDto> UpdateCustomerAsync(
        long id,
        ShopifyCustomerRequestDto customer,
        CancellationToken cancellationToken = default
    );
}
