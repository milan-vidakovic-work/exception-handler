using KnowIT.Middleware.ExceptionHandler;
using Microsoft.AspNetCore.Builder;

namespace KnowIT.Middleware.ExceptionHandler.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseApiExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseWhen(x => x.Request.Path.StartsWithSegments("/api", StringComparison.InvariantCultureIgnoreCase), x => x.UseMiddleware<ApiExceptionMiddleware>());
            app.UseWhen(x => x.Request.Path.StartsWithSegments("/api", StringComparison.InvariantCultureIgnoreCase), x => x.UseMiddleware<ApiExceptionLogMiddleware>());
            return app;
        }
    }
}
