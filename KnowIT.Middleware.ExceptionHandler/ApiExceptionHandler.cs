using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;

namespace KnowIT.Middleware.ExceptionHandler
{
    public abstract class ApiExceptionHandler<T> : IApiExceptionHandler<T> where T : Exception
    {
        public Task HandleException(HttpContext context, Exception exception) => HandleException(context, (T)exception);

        public object GetExceptionData(Exception exception) => GetData((T)exception);

        protected virtual object GetData(T exception)
        {
            return new
            {
                Code = exception.GetType().Name,
                exception.Message,
                Inner = exception.InnerException
            };
        }

        protected virtual int GetStatusCode(T exception)
        {
            return (int)HttpStatusCode.InternalServerError;
        }

        protected virtual async Task HandleException(HttpContext context, T exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = GetStatusCode(exception);
            await context.Response.WriteAsync(JsonSerializer.Serialize(GetData(exception)));
        }
    }
}
