using KnowIT.Middleware.ExceptionHandler.Internal.Exceptions;
using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiForbiddenExceptionHandler : ApiExceptionHandler<ForbiddenAccessException>
    {
        protected override int GetStatusCode(ForbiddenAccessException exception)
        {
            return (int)HttpStatusCode.Forbidden;
        }

        protected override object GetData(ForbiddenAccessException exception)
        {
            return new
            {
                Code = exception.GetType().Name,
                exception.Message,
                Reason = exception.Reason.ToString(),
                Inner = exception.InnerException
            };
        }
    }
}
