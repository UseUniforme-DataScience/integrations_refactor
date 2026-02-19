using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceEnderecoDto
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
