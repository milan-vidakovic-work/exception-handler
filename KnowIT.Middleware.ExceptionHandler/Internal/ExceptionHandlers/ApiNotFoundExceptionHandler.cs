using KnowIT.Middleware.ExceptionHandler.Internal.Exceptions;
using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiNotFoundExceptionHandler : ApiExceptionHandler<NotFoundException>
    {
        protected override int GetStatusCode(NotFoundException exception)
        {
            return (int)HttpStatusCode.NotFound;
        }

        protected override object GetData(NotFoundException exception)
        {
            return new
            {
                Code = typeof(NotFoundException).Name,
                exception.Message,
                InstanceType = exception.Type.Name,
                Id = exception.Id?.ToString(),
                Inner = exception.InnerException
            };
        }
    }
}
