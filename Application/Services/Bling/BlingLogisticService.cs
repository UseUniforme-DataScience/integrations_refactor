using Application.Dtos.Bling;
using Application.Interfaces.Bling;

namespace Application.Services.Bling;

public class BlingLogisticService(IBlingClient blingClient) : IBlingLogisticService
{
    public async Task<BlingLogisticResponseDto> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    )
    {
        return await blingClient.GetLogisticByIdAsync(logisticId, cancellationToken)
            ?? throw new InvalidOperationException($"Logistic {logisticId} not found.");
    }
}
