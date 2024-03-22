using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiDefaultExceptionHandler : ApiExceptionHandler<Exception>
    {
        protected override int GetStatusCode(Exception exception)
        {
            return (int)HttpStatusCode.BadRequest;
        }
    }
}
