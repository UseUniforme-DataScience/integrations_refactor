using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceVendedorDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
