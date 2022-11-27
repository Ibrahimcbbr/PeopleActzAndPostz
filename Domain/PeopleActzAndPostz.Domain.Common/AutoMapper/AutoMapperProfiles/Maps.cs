using AutoMapper;
using PeopleActzAndPostz.Domain.Models.DbEntities;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.Requests.AppUser.Account;
using PeopleActzAndPostz.Domain.Models.DTOs.Requests.Comment;
using PeopleActzAndPostz.Domain.Models.DTOs.Requests.Post;
using PeopleActzAndPostz.Domain.Models.DTOs.Requests.SubComment;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Comment;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Post;

namespace PeopleActzAndPostz.Domain.Common.AutoMapper.AutoMapperProfiles
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<AppUser, LoginRequest>();
            CreateMap<AppUser, RegisterRequest>().ReverseMap();
            CreateMap<AppUser, UserDetailResponse>().ReverseMap();


            CreateMap<Post, CreatePostRequest>().ReverseMap();
            CreateMap<Post, UpdatePostRequest>().ReverseMap();
            CreateMap<Post, PostDetailResponse>().ReverseMap();


            CreateMap<Comment, CreateCommentRequest>().ReverseMap();
            CreateMap<Comment, UpdateCommentRequest>().ReverseMap();
            CreateMap<Comment, CommentDetailResponse>().ReverseMap();


            CreateMap<SubComment, CreateSubCommentRequest>().ReverseMap();
            CreateMap<SubComment,UpdateCommentRequest>().ReverseMap();  
          
        }
    }
}
