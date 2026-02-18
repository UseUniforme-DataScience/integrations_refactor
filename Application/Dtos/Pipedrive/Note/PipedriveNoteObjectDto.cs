using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Note;

public class PipedriveNoteObjectDto
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
