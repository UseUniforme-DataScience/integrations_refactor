using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Order;

public class BlingOrderIntermediadorDto
{
    [JsonPropertyName("cnpj")]
    public string Cnpj { get; set; } = string.Empty;

    [JsonPropertyName("nomeUsuario")]
    public string NomeUsuario { get; set; } = string.Empty;
}
