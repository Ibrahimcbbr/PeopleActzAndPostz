using AutoMapper;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.ResponseDtos;

namespace PeopleActzAndPostz.Domain.Application.AutoMapper.AutoMapperProfiles
{
    public class AppUserProfiles:Profile
    {
        public AppUserProfiles()
        {
            CreateMap<AppUser, LoginRequest>();
            CreateMap<AppUser, RegisterRequest>().ReverseMap();
            CreateMap<AppUser, UserDetailResponse>().ReverseMap();
        }
    }
}
