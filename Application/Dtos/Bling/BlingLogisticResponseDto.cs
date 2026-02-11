using System.Text.Json.Serialization;

namespace Infrastructure.Dtos.Bling;

public class BlingLogisticResponseDto
{
    [JsonPropertyName("data")]
    public BlingLogisticDto Data { get; set; } = null!;
}

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

    // Datas mantidas como string por questão de formato
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

public class BlingLogisticPedidoVendaDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingLogisticNotaFiscalDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}

public class BlingLogisticServicoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; } = null!;

    [JsonPropertyName("codigo")]
    public string Codigo { get; set; } = null!;
}

public class BlingLogisticRastreamentoDto
{
    [JsonPropertyName("codigo")]
    public string Codigo { get; set; } = null!;

    [JsonPropertyName("descricao")]
    public string Descricao { get; set; } = null!;

    [JsonPropertyName("situacao")]
    public int Situacao { get; set; }

    [JsonPropertyName("origem")]
    public string Origem { get; set; } = null!;

    [JsonPropertyName("destino")]
    public string Destino { get; set; } = string.Empty;

    // Mantido como string para preservar o formato de data/hora
    [JsonPropertyName("ultimaAlteracao")]
    public string UltimaAlteracao { get; set; } = null!;

    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;
}

public class BlingLogisticDimensaoDto
{
    [JsonPropertyName("peso")]
    public decimal Peso { get; set; }

    [JsonPropertyName("altura")]
    public decimal Altura { get; set; }

    [JsonPropertyName("largura")]
    public decimal Largura { get; set; }

    [JsonPropertyName("comprimento")]
    public decimal Comprimento { get; set; }

    [JsonPropertyName("diametro")]
    public decimal Diametro { get; set; }
}

public class BlingLogisticEmbalagemDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
}
