using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceTransporteDto
{
    [JsonPropertyName("fretePorConta")]
    public int FretePorConta { get; set; }

    [JsonPropertyName("transportador")]
    public BlingInvoiceTransportadorDto Transportador { get; set; } = null!;

    [JsonPropertyName("volumes")]
    public List<BlingInvoiceVolumeDto> Volumes { get; set; } = new();

    [JsonPropertyName("etiqueta")]
    public BlingInvoiceEtiquetaDto Etiqueta { get; set; } = null!;
}
