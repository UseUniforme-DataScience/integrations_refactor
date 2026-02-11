using System.Text.Json.Serialization;

namespace Application.Dtos.Bling;

public class BlingOrderSearchResponseDto
{
    [JsonPropertyName("data")]
    public List<BlingOrderSearchDto> Data { get; set; } = new();
}

public class BlingOrderSearchDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("numero")]
    public long Numero { get; set; }

    [JsonPropertyName("numeroLoja")]
    public string NumeroLoja { get; set; } = null!;

    // Datas como string para suportar "0000-00-00"
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
    public BlingContatoSearchDto Contato { get; set; } = null!;

    [JsonPropertyName("situacao")]
    public BlingSituacaoSearchDto Situacao { get; set; } = null!;

    [JsonPropertyName("loja")]
    public BlingLojaSearchDto Loja { get; set; } = null!;
}

public class BlingContatoSearchDto
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

public class BlingSituacaoSearchDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
}

public class BlingLojaSearchDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("unidadeNegocio")]
    public BlingUnidadeNegocioSearchDto UnidadeNegocio { get; set; } = null!;
}

public class BlingUnidadeNegocioSearchDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
