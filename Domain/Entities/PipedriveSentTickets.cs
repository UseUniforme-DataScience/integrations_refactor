namespace Domain.Entities;

public class PipedriveSentTickets
{
    public long TicketNumber { get; set; }
    public long PersonId { get; set; }
    public DateTime SentIn { get; set; }
    public string? RowHash { get; set; }
}
