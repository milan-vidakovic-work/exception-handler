using System.Net;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiArgumentExceptionHandler : ApiExceptionHandler<ArgumentException>
    {
        protected override int GetStatusCode(ArgumentException exception)
        {
            return (int)HttpStatusCode.BadRequest;
        }

        protected override object GetData(ArgumentException exception)
        {
            return new
            {
                Code = exception.GetType().Name,
                exception.Message,
                exception.ParamName,
                Inner = exception.InnerException
            };
        }
    }
}
