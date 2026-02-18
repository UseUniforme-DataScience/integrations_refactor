using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Person;

public class PipedrivePersonDataDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("add_time")]
    public string? AddTime { get; set; }

    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

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

    [JsonPropertyName("is_deleted")]
    public bool? IsDeleted { get; set; }

    [JsonPropertyName("picture_id")]
    public int? PictureId { get; set; }

    [JsonPropertyName("phones")]
    public List<PipedrivePhoneDto>? Phones { get; set; }

    [JsonPropertyName("emails")]
    public List<PipedriveEmailDto>? Emails { get; set; }
}
