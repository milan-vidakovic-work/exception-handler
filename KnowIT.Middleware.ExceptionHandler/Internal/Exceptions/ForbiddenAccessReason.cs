namespace KnowIT.Middleware.ExceptionHandler.Internal.Exceptions
{
    public enum ForbiddenAccessReason : int
    {
        Other = 0,
        MissingAuthorizationHeader = 1,
        InvalidAuthorizationHeader = 2,
        MissingRole = 3,
    }
}
