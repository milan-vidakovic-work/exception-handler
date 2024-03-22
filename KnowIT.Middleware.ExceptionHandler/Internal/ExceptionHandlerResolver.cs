using KnowIT.Middleware.ExceptionHandler.Internal.ExceptionHandlers;
using System;

namespace KnowIT.Middleware.ExceptionHandler.Internal
{
    internal static class ExceptionHandlerResolver
    {
        static readonly IApiExceptionHandler _defaultHandler = new ApiDefaultExceptionHandler();

        public static IApiExceptionHandler Resolve(Exception? exception, IServiceProvider services)
        {
            var type = exception?.GetType();
            IApiExceptionHandler? handler = null;

            while (type != typeof(Exception))
            {
                if (type == null)
                    break;

                var handlerType = typeof(IApiExceptionHandler<>).MakeGenericType(type);

                handler = services.GetService(handlerType) as IApiExceptionHandler;
                if (handler != null)
                    break;

                type = type.BaseType;
            }

            return handler ?? _defaultHandler;
        }
    }
}
