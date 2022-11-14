using System.Net;

namespace API
{
    public class Result<T>
    {
        public T? Value { get; set; }
        public HttpStatusCode? StatusCode { get; set; } // TODO: Dont use HTTP Status codes
        public string? Message { get; set; }
    }
}
