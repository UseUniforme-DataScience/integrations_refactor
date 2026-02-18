using System.Text.Json.Serialization;
using Application.Dtos.Pipedrive.Person;

namespace Application.Dtos.Pipedrive.Deal;

public class PipedriveDealRelatedObjectsDto
{
    [JsonPropertyName("user")]
    public Dictionary<string, PipedriveUserDto>? User { get; set; }

    [JsonPropertyName("person")]
    public Dictionary<string, PipedrivePersonListDto>? Person { get; set; }

    [JsonPropertyName("organization")]
    public Dictionary<string, PipedriveOrganizationDto>? Organization { get; set; }
}
