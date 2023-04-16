namespace PeopleActzAndPostz.Domain.Common.Configurators
{
    public static class ApplicationLayerConfigurator
    {
        public static IServiceCollection LoadApplicationLayerExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ISubCommentService, SubCommentService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
