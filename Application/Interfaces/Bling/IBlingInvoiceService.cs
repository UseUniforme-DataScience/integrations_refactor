using Application.Dtos.Bling.Invoice;

namespace Application.Interfaces.Bling;

public interface IBlingInvoiceService
{
    Task<BlingInvoiceDto?> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken = default
    );
}
