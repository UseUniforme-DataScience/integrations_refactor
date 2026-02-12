using Application.Dtos.Bling;

namespace Application.Interfaces.Bling;

public interface IBlingLogisticService
{
    Task<BlingLogisticResponseDto> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    );
}
