namespace API.Requests.CreateOrder.Models
{
    public class OrderItemRequest
    {
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
    }
}
