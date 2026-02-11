namespace Domain.Entities;

public class OctadeskChats
{
    public required string Id { get; set; }
    public long? Number { get; set; }
    public string? Channel { get; set; }
    public string? ContactId { get; set; }
    public string? ContactName { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactPhones { get; set; }
    public string? ContactCustomFields { get; set; }
    public string? ContactOrganizationName { get; set; }
    public string? AgentId { get; set; }
    public string? AgentName { get; set; }
    public string? AgentEmail { get; set; }
    public string? AgentPhones { get; set; }
    public string? AgentCustomFields { get; set; }
    public string? AgentOrganizationName { get; set; }
    public DateTime? LastMessageDate { get; set; }
    public string? Status { get; set; }
    public DateTime? ClosedAt { get; set; }
    public string? GroupId { get; set; }
    public string? GroupName { get; set; }
    public string? Tags { get; set; }
    public bool? WithBot { get; set; }
    public bool? UnreadMessages { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? Origin { get; set; }
    public string? StatusDetail { get; set; }
    public DateTime? AgentFirstMessageDate { get; set; }
    public DateTime? BotAssignedDate { get; set; }
    public DateTime? AssignedToAgentDate { get; set; }
    public DateTime? AssignedToGroupDate { get; set; }
    public string? Survey { get; set; }
}
