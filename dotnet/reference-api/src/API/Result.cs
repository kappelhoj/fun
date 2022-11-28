namespace API
{
    public record Result<T>(ResultStatusCode StatusCode)
    {
        public T? Value { get; set; }
        public string? Message { get; set; }
    }
}
