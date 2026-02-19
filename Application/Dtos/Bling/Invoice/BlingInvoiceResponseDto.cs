using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceResponseDto
{
    [JsonPropertyName("data")]
    public BlingInvoiceDto Data { get; set; } = null!;
}
