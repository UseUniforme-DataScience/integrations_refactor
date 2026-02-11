using Application.Dtos.Shopify;

namespace Application.Interfaces.Shopify;

public interface IShopifyCustomerService
{
    Task<ShopifyCustomerDto> GetCustomerByIdAsync(long id);
    Task<ShopifyCustomerDto> UpdateCustomerAsync(long id, ShopifyCustomerDto customer);
}
