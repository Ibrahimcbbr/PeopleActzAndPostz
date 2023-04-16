using AutoMapper;
using PeopleActzAndPostz.Domain.Models.DbEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.Comments.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.Comments.ResponseDtos;

namespace PeopleActzAndPostz.Domain.Application.AutoMapper.AutoMapperProfiles
{
    public class CommentProfiles:Profile
    {
        public CommentProfiles()
        {

            CreateMap<Comment, CreateCommentRequest>().ReverseMap();
            CreateMap<Comment, UpdateCommentRequest>().ReverseMap();
            CreateMap<Comment, CommentDetailResponse>().ReverseMap();

        }
    }
}
