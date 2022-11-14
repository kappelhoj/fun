using FluentValidation;
using System.Net;

namespace API.Requests.CreateOrder
{
    public class CreateOrderRequestHandler
    {
        public async Task<Result<string>> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            var validation = await new CreateOrderValidator().ValidateAsync(request, cancellationToken);

            if (!validation.IsValid)
            {
                return new Result<string>
                {
                    Message = validation.ToString(),
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            return new Result<string> { };
        }

    }
}
