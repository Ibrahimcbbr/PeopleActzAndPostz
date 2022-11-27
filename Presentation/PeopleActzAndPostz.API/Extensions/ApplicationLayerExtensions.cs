using PeopleActzAndPostz.Application.Contracts;
using PeopleActzAndPostz.Application.Implementations;
using PeopleActzAndPostz.Application.JwtTokenHelper;
using PeopleActzAndPostz.Application.UserClaimService;
using PeopleActzAndPostz.Domain.Common.AutoMapper.AutoMapperProfiles;
using PostZUserZ.Application.Helpers.HelperServices.JwtTokenHelper;

namespace PeopleActzAndPostz.API.Extensions
{
    public static class ApplicationLayerExtensions
    {
        public static  IServiceCollection LoadApplicationLayerExtensions(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPostService, PostService>();
            services.AddTransient<IJwtTokenHelper, JwtTokenHelper>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICurrentUserProvider, CurrentUserProvider>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ISubCommentService, SubCommentService>();
           

            services.AddAutoMapper(typeof(Maps));


            return services;
        }
    }
}
