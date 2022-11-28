namespace API
{
    public enum ResultStatusCode
    {
        Success = 2000,
        ValidationError = 4000
    }

    public static class ResultStatusCodesExtension
    {
        public static bool IsErrorStatus(this ResultStatusCode resultStatusCode) => (int)resultStatusCode > 2999;
    }
}
