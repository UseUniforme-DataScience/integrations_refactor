using System.Text.Json.Serialization;

namespace Application.Dtos.Bling;

public class BlingNfeResponseDto
{
    [JsonPropertyName("data")]
    public BlingNfeDto Data { get; set; } = null!;
}

public class BlingNfeDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("tipo")]
    public int Tipo { get; set; }

    [JsonPropertyName("situacao")]
    public int Situacao { get; set; }

    [JsonPropertyName("numero")]
    public string Numero { get; set; } = null!;

    // Mantido como string por conter data + hora em formato específico
    [JsonPropertyName("dataEmissao")]
    public string DataEmissao { get; set; } = null!;

    [JsonPropertyName("dataOperacao")]
    public string DataOperacao { get; set; } = null!;

    [JsonPropertyName("chaveAcesso")]
    public string ChaveAcesso { get; set; } = null!;

    [JsonPropertyName("contato")]
    public BlingNfeContatoDto Contato { get; set; } = null!;

    [JsonPropertyName("naturezaOperacao")]
    public BlingNfeNaturezaOperacaoDto NaturezaOperacao { get; set; } = null!;

    [JsonPropertyName("loja")]
    public BlingNfeLojaDto Loja { get; set; } = null!;

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
    public BlingNfeVendedorDto Vendedor { get; set; } = null!;

    [JsonPropertyName("transporte")]
    public BlingNfeTransporteDto Transporte { get; set; } = null!;

    [JsonPropertyName("itens")]
    public List<BlingNfeItemDto> Itens { get; set; } = new();

    [JsonPropertyName("parcelas")]
    public List<BlingNfeParcelaDto> Parcelas { get; set; } = new();
}

public class BlingNfeContatoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; } = null!;

    [JsonPropertyName("numeroDocumento")]
    public string NumeroDocumento { get; set; } = null!;

    [JsonPropertyName("ie")]
    public string Ie { get; set; } = string.Empty;

    [JsonPropertyName("rg")]
    public string Rg { get; set; } = string.Empty;

    [JsonPropertyName("telefone")]
    public string Telefone { get; set; } = null!;

    [JsonPropertyName("email")]
    public string Email { get; set; } = null!;

    [JsonPropertyName("endereco")]
    public BlingNfeEnderecoDto Endereco { get; set; } = null!;
}

public class BlingNfeEnderecoDto
{
    [JsonPropertyName("endereco")]
    public string Endereco { get; set; } = null!;

    [JsonPropertyName("numero")]
    public string Numero { get; set; } = null!;

    [JsonPropertyName("complemento")]
    public string Complemento { get; set; } = string.Empty;

    [JsonPropertyName("bairro")]
    public string Bairro { get; set; } = null!;

    [JsonPropertyName("cep")]
    public string Cep { get; set; } = null!;

    [JsonPropertyName("municipio")]
    public string Municipio { get; set; } = null!;

    [JsonPropertyName("uf")]
    public string Uf { get; set; } = null!;
}

public class BlingNfeNaturezaOperacaoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingNfeLojaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingNfeVendedorDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingNfeTransporteDto
{
    [JsonPropertyName("fretePorConta")]
    public int FretePorConta { get; set; }

    [JsonPropertyName("transportador")]
    public BlingNfeTransportadorDto Transportador { get; set; } = null!;

    [JsonPropertyName("volumes")]
    public List<BlingNfeVolumeDto> Volumes { get; set; } = new();

    [JsonPropertyName("etiqueta")]
    public BlingNfeEtiquetaDto Etiqueta { get; set; } = null!;
}

public class BlingNfeTransportadorDto
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; } = null!;

    [JsonPropertyName("numeroDocumento")]
    public string NumeroDocumento { get; set; } = null!;
}

public class BlingNfeVolumeDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingNfeEtiquetaDto
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; } = null!;

    [JsonPropertyName("endereco")]
    public string Endereco { get; set; } = null!;

    [JsonPropertyName("numero")]
    public string Numero { get; set; } = null!;

    [JsonPropertyName("complemento")]
    public string Complemento { get; set; } = string.Empty;

    [JsonPropertyName("municipio")]
    public string Municipio { get; set; } = null!;

    [JsonPropertyName("uf")]
    public string Uf { get; set; } = null!;

    [JsonPropertyName("cep")]
    public string Cep { get; set; } = null!;

    [JsonPropertyName("bairro")]
    public string Bairro { get; set; } = null!;
}

public class BlingNfeItemDto
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
    public BlingNfeImpostosDto Impostos { get; set; } = null!;

    [JsonPropertyName("documentoReferenciado")]
    public BlingNfeDocumentoReferenciadoDto DocumentoReferenciado { get; set; } = null!;
}

public class BlingNfeImpostosDto
{
    [JsonPropertyName("valorAproximadoTotalTributos")]
    public decimal ValorAproximadoTotalTributos { get; set; }

    [JsonPropertyName("icms")]
    public BlingNfeIcmsDto Icms { get; set; } = null!;
}

public class BlingNfeIcmsDto
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

public class BlingNfeDocumentoReferenciadoDto
{
    [JsonPropertyName("chaveAcesso")]
    public string ChaveAcesso { get; set; } = string.Empty;

    [JsonPropertyName("numeroItem")]
    public string NumeroItem { get; set; } = string.Empty;
}

public class BlingNfeParcelaDto
{
    // Mantido como string para flexibilidade de formato
    [JsonPropertyName("data")]
    public string Data { get; set; } = null!;

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("observacoes")]
    public string Observacoes { get; set; } = string.Empty;

    [JsonPropertyName("caut")]
    public string Caut { get; set; } = string.Empty;

    [JsonPropertyName("formaPagamento")]
    public BlingNfeFormaPagamentoDto FormaPagamento { get; set; } = null!;
}

public class BlingNfeFormaPagamentoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
