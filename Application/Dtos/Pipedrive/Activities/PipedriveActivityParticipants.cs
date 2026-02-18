using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Activities;

public class PipedriveActivityParticipants
{
    [JsonPropertyName("person_id")]
    public int PersonId { get; set; }

    [JsonPropertyName("primary")]
    public bool Primary { get; set; }
}
