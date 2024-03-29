﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PeopleActzAndPostz.Domain.Common.Settings;
using System.Text;

namespace PeopleActzAndPostz.Infrastructure.Identity.Configurators
{
    public static class AuthenticationConfigurator
    {
        public static void AddCustomizedAuthentication(this IServiceCollection services, JwtSettings _JwtSettings)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = _JwtSettings.JwtIssuer,
                       ValidAudiences = _JwtSettings.JwtAudiences,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_JwtSettings.JwtKey))
                   };
               });
        }
    }
}
