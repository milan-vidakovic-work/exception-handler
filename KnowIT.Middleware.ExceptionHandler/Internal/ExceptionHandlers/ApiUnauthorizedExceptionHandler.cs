using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiUnauthorizedExceptionHandler : ApiExceptionHandler<UnauthorizedAccessException>
    {
        protected override int GetStatusCode(UnauthorizedAccessException exception)
        {
            return (int)HttpStatusCode.Unauthorized;
        }
    }
}
