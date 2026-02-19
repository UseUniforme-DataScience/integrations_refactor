using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceItemDto
{
    [JsonPropertyName("codigo")]
    public string Codigo { get; set; } = null!;

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; } = null!;

    [JsonPropertyName("unidade")]
    public string Unidade { get; set; } = null!;

    [JsonPropertyName("quantidade")]
    public decimal Quantidade { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("valorTotal")]
    public decimal ValorTotal { get; set; }

    [JsonPropertyName("tipo")]
    public string Tipo { get; set; } = null!;

    [JsonPropertyName("pesoBruto")]
    public decimal PesoBruto { get; set; }

    [JsonPropertyName("pesoLiquido")]
    public decimal PesoLiquido { get; set; }

    [JsonPropertyName("numeroPedidoCompra")]
    public string NumeroPedidoCompra { get; set; } = string.Empty;

    [JsonPropertyName("classificacaoFiscal")]
    public string ClassificacaoFiscal { get; set; } = string.Empty;

    [JsonPropertyName("cest")]
    public string Cest { get; set; } = string.Empty;

    [JsonPropertyName("codigoServico")]
    public string CodigoServico { get; set; } = string.Empty;

    [JsonPropertyName("origem")]
    public int Origem { get; set; }

    [JsonPropertyName("informacoesAdicionais")]
    public string InformacoesAdicionais { get; set; } = string.Empty;

    [JsonPropertyName("gtin")]
    public string Gtin { get; set; } = string.Empty;

    [JsonPropertyName("cfop")]
    public string Cfop { get; set; } = string.Empty;

    [JsonPropertyName("impostos")]
    public BlingInvoiceImpostosDto Impostos { get; set; } = null!;

    [JsonPropertyName("documentoReferenciado")]
    public BlingInvoiceDocumentoReferenciadoDto DocumentoReferenciado { get; set; } = null!;
}
