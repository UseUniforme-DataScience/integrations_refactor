using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Note;

public class PipedriveNoteResponseDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    [JsonPropertyName("deal_id")]
    public int? DealId { get; set; }

    [JsonPropertyName("person_id")]
    public int? PersonId { get; set; }

    [JsonPropertyName("org_id")]
    public int? OrgId { get; set; }

    [JsonPropertyName("lead_id")]
    public int? LeadId { get; set; }

    [JsonPropertyName("project_id")]
    public int? ProjectId { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("add_time")]
    public string? AddTime { get; set; }

    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    [JsonPropertyName("active_flag")]
    public bool? ActiveFlag { get; set; }

    [JsonPropertyName("pinned_to_deal_flag")]
    public bool? PinnedToDealFlag { get; set; }

    [JsonPropertyName("pinned_to_person_flag")]
    public bool? PinnedToPersonFlag { get; set; }

    [JsonPropertyName("pinned_to_organization_flag")]
    public bool? PinnedToOrganizationFlag { get; set; }

    [JsonPropertyName("pinned_to_lead_flag")]
    public bool? PinnedToLeadFlag { get; set; }

    [JsonPropertyName("pinned_to_project_flag")]
    public bool? PinnedToProjectFlag { get; set; }

    [JsonPropertyName("last_update_user_id")]
    public int? LastUpdateUserId { get; set; }

    [JsonPropertyName("organization")]
    public PipedriveNoteNameObjectDto? Organization { get; set; }

    [JsonPropertyName("person")]
    public PipedriveNoteNameObjectDto? Person { get; set; }

    [JsonPropertyName("deal")]
    public PipedriveNoteObjectDto? Deal { get; set; }

    [JsonPropertyName("lead")]
    public PipedriveNoteObjectDto? Lead { get; set; }

    [JsonPropertyName("user")]
    public PipedriveNoteUserDto? User { get; set; }
}
