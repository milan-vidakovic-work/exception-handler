namespace KnowIT.Middleware.ExceptionHandler.Internal.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(Type type, object id)
            : base($"Object of type '{type.Name}' with ID '{id}' not found.")
        {
            Type = type;
            Id = id;
        }

        public Type Type { get; }

        public object Id { get; }
    }

    public class NotFoundException<T> : NotFoundException
    {
        public NotFoundException(object id)
            : base(typeof(T), id) { }
    }
}
