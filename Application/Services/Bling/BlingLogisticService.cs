using System.Text.Json;
using Application.Constants;
using Application.Constants.Caching;
using Application.Dtos.Bling.Logistic;
using Application.Interfaces.Bling;
using Domain.Interfaces;

namespace Application.Services.Bling;

public class BlingLogisticService(IBlingClient blingClient, IRedisService redisService)
    : IBlingLogisticService
{
    public async Task<BlingLogisticDto?> GetLogisticByIdAsync(
        long logisticId,
        CancellationToken cancellationToken = default
    )
    {
        var key = $"{BlingConstants.BlingLogistic}:{logisticId}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<BlingLogisticDto>(cached);
        }
        else
        {
            var logistic =
                await blingClient.GetLogisticByIdAsync(logisticId, cancellationToken)
                ?? throw new InvalidOperationException($"Logistic {logisticId} not found.");
            if (logistic is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(logistic),
                    CacheDurations.BlingLogistic
                );
                return logistic;
            }
            return null;
        }
    }
}
