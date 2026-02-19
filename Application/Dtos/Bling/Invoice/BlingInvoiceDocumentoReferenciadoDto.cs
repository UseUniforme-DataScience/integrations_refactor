using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceDocumentoReferenciadoDto
{
    [JsonPropertyName("chaveAcesso")]
    public string ChaveAcesso { get; set; } = string.Empty;

    [JsonPropertyName("numeroItem")]
    public string NumeroItem { get; set; } = string.Empty;
}
