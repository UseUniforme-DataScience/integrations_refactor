using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Deal;

public class PipedriveDealResponseDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("creator_user_id")]
    public int? CreatorUserId { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("person_id")]
    public int? PersonId { get; set; }

    [JsonPropertyName("org_id")]
    public int? OrgId { get; set; }

    [JsonPropertyName("stage_id")]
    public int? StageId { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("add_time")]
    public string? AddTime { get; set; }

    [JsonPropertyName("update_time")]
    public string? UpdateTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("probability")]
    public int? Probability { get; set; }

    [JsonPropertyName("lost_reason")]
    public string? LostReason { get; set; }

    [JsonPropertyName("visible_to")]
    public int? VisibleTo { get; set; }

    [JsonPropertyName("close_time")]
    public string? CloseTime { get; set; }

    [JsonPropertyName("pipeline_id")]
    public int? PipelineId { get; set; }

    [JsonPropertyName("won_time")]
    public string? WonTime { get; set; }

    [JsonPropertyName("lost_time")]
    public string? LostTime { get; set; }

    [JsonPropertyName("stage_change_time")]
    public string? StageChangeTime { get; set; }

    [JsonPropertyName("local_won_date")]
    public string? LocalWonDate { get; set; }

    [JsonPropertyName("local_lost_date")]
    public string? LocalLostDate { get; set; }

    [JsonPropertyName("local_close_date")]
    public string? LocalCloseDate { get; set; }

    [JsonPropertyName("expected_close_date")]
    public string? ExpectedCloseDate { get; set; }

    [JsonPropertyName("custom_fields")]
    public PipedriveDealCustomFieldsDto? CustomFields { get; set; }

    [JsonPropertyName("owner_id")]
    public int? OwnerId { get; set; }

    [JsonPropertyName("label_ids")]
    public List<int>? LabelIds { get; set; }

    [JsonPropertyName("is_deleted")]
    public bool? IsDeleted { get; set; }

    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    [JsonPropertyName("origin_id")]
    public string? OriginId { get; set; }

    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    [JsonPropertyName("channel_id")]
    public string? ChannelId { get; set; }

    [JsonPropertyName("acv")]
    public double? Acv { get; set; }

    [JsonPropertyName("arr")]
    public double? Arr { get; set; }

    [JsonPropertyName("mrr")]
    public double? Mrr { get; set; }

    [JsonPropertyName("is_archived")]
    public bool? IsArchived { get; set; }

    [JsonPropertyName("archive_time")]
    public string? ArchiveTime { get; set; }
}
