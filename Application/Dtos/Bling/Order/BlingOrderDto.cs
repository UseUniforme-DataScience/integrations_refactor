using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderDto
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
    public BlingOrderContatoDto Contato { get; set; } = null!;

    [JsonPropertyName("situacao")]
    public BlingOrderSituacaoDto Situacao { get; set; } = null!;

    [JsonPropertyName("loja")]
    public BlingOrderLojaDto Loja { get; set; } = null!;

    [JsonPropertyName("numeroPedidoCompra")]
    public string NumeroPedidoCompra { get; set; } = string.Empty;

    [JsonPropertyName("outrasDespesas")]
    public decimal OutrasDespesas { get; set; }

    [JsonPropertyName("observacoes")]
    public string Observacoes { get; set; } = string.Empty;

    [JsonPropertyName("observacoesInternas")]
    public string ObservacoesInternas { get; set; } = string.Empty;

    [JsonPropertyName("desconto")]
    public BlingOrderDescontoDto Desconto { get; set; } = null!;

    [JsonPropertyName("categoria")]
    public BlingOrderCategoriaDto Categoria { get; set; } = null!;

    [JsonPropertyName("notaFiscal")]
    public BlingOrderNotaFiscalDto NotaFiscal { get; set; } = null!;

    [JsonPropertyName("tributacao")]
    public BlingOrderTributacaoDto Tributacao { get; set; } = null!;

    [JsonPropertyName("itens")]
    public List<BlingOrderItemDto> Itens { get; set; } = new();

    [JsonPropertyName("parcelas")]
    public List<BlingOrderParcelaDto> Parcelas { get; set; } = new();

    [JsonPropertyName("transporte")]
    public BlingOrderTransporteDto Transporte { get; set; } = null!;

    [JsonPropertyName("vendedor")]
    public BlingOrderVendedorDto Vendedor { get; set; } = null!;

    [JsonPropertyName("intermediador")]
    public BlingOrderIntermediadorDto Intermediador { get; set; } = null!;

    [JsonPropertyName("taxas")]
    public BlingOrderTaxasDto Taxas { get; set; } = null!;
}
