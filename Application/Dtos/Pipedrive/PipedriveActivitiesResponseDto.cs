using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedriveActivitiesResponseDto
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("data")]
    public List<PipedriveActivityDto> Data { get; set; } = [];

    [JsonPropertyName("additional_data")]
    public PipedriveAdditionalDataDto AdditionalData { get; set; } = new();
}

public class PipedriveActivityDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("subject")]
    public string Subject { get; set; } = string.Empty;

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("owner_id")]
    public int OwnerId { get; set; }

    [JsonPropertyName("creator_user_id")]
    public int CreatorUserId { get; set; }

    [JsonPropertyName("is_deleted")]
    public bool IsDeleted { get; set; }

    [JsonPropertyName("add_time")]
    public DateTime AddTime { get; set; }

    [JsonPropertyName("update_time")]
    public DateTime UpdateTime { get; set; }

    [JsonPropertyName("deal_id")]
    public int? DealId { get; set; }

    [JsonPropertyName("lead_id")]
    public int? LeadId { get; set; }

    [JsonPropertyName("person_id")]
    public int? PersonId { get; set; }

    [JsonPropertyName("org_id")]
    public int? OrgId { get; set; }

    [JsonPropertyName("project_id")]
    public int? ProjectId { get; set; }

    [JsonPropertyName("due_date")]
    public string? DueDate { get; set; }

    [JsonPropertyName("due_time")]
    public string? DueTime { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("done")]
    public bool Done { get; set; }

    [JsonPropertyName("busy")]
    public bool Busy { get; set; }

    [JsonPropertyName("marked_as_done_time")]
    public DateTime? MarkedAsDoneTime { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("participants")]
    public List<object> Participants { get; set; } = new();

    [JsonPropertyName("conference_meeting_client")]
    public string? ConferenceMeetingClient { get; set; }

    [JsonPropertyName("conference_meeting_url")]
    public string? ConferenceMeetingUrl { get; set; }

    [JsonPropertyName("conference_meeting_id")]
    public string? ConferenceMeetingId { get; set; }

    [JsonPropertyName("public_description")]
    public string? PublicDescription { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }
}

public class PipedriveAdditionalDataDto
{
    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; set; }
}
