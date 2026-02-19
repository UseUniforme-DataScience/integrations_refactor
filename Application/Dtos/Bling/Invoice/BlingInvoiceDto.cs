using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("tipo")]
    public int Tipo { get; set; }

    [JsonPropertyName("situacao")]
    public int Situacao { get; set; }

    [JsonPropertyName("numero")]
    public string Numero { get; set; } = null!;

    [JsonPropertyName("dataEmissao")]
    public string DataEmissao { get; set; } = null!;

    [JsonPropertyName("dataOperacao")]
    public string DataOperacao { get; set; } = null!;

    [JsonPropertyName("chaveAcesso")]
    public string ChaveAcesso { get; set; } = null!;

    [JsonPropertyName("contato")]
    public BlingInvoiceContatoDto Contato { get; set; } = null!;

    [JsonPropertyName("naturezaOperacao")]
    public BlingInvoiceNaturezaOperacaoDto NaturezaOperacao { get; set; } = null!;

    [JsonPropertyName("loja")]
    public BlingInvoiceLojaDto Loja { get; set; } = null!;

    [JsonPropertyName("serie")]
    public int Serie { get; set; }

    [JsonPropertyName("valorNota")]
    public decimal ValorNota { get; set; }

    [JsonPropertyName("valorFrete")]
    public decimal ValorFrete { get; set; }

    [JsonPropertyName("xml")]
    public string Xml { get; set; } = null!;

    [JsonPropertyName("linkDanfe")]
    public string LinkDanfe { get; set; } = null!;

    [JsonPropertyName("linkPDF")]
    public string LinkPdf { get; set; } = null!;

    [JsonPropertyName("optanteSimplesNacional")]
    public bool OptanteSimplesNacional { get; set; }

    [JsonPropertyName("numeroPedidoLoja")]
    public string NumeroPedidoLoja { get; set; } = null!;

    [JsonPropertyName("vendedor")]
    public BlingInvoiceVendedorDto Vendedor { get; set; } = null!;

    [JsonPropertyName("transporte")]
    public BlingInvoiceTransporteDto Transporte { get; set; } = null!;

    [JsonPropertyName("itens")]
    public List<BlingInvoiceItemDto> Itens { get; set; } = new();

    [JsonPropertyName("parcelas")]
    public List<BlingInvoiceParcelaDto> Parcelas { get; set; } = new();
}
