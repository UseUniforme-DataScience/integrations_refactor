using System.Text.Json.Serialization;

namespace Application.Dtos.Bling;

public class BlingOrderResponseDto
{
    [JsonPropertyName("data")]
    public BlingOrderDto Data { get; set; } = null!;
}

public class BlingOrderDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("numero")]
    public long Numero { get; set; }

    [JsonPropertyName("numeroLoja")]
    public string NumeroLoja { get; set; } = null!;

    // Datas vêm como string (ex.: "0000-00-00"), então mantemos como string
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
    public BlingContatoDto Contato { get; set; } = null!;

    [JsonPropertyName("situacao")]
    public BlingSituacaoDto Situacao { get; set; } = null!;

    [JsonPropertyName("loja")]
    public BlingLojaDto Loja { get; set; } = null!;

    [JsonPropertyName("numeroPedidoCompra")]
    public string NumeroPedidoCompra { get; set; } = string.Empty;

    [JsonPropertyName("outrasDespesas")]
    public decimal OutrasDespesas { get; set; }

    [JsonPropertyName("observacoes")]
    public string Observacoes { get; set; } = string.Empty;

    [JsonPropertyName("observacoesInternas")]
    public string ObservacoesInternas { get; set; } = string.Empty;

    [JsonPropertyName("desconto")]
    public BlingDescontoDto Desconto { get; set; } = null!;

    [JsonPropertyName("categoria")]
    public BlingCategoriaDto Categoria { get; set; } = null!;

    [JsonPropertyName("notaFiscal")]
    public BlingNotaFiscalDto NotaFiscal { get; set; } = null!;

    [JsonPropertyName("tributacao")]
    public BlingTributacaoDto Tributacao { get; set; } = null!;

    [JsonPropertyName("itens")]
    public List<BlingItemDto> Itens { get; set; } = new();

    [JsonPropertyName("parcelas")]
    public List<BlingParcelaDto> Parcelas { get; set; } = new();

    [JsonPropertyName("transporte")]
    public BlingTransporteDto Transporte { get; set; } = null!;

    [JsonPropertyName("vendedor")]
    public BlingVendedorDto Vendedor { get; set; } = null!;

    [JsonPropertyName("intermediador")]
    public BlingIntermediadorDto Intermediador { get; set; } = null!;

    [JsonPropertyName("taxas")]
    public BlingTaxasDto Taxas { get; set; } = null!;
}

public class BlingContatoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; } = null!;

    [JsonPropertyName("tipoPessoa")]
    public string TipoPessoa { get; set; } = null!;

    [JsonPropertyName("numeroDocumento")]
    public string NumeroDocumento { get; set; } = null!;
}

public class BlingSituacaoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
}

public class BlingLojaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("unidadeNegocio")]
    public BlingUnidadeNegocioDto UnidadeNegocio { get; set; } = null!;
}

public class BlingUnidadeNegocioDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingDescontoDto
{
    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("unidade")]
    public string Unidade { get; set; } = null!;
}

public class BlingCategoriaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingNotaFiscalDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingTributacaoDto
{
    [JsonPropertyName("totalICMS")]
    public decimal TotalICMS { get; set; }

    [JsonPropertyName("totalIPI")]
    public decimal TotalIPI { get; set; }
}

public class BlingItemDto
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
    public BlingProdutoDto Produto { get; set; } = null!;

    [JsonPropertyName("comissao")]
    public BlingComissaoDto Comissao { get; set; } = null!;

    [JsonPropertyName("naturezaOperacao")]
    public BlingNaturezaOperacaoDto NaturezaOperacao { get; set; } = null!;
}

public class BlingProdutoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingComissaoDto
{
    [JsonPropertyName("base")]
    public decimal Base { get; set; }

    [JsonPropertyName("aliquota")]
    public decimal Aliquota { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
}

public class BlingNaturezaOperacaoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingParcelaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    // Também mantida como string por segurança em relação ao formato
    [JsonPropertyName("dataVencimento")]
    public string DataVencimento { get; set; } = null!;

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    [JsonPropertyName("observacoes")]
    public string Observacoes { get; set; } = string.Empty;

    [JsonPropertyName("caut")]
    public string Caut { get; set; } = string.Empty;

    [JsonPropertyName("formaPagamento")]
    public BlingFormaPagamentoDto FormaPagamento { get; set; } = null!;
}

public class BlingFormaPagamentoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingTransporteDto
{
    [JsonPropertyName("fretePorConta")]
    public int FretePorConta { get; set; }

    [JsonPropertyName("frete")]
    public decimal Frete { get; set; }

    [JsonPropertyName("quantidadeVolumes")]
    public int QuantidadeVolumes { get; set; }

    [JsonPropertyName("pesoBruto")]
    public decimal PesoBruto { get; set; }

    [JsonPropertyName("prazoEntrega")]
    public int PrazoEntrega { get; set; }

    [JsonPropertyName("contato")]
    public BlingTransporteContatoDto Contato { get; set; } = null!;

    [JsonPropertyName("etiqueta")]
    public BlingEtiquetaDto Etiqueta { get; set; } = null!;

    [JsonPropertyName("volumes")]
    public List<BlingVolumeDto> Volumes { get; set; } = new();
}

public class BlingTransporteContatoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; } = null!;
}

public class BlingEtiquetaDto
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

    [JsonPropertyName("nomePais")]
    public string NomePais { get; set; } = string.Empty;
}

public class BlingVolumeDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("servico")]
    public string Servico { get; set; } = null!;

    [JsonPropertyName("codigoRastreamento")]
    public string CodigoRastreamento { get; set; } = null!;
}

public class BlingVendedorDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingIntermediadorDto
{
    [JsonPropertyName("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [JsonPropertyName("nomeUsuario")]
    public string NomeUsuario { get; set; } = string.Empty;
}

public class BlingTaxasDto
{
    [JsonPropertyName("taxaComissao")]
    public decimal TaxaComissao { get; set; }

    [JsonPropertyName("custoFrete")]
    public decimal CustoFrete { get; set; }

    [JsonPropertyName("valorBase")]
    public decimal ValorBase { get; set; }
}
