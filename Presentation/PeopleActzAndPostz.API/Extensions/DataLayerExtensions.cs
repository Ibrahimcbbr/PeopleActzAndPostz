using Microsoft.EntityFrameworkCore;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;
using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts;
using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Implementation;
using PeopleActzAndPostz.Infrastructure.EntityFramework.UnitOfWorks;

namespace PeopleActzAndPostz.API.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BlogConn"));

            });

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();


            return services;
        }
    }
}
