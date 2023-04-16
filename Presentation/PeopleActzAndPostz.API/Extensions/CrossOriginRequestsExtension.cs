namespace PeopleActzAndPostz.API.Extensions
{
    public static class CrossOriginRequestsExtension
    {
        public static void AddCustomizedCrossOriginRequests(this IServiceCollection services, JwtSettings _JwtSettings)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.WithOrigins(_JwtSettings.JwtAudiences
                        .ToArray())
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .Build();
                });
            });
        }
    }
}
