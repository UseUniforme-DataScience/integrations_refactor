using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceIcmsDto
{
    [JsonPropertyName("st")]
    public decimal St { get; set; }

    [JsonPropertyName("origem")]
    public int Origem { get; set; }

    [JsonPropertyName("modalidade")]
    public int Modalidade { get; set; }

    [JsonPropertyName("aliquota")]
    public decimal Aliquota { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
}
