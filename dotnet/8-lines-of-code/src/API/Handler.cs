namespace API
{
    public class Handler
    {
        private Dictionary<Type, object> _handlers = new();


        public void Add<T, TResult>(Func<T, TResult> handler)
        {
            _handlers.Add(typeof(T), handler);
        }

        public TResult Handle<T, TResult>(T request)
        {
            var specificHandler = (Func<T, TResult>)_handlers[typeof(T)];

            return specificHandler(request);
        }

    }
}
