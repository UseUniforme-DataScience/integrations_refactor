using Application.Dtos.Bling.Invoice;
using Application.Interfaces.Bling;

namespace Application.Services.Bling;

public class BlingInvoiceService(IBlingClient blingClient) : IBlingInvoiceService
{
    public async Task<BlingInvoiceDto?> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken
    )
    {
        return await blingClient.GetInvoiceByIdAsync(invoiceId, cancellationToken)
            ?? throw new InvalidOperationException($"Invoice {invoiceId} not found.");
    }
}
