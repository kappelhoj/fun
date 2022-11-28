using API.Requests.CreateOrder;
using API.Requests.CreateOrder.Models;
using FluentAssertions;
using System.Collections;
using System.Net;

namespace API.Tests.UnitTests.Requests.CreateOrder
{
    public class CreateOrderRequestHandlerTest
    {
        [Theory]
        [ClassData(typeof(InvalidCreateOrderRequestData))]
        public async Task GivenInvalidRequest_ThenValidationErrorReturned(CreateOrderRequest invalidRequest, string invalidationReason)
        {
            // Arrange
            var handler = new CreateOrderRequestHandler();

            // Act
            var result = await handler.Handle(invalidRequest, CancellationToken.None);

            // Assert
            result.StatusCode.IsErrorStatus().Should().BeTrue();
            result.StatusCode.Should().Be(ResultStatusCode.ValidationError, invalidationReason);
        }

    }

    public class InvalidCreateOrderRequestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new CreateOrderRequest
                {
                    OrderItems = null,
                },
                "OrderItems is null"
            };

            yield return new object[]
            {
                new CreateOrderRequest
                {
                    OrderItems = new List<OrderItemRequest>(),
                },
                "OrderItems is empty"
            };

            yield return new object[]
            {
                new CreateOrderRequest
                {
                    OrderItems = new List<OrderItemRequest>
                    {
                        { new OrderItemRequest{ ItemId = null, Quantity = 1 }},
                        { new OrderItemRequest{ ItemId = 1, Quantity = null }},
                        { new OrderItemRequest{ ItemId = 1, Quantity = 0 }},
                        { new OrderItemRequest{ ItemId = 1, Quantity = 1 }}
                    }
                },
                "Items have invalid id or Quantity"
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
