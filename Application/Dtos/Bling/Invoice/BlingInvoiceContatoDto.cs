using System.Text.Json.Serialization;

namespace Application.Dtos.Bling.Invoice;

public class BlingInvoiceContatoDto
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
    public BlingInvoiceEnderecoDto Endereco { get; set; } = null!;
}
