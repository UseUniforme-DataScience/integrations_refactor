using Application.Dtos.Bling.Order;

namespace Application.Interfaces.Bling;

public interface IBlingOrderService
{
    Task<List<BlingOrderSearchDto>?> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken = default
    );

    Task<BlingOrderDto?> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken = default
    );
}
