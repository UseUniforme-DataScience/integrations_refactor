using Application.Dtos.Bling;

namespace Application.Interfaces.Bling
{
    public interface IBlingClient
    {
        Task<BlingOrderSearchResponseDto?> SearchOrderbyShopiyIdAsync(
            long shopifyId,
            CancellationToken cancellationToken = default
        );
        Task<BlingOrderResponseDto?> GetOrderAsync(
            long id,
            CancellationToken cancellationToken = default
        );
        Task<BlingNfeResponseDto?> GetNfeAsync(
            long nfeId,
            CancellationToken cancellationToken = default
        );
        Task<BlingLogisticResponseDto?> GetLogisticAsync(
            long logisticId,
            CancellationToken cancellationToken = default
        );
    }
}
