using API.Requests.CreateOrder.Models;

namespace API.Requests.CreateOrder
{
    public record CreateOrderRequest
    {
        public IEnumerable<OrderItemRequest>? OrderItems { get; set; }

        //TODO: Buyer information

    }


}
