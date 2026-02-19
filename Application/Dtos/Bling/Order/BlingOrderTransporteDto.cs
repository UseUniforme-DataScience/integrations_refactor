using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderTransporteDto
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
    public BlingOrderTransporteContatoDto Contato { get; set; } = null!;

    [JsonPropertyName("etiqueta")]
    public BlingOrderEtiquetaDto Etiqueta { get; set; } = null!;

    [JsonPropertyName("volumes")]
    public List<BlingOrderVolumeDto> Volumes { get; set; } = new();
}
