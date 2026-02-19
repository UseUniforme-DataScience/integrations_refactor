using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderTaxasDto
{
    [JsonPropertyName("taxaComissao")]
    public decimal TaxaComissao { get; set; }

    [JsonPropertyName("custoFrete")]
    public decimal CustoFrete { get; set; }

    [JsonPropertyName("valorBase")]
    public decimal ValorBase { get; set; }
}
