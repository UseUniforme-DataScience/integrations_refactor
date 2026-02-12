using Application.Dtos.Bling;

namespace Application.Interfaces.Bling;

public interface IBlingClient
{
    Task<BlingOrderSearchResponseDto?> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken = default
    );
    Task<BlingOrderResponseDto?> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken = default
    );
    Task<BlingInvoiceResponseDto?> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken = default
    );
    Task<BlingLogisticResponseDto?> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    );
}
