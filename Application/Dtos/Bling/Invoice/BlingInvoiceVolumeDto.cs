using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceVolumeDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
