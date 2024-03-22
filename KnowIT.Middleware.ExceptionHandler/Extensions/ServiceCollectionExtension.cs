using FluentValidation;
using KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers;
using KnowIT.Middleware.ExceptionHandler.Internal.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace KnowIT.Middleware.ExceptionHandler.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApiExceptionHandler(this IServiceCollection services)
        {
            services.AddSingleton<IApiExceptionHandler<ValidationException>, ApiValidationExceptionHandler>();
            services.AddSingleton<IApiExceptionHandler<UnauthorizedAccessException>, ApiUnauthorizedExceptionHandler>();
            services.AddSingleton<IApiExceptionHandler<ArgumentException>, ApiArgumentExceptionHandler>();
            services.AddSingleton<IApiExceptionHandler<NotImplementedException>, ApiNotImplementedExceptionHandler>();
            services.AddSingleton<IApiExceptionHandler<NotSupportedException>, ApiNotSupportedExceptionHandler>();
            services.AddSingleton<IApiExceptionHandler<ForbiddenAccessException>, ApiForbiddenExceptionHandler>();
            services.AddSingleton<IApiExceptionHandler<InvalidOperationException>, ApiInvalidOperationExceptionHandler>();
            services.AddSingleton<IApiExceptionHandler<NotFoundException>, ApiNotFoundExceptionHandler>();
            return services;
        }
    }
}
