using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderSearchDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("numero")]
    public long Numero { get; set; }

    [JsonPropertyName("numeroLoja")]
    public string NumeroLoja { get; set; } = null!;

    [JsonPropertyName("data")]
    public string Data { get; set; } = null!;

    [JsonPropertyName("dataSaida")]
    public string DataSaida { get; set; } = null!;

    [JsonPropertyName("dataPrevista")]
    public string DataPrevista { get; set; } = null!;

    [JsonPropertyName("totalProdutos")]
    public decimal TotalProdutos { get; set; }

    [JsonPropertyName("total")]
    public decimal Total { get; set; }

    [JsonPropertyName("contato")]
    public BlingOrderSearchContatoDto Contato { get; set; } = null!;

    [JsonPropertyName("situacao")]
    public BlingOrderSearchSituacaoDto Situacao { get; set; } = null!;

    [JsonPropertyName("loja")]
    public BlingOrderSearchLojaDto Loja { get; set; } = null!;
}
