using API.Requests.CreateOrder;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public async Task<Result<string>> CreateOrderEndpoint(
            [FromBody] CreateOrderRequest createOrderRequest, 
            [FromServices] CreateOrderRequestHandler handler,
            CancellationToken cancellationToken)
        {
            var result = await handler.Handle(createOrderRequest, cancellationToken);
            return result;
        }
    }
}
