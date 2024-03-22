using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace KnowIT.Middleware.ExceptionHandler
{
    public class ApiExceptionLogMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiExceptionLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var logger = context.RequestServices.GetRequiredService<ILogger<ApiExceptionLogMiddleware>>();
                logger.LogError(ex, "Unhandled exception");
                throw;
            }
        }
    }
}
