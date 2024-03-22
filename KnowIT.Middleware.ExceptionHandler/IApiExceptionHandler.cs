using Microsoft.AspNetCore.Http;

namespace KnowIT.Middleware.ExceptionHandler
{
    public interface IApiExceptionHandler
    {
        object GetExceptionData(Exception exception);

        Task HandleException(HttpContext context, Exception exception);
    }

    public interface IApiExceptionHandler<in T> : IApiExceptionHandler where T : Exception
    {
    }
}
