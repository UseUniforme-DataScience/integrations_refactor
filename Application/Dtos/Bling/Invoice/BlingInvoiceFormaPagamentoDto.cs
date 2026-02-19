using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceFormaPagamentoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
