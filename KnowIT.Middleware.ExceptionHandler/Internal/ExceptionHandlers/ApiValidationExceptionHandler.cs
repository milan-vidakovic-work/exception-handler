using System.Net;
using FluentValidation;

namespace KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers
{
    internal class ApiValidationExceptionHandler : ApiExceptionHandler<ValidationException>
    {
        protected override int GetStatusCode(ValidationException exception)
        {
            return (int)HttpStatusCode.BadRequest;
        }

        protected override object GetData(ValidationException exception)
        {
            return new
            {
                Code = exception.GetType().Name,
                exception.Message,
                ValidationErrors = exception.Errors,
                Inner = exception.InnerException
            };
        }
    }
}
