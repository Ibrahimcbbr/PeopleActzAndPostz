using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;

namespace PeopleActzAndPostz.Infrastructure.Identity.Configurators
{
    public static class IdentityConfigurator
    {
        public static void ConfigureIdentityOptions(this IServiceCollection services)
        {
            var builder = services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
            }).AddRoleManager<RoleManager<AppRole>>()
             .AddEntityFrameworkStores<AppDbContext>()
          .AddDefaultTokenProviders();
           
        }
    }
}
