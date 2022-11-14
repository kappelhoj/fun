using API.Requests.CreateOrder.Models;
using FluentValidation;

namespace API.Requests.CreateOrder
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.orderItems).NotNull().NotEmpty();
            RuleForEach(x => x.orderItems).SetValidator(new OrderItemValidator());
        }
    }

    public class OrderItemValidator : AbstractValidator<OrderItemRequest>
    {
        public OrderItemValidator() 
        {
            RuleFor(x => x.ItemId).NotNull();
            RuleFor(x => x.Quantity).NotNull().GreaterThan(0);
        }
    }
}
