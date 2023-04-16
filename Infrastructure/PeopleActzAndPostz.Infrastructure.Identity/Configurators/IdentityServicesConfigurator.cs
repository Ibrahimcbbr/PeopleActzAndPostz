using MailKit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleActzAndPostz.Application.Common.Contracts.Identity;
using PeopleActzAndPostz.Application.Common.Contracts.Identity.JwtTokenHelper;
using PeopleActzAndPostz.Application.Common.Contracts.Identity.UserClaimProvider;
using PeopleActzAndPostz.Infrastructure.Identity.Implementations;
using PeopleActzAndPostz.Infrastructure.Identity.Implementations.JwtTokenHelper;
using PeopleActzAndPostz.Infrastructure.Identity.Implementations.UserClaimProvider;



namespace PeopleActzAndPostz.Infrastructure.Identity.Configurators
{
    public static class IdentityServicesConfigurator
    {
        public static IServiceCollection LoadIdentityServiceExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddTransient<IJwtTokenHelper, JwtTokenHelper>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICurrentUserProvider, CurrentUserProvider>();
     
            return services;
        }
    }
}
