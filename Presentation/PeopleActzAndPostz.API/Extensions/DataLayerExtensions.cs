using PeopleActzAndPostz.Application.Common.Contracts.Email;
using PeopleActzAndPostz.Infrastructure.EntityFramework.MailService;

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
            var emailConfig = configuration.GetSection("Email").Get<EmailConfigurationSettings>();
            services.AddSingleton(emailConfig);
            services.AddScoped<IMailService, MailService>();


            return services;
        }
    }
}
