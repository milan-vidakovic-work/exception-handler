using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiNotSupportedExceptionHandler : ApiExceptionHandler<NotSupportedException>
    {
        protected override int GetStatusCode(NotSupportedException exception)
        {
            return (int)HttpStatusCode.NotImplemented;
        }
    }
}
