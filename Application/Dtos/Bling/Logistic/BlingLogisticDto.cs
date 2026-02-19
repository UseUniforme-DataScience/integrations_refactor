using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Logistic;

public class BlingLogisticDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("pedidoVenda")]
    public BlingLogisticPedidoVendaDto PedidoVenda { get; set; } = null!;

    [JsonPropertyName("notaFiscal")]
    public BlingLogisticNotaFiscalDto NotaFiscal { get; set; } = null!;

    [JsonPropertyName("servico")]
    public BlingLogisticServicoDto Servico { get; set; } = null!;

    [JsonPropertyName("rastreamento")]
    public BlingLogisticRastreamentoDto Rastreamento { get; set; } = null!;

    [JsonPropertyName("dimensao")]
    public BlingLogisticDimensaoDto Dimensao { get; set; } = null!;

    [JsonPropertyName("embalagem")]
    public BlingLogisticEmbalagemDto Embalagem { get; set; } = null!;

    [JsonPropertyName("dataSaida")]
    public string DataSaida { get; set; } = null!;

    [JsonPropertyName("prazoEntregaPrevisto")]
    public int PrazoEntregaPrevisto { get; set; }

    [JsonPropertyName("fretePrevisto")]
    public decimal FretePrevisto { get; set; }

    [JsonPropertyName("valorDeclarado")]
    public decimal ValorDeclarado { get; set; }

    [JsonPropertyName("avisoRecebimento")]
    public bool AvisoRecebimento { get; set; }

    [JsonPropertyName("maoPropria")]
    public bool MaoPropria { get; set; }
}
