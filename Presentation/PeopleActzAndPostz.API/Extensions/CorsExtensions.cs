﻿namespace PeopleActzAndPostz.API.Extensions
{
    public static class CorsExtensions
    {

        public static void ConfigureCors(this IServiceCollection services) =>
services.AddCors(options =>
{
   options.AddPolicy("CorsPolicy", builder =>
   builder.AllowAnyOrigin()
   .AllowAnyMethod()
   .AllowAnyHeader()
   .WithExposedHeaders("X-Pagination"));
});

    }
}
