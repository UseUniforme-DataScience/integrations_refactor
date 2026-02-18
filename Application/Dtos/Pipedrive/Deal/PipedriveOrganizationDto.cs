using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Deal;

public class PipedriveOrganizationDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("people_count")]
    public int PeopleCount { get; set; }

    [JsonPropertyName("owner_id")]
    public int OwnerId { get; set; }

    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("cc_email")]
    public string? CcEmail { get; set; }
}
