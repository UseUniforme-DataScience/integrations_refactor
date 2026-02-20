using System.Text.Json;
using Application.Constants;
using Application.Constants.Caching;
using Application.Dtos.Bling.Invoice;
using Application.Interfaces.Bling;
using Domain.Interfaces;

namespace Application.Services.Bling;

public class BlingInvoiceService(IBlingClient blingClient, IRedisService redisService)
    : IBlingInvoiceService
{
    public async Task<BlingInvoiceDto?> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken
    )
    {
        var key = $"{BlingConstants.BlingInvoice}:{invoiceId}";
        var cached = await redisService.GetAsync(key);
        if (cached is not null)
        {
            return JsonSerializer.Deserialize<BlingInvoiceDto>(cached);
        }
        else
        {
            var invoice =
                await blingClient.GetInvoiceByIdAsync(invoiceId, cancellationToken)
                ?? throw new InvalidOperationException($"Invoice {invoiceId} not found.");
            if (invoice is not null)
            {
                await redisService.SetAsync(
                    key,
                    JsonSerializer.Serialize(invoice),
                    CacheDurations.BlingInvoice
                );
                return invoice;
            }
            return null;
        }
    }
}
