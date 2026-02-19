using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderContatoDto
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
