using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceImpostosDto
{
    [JsonPropertyName("valorAproximadoTotalTributos")]
    public decimal ValorAproximadoTotalTributos { get; set; }

    [JsonPropertyName("icms")]
    public BlingInvoiceIcmsDto Icms { get; set; } = null!;
}
