using AutoMapper;
using PeopleActzAndPostz.Domain.Models.DbEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.Posts.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.Posts.ResponseDtos;
namespace PeopleActzAndPostz.Domain.Application.AutoMapper.AutoMapperProfiles
{
    public class PostProfiles:Profile
    {
        public PostProfiles()
        {
            CreateMap<Post, CreatePostRequest>().ReverseMap();
            CreateMap<Post, UpdatePostRequest>().ReverseMap();
            CreateMap<Post, PostDetailResponse>().ReverseMap();

        }
    }
}
