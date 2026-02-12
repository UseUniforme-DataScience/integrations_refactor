using Application.Dtos.Bling;

namespace Application.Interfaces.Bling;

public interface IBlingInvoiceService
{
    Task<BlingInvoiceResponseDto> GetInvoiceByIdAsync(
        long invoiceId,
        CancellationToken cancellationToken = default
    );
}
