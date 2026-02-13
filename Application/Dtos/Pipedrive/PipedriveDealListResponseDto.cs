using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedriveDealListResponseDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("creator_user_id")]
    public int CreatorUserId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("person_id")]
    public int? PersonId { get; set; }

    [JsonPropertyName("org_id")]
    public int? OrgId { get; set; }

    [JsonPropertyName("stage_id")]
    public int StageId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    public decimal Value { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("add_time")]
    public string AddTime { get; set; } = string.Empty;

    [JsonPropertyName("update_time")]
    public string UpdateTime { get; set; } = string.Empty;

    [JsonPropertyName("stage_change_time")]
    public string? StageChangeTime { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("deleted")]
    public bool Deleted { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("probability")]
    public int? Probability { get; set; }

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

    [JsonPropertyName("lost_reason")]
    public string? LostReason { get; set; }

    [JsonPropertyName("visible_to")]
    public string VisibleTo { get; set; } = string.Empty;

    [JsonPropertyName("close_time")]
    public string? CloseTime { get; set; }

    [JsonPropertyName("pipeline_id")]
    public int PipelineId { get; set; }

    [JsonPropertyName("won_time")]
    public string? WonTime { get; set; }

    [JsonPropertyName("first_won_time")]
    public string? FirstWonTime { get; set; }

    [JsonPropertyName("lost_time")]
    public string? LostTime { get; set; }

    [JsonPropertyName("last_incoming_mail_time")]
    public string? LastIncomingMailTime { get; set; }

    [JsonPropertyName("last_outgoing_mail_time")]
    public string? LastOutgoingMailTime { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("products_count")]
    public int ProductsCount { get; set; }

    [JsonPropertyName("files_count")]
    public int FilesCount { get; set; }

    [JsonPropertyName("notes_count")]
    public int NotesCount { get; set; }

    [JsonPropertyName("followers_count")]
    public int FollowersCount { get; set; }

    [JsonPropertyName("email_messages_count")]
    public int EmailMessagesCount { get; set; }

    [JsonPropertyName("activities_count")]
    public int ActivitiesCount { get; set; }

    [JsonPropertyName("done_activities_count")]
    public int DoneActivitiesCount { get; set; }

    [JsonPropertyName("undone_activities_count")]
    public int UndoneActivitiesCount { get; set; }

    [JsonPropertyName("participants_count")]
    public int ParticipantsCount { get; set; }

    [JsonPropertyName("expected_close_date")]
    public string? ExpectedCloseDate { get; set; }

    [JsonPropertyName("acv")]
    public decimal? Acv { get; set; }

    [JsonPropertyName("mrr")]
    public decimal? Mrr { get; set; }

    [JsonPropertyName("arr")]
    public decimal? Arr { get; set; }

    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    [JsonPropertyName("origin_id")]
    public string? OriginId { get; set; }

    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    [JsonPropertyName("channel_id")]
    public string? ChannelId { get; set; }

    [JsonPropertyName("is_archived")]
    public bool IsArchived { get; set; }

    [JsonPropertyName("archive_time")]
    public string? ArchiveTime { get; set; }

    [JsonPropertyName("score")]
    public int? Score { get; set; }

    [JsonPropertyName("weighted_value")]
    public decimal WeightedValue { get; set; }

    [JsonPropertyName("weighted_value_currency")]
    public string? WeightedValueCurrency { get; set; }

    [JsonPropertyName("product_quantity")]
    public int? ProductQuantity { get; set; }

    [JsonPropertyName("product_amount")]
    public decimal? ProductAmount { get; set; }

    [JsonPropertyName("product_name")]
    public string? ProductName { get; set; }

    [JsonPropertyName("mrr_currency")]
    public string? MrrCurrency { get; set; }

    [JsonPropertyName("arr_currency")]
    public string? ArrCurrency { get; set; }

    [JsonPropertyName("acv_currency")]
    public string? AcvCurrency { get; set; }

    [JsonPropertyName("sequence_enrollment")]
    public string? SequenceEnrollment { get; set; }

    [JsonPropertyName("last_activity_time")]
    public string? LastActivityTime { get; set; }

    [JsonPropertyName("stage_order_nr")]
    public int StageOrderNr { get; set; }

    [JsonPropertyName("person_name")]
    public string? PersonName { get; set; }

    [JsonPropertyName("org_name")]
    public string? OrgName { get; set; }

    [JsonPropertyName("next_activity_subject")]
    public string? NextActivitySubject { get; set; }

    [JsonPropertyName("next_activity_type")]
    public string? NextActivityType { get; set; }

    [JsonPropertyName("next_activity_duration")]
    public string? NextActivityDuration { get; set; }

    [JsonPropertyName("next_activity_note")]
    public string? NextActivityNote { get; set; }

    [JsonPropertyName("formatted_value")]
    public string FormattedValue { get; set; } = string.Empty;

    [JsonPropertyName("rotten_time")]
    public string? RottenTime { get; set; }

    [JsonPropertyName("formatted_weighted_value")]
    public string? FormattedWeightedValue { get; set; }

    [JsonPropertyName("owner_name")]
    public string OwnerName { get; set; } = string.Empty;

    [JsonPropertyName("cc_email")]
    public string CcEmail { get; set; } = string.Empty;

    [JsonPropertyName("org_hidden")]
    public bool OrgHidden { get; set; }

    [JsonPropertyName("person_hidden")]
    public bool PersonHidden { get; set; }

    [JsonPropertyName("deal")]
    public object? Deal { get; set; }

    [JsonPropertyName("person")]
    public PipedrivePersonListDto? Person { get; set; }

    [JsonPropertyName("organization")]
    public object? Organization { get; set; }

    [JsonPropertyName("participants")]
    public object? Participants { get; set; }

    [JsonPropertyName("product")]
    public object? Product { get; set; }

    // Campos customizados do DEAL_CUSTOM_FIELDS
    [JsonPropertyName("a338be75b7a00bdd9ff34382b394c98ef46b49f9")]
    public string? ClientClassification { get; set; }

    [JsonPropertyName("b19eff6d327ae0c47b8a0b2075cbe9b1e440867a")]
    public string? LeadQualification { get; set; }

    [JsonPropertyName("5d31f719e070f8d1ca81be8e23f059cfc95ac78c")]
    public string? LabelKlaviyo { get; set; }

    [JsonPropertyName("282fafbe9a80299d62370fd2496535430d3ac667")]
    public string? TotalBalanceLetter { get; set; }

    [JsonPropertyName("1db97da38aacedce59d19324d7ce15c39a6b7827")]
    public string? UniformBalanceLetter { get; set; }

    [JsonPropertyName("0838c804a7c102b6dea03cddc6425ce3fb0329d0")]
    public string? MaterialBalanceLetter { get; set; }

    [JsonPropertyName("148394d29aeb05fee5938069dc432353e9d653ee")]
    public decimal? TotalBalance { get; set; }

    [JsonPropertyName("148394d29aeb05fee5938069dc432353e9d653ee_currency")]
    public string? TotalBalanceCurrency { get; set; }

    [JsonPropertyName("a98020622308a9bbff8bb5f71522b5ded304bd55")]
    public decimal? UniformBalance { get; set; }

    [JsonPropertyName("a98020622308a9bbff8bb5f71522b5ded304bd55_currency")]
    public string? UniformBalanceCurrency { get; set; }

    [JsonPropertyName("6ffab9a10893db85dec5fa5ff578a6fa3303393b")]
    public decimal? MaterialBalance { get; set; }

    [JsonPropertyName("6ffab9a10893db85dec5fa5ff578a6fa3303393b_currency")]
    public string? MaterialBalanceCurrency { get; set; }

    [JsonPropertyName("1dfa6a875393bb6af4d9393fcec6dcceac48f045")]
    public string? CategoryUniformBalance { get; set; }

    [JsonPropertyName("037d597ba1bc5280cfb806b08adf91c47318f4da")]
    public string? CategoryMaterialBalance { get; set; }

    [JsonPropertyName("c5585bfbfdf3fe248cf469e62d153a272c5a2c69")]
    public string? AlteradoViaIntegracao { get; set; }

    [JsonPropertyName("c35f7506a72f579a923b28f81d989d4727f5dc95")]
    public string? BenefitType { get; set; }

    [JsonPropertyName("c190a671ce7588e392ec9cf7ace1c30908e1f6a6")]
    public string? OrderId { get; set; }

    [JsonPropertyName("c88312ceda2291f9a9895a9ea6165d94a8ac8350")]
    public string? OrderNumber { get; set; }

    [JsonPropertyName("9bc91320d4c2839041e2356a0b1694d9203e901b")]
    public string? TipoDeVenda { get; set; }
}
