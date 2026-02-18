using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Note;

public class PipedriveNoteUserDto
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; set; }

    [JsonPropertyName("is_you")]
    public bool? IsYou { get; set; }
}
