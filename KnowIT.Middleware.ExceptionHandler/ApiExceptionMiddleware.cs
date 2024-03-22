using KnowIT.Middleware.ExceptionHandler.Internal;
using Microsoft.AspNetCore.Http;

namespace KnowIT.Middleware.ExceptionHandler
{
    public class ApiExceptionMiddleware
    {
        readonly RequestDelegate _next;

        public ApiExceptionMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                var handler = ExceptionHandlerResolver.Resolve(exception, context.RequestServices);
                await handler.HandleException(context, exception);
            }
        }
    }
}
