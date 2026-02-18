using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Person;

public class PipedrivePersonRequestDto
{
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("visible_to")]
    public int? VisibleTo { get; set; }

    [JsonPropertyName("custom_fields")]
    public PipedrivePersonCustomFieldsDto? CustomFields { get; set; }

    [JsonPropertyName("owner_id")]
    public int? OwnerId { get; set; }

    [JsonPropertyName("label_ids")]
    public List<int>? LabelIds { get; set; }

    [JsonPropertyName("org_id")]
    public int? OrgId { get; set; }

    [JsonPropertyName("phones")]
    public List<PipedrivePhoneDto>? Phones { get; set; }

    [JsonPropertyName("emails")]
    public List<PipedriveEmailDto>? Emails { get; set; }
}
