using Microsoft.AspNetCore.Diagnostics;
using PeopleActzAndPostz.API.Middlewares;

namespace PeopleActzAndPostz.API.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddGlobalErrorHandler(this IApplicationBuilder applicationBuilder)
            => applicationBuilder.UseMiddleware<GlobalExceptionHandlerMiddleware>();
    }
}
