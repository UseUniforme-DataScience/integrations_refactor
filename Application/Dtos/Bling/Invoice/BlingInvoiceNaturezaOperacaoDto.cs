using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceNaturezaOperacaoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
