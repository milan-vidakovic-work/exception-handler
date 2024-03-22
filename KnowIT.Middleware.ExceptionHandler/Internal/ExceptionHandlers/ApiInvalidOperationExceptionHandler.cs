using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiInvalidOperationExceptionHandler : ApiExceptionHandler<InvalidOperationException>
    {
        protected override int GetStatusCode(InvalidOperationException exception)
        {
            return (int)HttpStatusCode.BadRequest;
        }

        protected override object GetData(InvalidOperationException exception)
        {
            return new
            {
                Code = exception.GetType().Name,
                exception.Message,
                Inner = exception.InnerException
            };
        }
    }
}
