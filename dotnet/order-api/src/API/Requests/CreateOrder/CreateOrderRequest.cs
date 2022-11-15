using API.Requests.CreateOrder.Models;

namespace API.Requests.CreateOrder
{
    public class CreateOrderRequest
    {
        public IEnumerable<OrderItemRequest>? OrderItems;

        //TODO: Buyer information

    }


}
