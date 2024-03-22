namespace KnowIT.Middleware.ExceptionHandler.Internal.Exceptions
{
    public class ForbiddenAccessException : Exception
    {
        public ForbiddenAccessException(string message, ForbiddenAccessReason reason, Exception? innerException)
            : base(message, innerException) => Reason = reason;
        
        public ForbiddenAccessException(ForbiddenAccessReason reason, Exception? innerException)
            : this("Access to the resource is forbidden", reason, innerException) { }

        public ForbiddenAccessException(ForbiddenAccessReason reason)
            : this(reason, null) { }

        public ForbiddenAccessException()
            : this(ForbiddenAccessReason.Other, null) { }

        public ForbiddenAccessReason Reason { get; }
    }
}
