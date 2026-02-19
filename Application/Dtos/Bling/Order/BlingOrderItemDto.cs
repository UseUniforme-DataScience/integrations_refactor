using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderItemDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("codigo")]
    public string Codigo { get; set; } = null!;

    [JsonPropertyName("unidade")]
    public string Unidade { get; set; } = null!;

    [JsonPropertyName("quantidade")]
    public decimal Quantidade { get; set; }

    [JsonPropertyName("desconto")]
    public decimal Desconto { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("aliquotaIPI")]
    public decimal AliquotaIPI { get; set; }

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; } = null!;

    [JsonPropertyName("descricaoDetalhada")]
    public string DescricaoDetalhada { get; set; } = string.Empty;

    [JsonPropertyName("produto")]
    public BlingOrderProdutoDto Produto { get; set; } = null!;

    [JsonPropertyName("comissao")]
    public BlingOrderComissaoDto Comissao { get; set; } = null!;

    [JsonPropertyName("naturezaOperacao")]
    public BlingOrderNaturezaOperacaoDto NaturezaOperacao { get; set; } = null!;
}
