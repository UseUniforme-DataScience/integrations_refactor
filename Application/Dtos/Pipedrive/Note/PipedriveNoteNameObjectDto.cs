using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Note;

public class PipedriveNoteNameObjectDto
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
