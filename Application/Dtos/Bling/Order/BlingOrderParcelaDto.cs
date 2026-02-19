using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderParcelaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("dataVencimento")]
    public string DataVencimento { get; set; } = null!;

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("observacoes")]
    public string Observacoes { get; set; } = string.Empty;

    [JsonPropertyName("caut")]
    public string Caut { get; set; } = string.Empty;

    [JsonPropertyName("formaPagamento")]
    public BlingOrderFormaPagamentoDto FormaPagamento { get; set; } = null!;
}
