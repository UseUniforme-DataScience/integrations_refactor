using Application.Dtos.Bling.Logistic;

namespace Application.Interfaces.Bling;

public interface IBlingLogisticService
{
    Task<BlingLogisticDto?> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    );
}
