using Application.Dtos.Bling.Invoice;
using Application.Dtos.Bling.Logistic;
using Application.Dtos.Bling.Order;

namespace Application.Interfaces.Bling;

public interface IBlingClient
{
    Task<List<BlingOrderSearchDto>?> SearchOrderbyShopiyIdAsync(
        long shopifyId,
        CancellationToken cancellationToken = default
    );
    Task<BlingOrderDto?> GetOrderByIdAsync(
        long orderId,
        CancellationToken cancellationToken = default
    );
    Task<BlingInvoiceDto?> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken = default
    );
    Task<BlingLogisticDto?> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    );
}
