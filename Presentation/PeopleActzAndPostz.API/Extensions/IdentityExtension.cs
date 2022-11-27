

using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;

namespace PeopleActzAndPostz.API.Extensions
{
    public static class IdentityExtension
    {
        public static void ConfigureIdentity(this IServiceCollection services)
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
