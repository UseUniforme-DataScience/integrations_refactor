using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Person;

public class PipedrivePersonListDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("owner_id")]
    public int OwnerId { get; set; }

    [JsonPropertyName("org_id")]
    public int? OrgId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [JsonPropertyName("last_name")]
    public string LastName { get; set; } = string.Empty;

    [JsonPropertyName("open_deals_count")]
    public int OpenDealsCount { get; set; }

    [JsonPropertyName("related_open_deals_count")]
    public int RelatedOpenDealsCount { get; set; }

    [JsonPropertyName("closed_deals_count")]
    public int ClosedDealsCount { get; set; }

    [JsonPropertyName("related_closed_deals_count")]
    public int RelatedClosedDealsCount { get; set; }

    [JsonPropertyName("participant_open_deals_count")]
    public int ParticipantOpenDealsCount { get; set; }

    [JsonPropertyName("participant_closed_deals_count")]
    public int ParticipantClosedDealsCount { get; set; }

    [JsonPropertyName("email_messages_count")]
    public int EmailMessagesCount { get; set; }

    [JsonPropertyName("activities_count")]
    public int ActivitiesCount { get; set; }

    [JsonPropertyName("done_activities_count")]
    public int DoneActivitiesCount { get; set; }

    [JsonPropertyName("undone_activities_count")]
    public int UndoneActivitiesCount { get; set; }

    [JsonPropertyName("files_count")]
    public int FilesCount { get; set; }

    [JsonPropertyName("notes_count")]
    public int NotesCount { get; set; }

    [JsonPropertyName("followers_count")]
    public int FollowersCount { get; set; }

    [JsonPropertyName("won_deals_count")]
    public int WonDealsCount { get; set; }

    [JsonPropertyName("related_won_deals_count")]
    public int RelatedWonDealsCount { get; set; }

    [JsonPropertyName("lost_deals_count")]
    public int LostDealsCount { get; set; }

    [JsonPropertyName("related_lost_deals_count")]
    public int RelatedLostDealsCount { get; set; }

    [JsonPropertyName("active_flag")]
    public bool ActiveFlag { get; set; }

    [JsonPropertyName("phone")]
    public List<PipedrivePhoneDto> Phone { get; set; } = [];

    [JsonPropertyName("email")]
    public List<PipedriveEmailDto> Email { get; set; } = [];

    [JsonPropertyName("first_char")]
    public string FirstChar { get; set; } = string.Empty;

    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; } = string.Empty;

    [JsonPropertyName("add_time")]
    public string AddTime { get; set; } = string.Empty;

    [JsonPropertyName("visible_to")]
    public string VisibleTo { get; set; } = string.Empty;

    [JsonPropertyName("picture_id")]
    public string? PictureId { get; set; }

    [JsonPropertyName("next_activity_date")]
    public string? NextActivityDate { get; set; }

    [JsonPropertyName("next_activity_time")]
    public string? NextActivityTime { get; set; }

    [JsonPropertyName("next_activity_id")]
    public int? NextActivityId { get; set; }

    [JsonPropertyName("last_activity_id")]
    public int? LastActivityId { get; set; }

    [JsonPropertyName("last_activity_date")]
    public string? LastActivityDate { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("label_ids")]
    public List<int> LabelIds { get; set; } = [];

    [JsonPropertyName("last_incoming_mail_time")]
    public string? LastIncomingMailTime { get; set; }

    [JsonPropertyName("last_outgoing_mail_time")]
    public string? LastOutgoingMailTime { get; set; }

    [JsonPropertyName("last_activity_time")]
    public string? LastActivityTime { get; set; }

    [JsonPropertyName("org_name")]
    public string? OrgName { get; set; }

    [JsonPropertyName("cc_email")]
    public string? CcEmail { get; set; }

    [JsonPropertyName("owner_name")]
    public string? OwnerName { get; set; }

    [JsonPropertyName("timeline_last_activity_time")]
    public string? TimelineLastActivityTime { get; set; }

    [JsonPropertyName("marketing_status")]
    public string? MarketingStatus { get; set; }

    [JsonPropertyName("subscribed_date")]
    public string? SubscribedDate { get; set; }

    [JsonPropertyName("campaign_unsubscribed_date")]
    public string? CampaignUnsubscribedDate { get; set; }

    [JsonPropertyName("campaign_title")]
    public string? CampaignTitle { get; set; }

    [JsonPropertyName("campaign_delivered_date")]
    public string? CampaignDeliveredDate { get; set; }

    [JsonPropertyName("campaign_send_date")]
    public string? CampaignSendDate { get; set; }

    [JsonPropertyName("last_campaign_send_date")]
    public string? LastCampaignSendDate { get; set; }

    [JsonPropertyName("campaign_open_date")]
    public string? CampaignOpenDate { get; set; }

    [JsonPropertyName("campaign_opens")]
    public int? CampaignOpens { get; set; }

    [JsonPropertyName("campaign_opens_total")]
    public int? CampaignOpensTotal { get; set; }

    [JsonPropertyName("campaign_clicks_total")]
    public int? CampaignClicksTotal { get; set; }

    [JsonPropertyName("campaign_click_date")]
    public string? CampaignClickDate { get; set; }

    [JsonPropertyName("campaign_clicks")]
    public int? CampaignClicks { get; set; }

    [JsonPropertyName("campaign_clicked_link")]
    public string? CampaignClickedLink { get; set; }

    [JsonPropertyName("campaign_bounce_reason")]
    public string? CampaignBounceReason { get; set; }

    [JsonPropertyName("campaign_bounce_type")]
    public string? CampaignBounceType { get; set; }

    [JsonPropertyName("doi_status")]
    public int? DoiStatus { get; set; }

    [JsonPropertyName("primary_email")]
    public string? PrimaryEmail { get; set; }
}
