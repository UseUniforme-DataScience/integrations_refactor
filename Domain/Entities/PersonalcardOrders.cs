namespace Domain.Entities;

public class PersonalcardOrders
{
    public long ShopifyOrderId { get; set; }
    public string RequestBody { get; set; } = null!;
    public string Response { get; set; } = null!;
    public DateTime SentIn { get; set; }
}
