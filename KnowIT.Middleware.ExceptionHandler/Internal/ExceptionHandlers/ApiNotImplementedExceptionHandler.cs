using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiNotImplementedExceptionHandler : ApiExceptionHandler<NotImplementedException>
    {
        protected override int GetStatusCode(NotImplementedException exception)
        {
            return (int)HttpStatusCode.NotImplemented;
        }
    }
}
