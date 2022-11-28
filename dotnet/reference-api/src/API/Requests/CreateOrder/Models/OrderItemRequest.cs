namespace API.Requests.CreateOrder.Models
{
    public record OrderItemRequest
    {
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
    }
}
