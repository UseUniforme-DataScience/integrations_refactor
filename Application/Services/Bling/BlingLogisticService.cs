using Application.Dtos.Bling.Logistic;
using Application.Interfaces.Bling;

namespace Application.Services.Bling;

public class BlingLogisticService(IBlingClient blingClient) : IBlingLogisticService
{
    public async Task<BlingLogisticDto?> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    )
    {
        return await blingClient.GetLogisticByIdAsync(logisticId, cancellationToken)
            ?? throw new InvalidOperationException($"Logistic {logisticId} not found.");
    }
}
