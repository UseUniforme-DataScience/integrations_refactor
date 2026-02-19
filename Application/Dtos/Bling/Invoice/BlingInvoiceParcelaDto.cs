using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceParcelaDto
{
    [JsonPropertyName("data")]
    public string Data { get; set; } = null!;

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("observacoes")]
    public string Observacoes { get; set; } = string.Empty;

    [JsonPropertyName("caut")]
    public string Caut { get; set; } = string.Empty;

    [JsonPropertyName("formaPagamento")]
    public BlingInvoiceFormaPagamentoDto FormaPagamento { get; set; } = null!;
}
