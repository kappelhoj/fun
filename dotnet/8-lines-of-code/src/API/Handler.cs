namespace API
{
    public class Handler
    {
        private Dictionary<Type, object> _handlers = new();

        public void Add<T, TResult>(Func<T, Task<TResult>> handler)
        {
            _handlers.Add(typeof(T), handler);
        }

        public Task<TResult> Handle<T,TResult>(T request)
        {
            var specificHandler = (Func<T, Task<TResult>>)_handlers[typeof(T)];

            return specificHandler(request);
        }

    }
}
