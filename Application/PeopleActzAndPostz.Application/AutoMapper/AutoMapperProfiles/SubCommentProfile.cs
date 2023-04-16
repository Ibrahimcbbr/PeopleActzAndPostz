using AutoMapper;
using PeopleActzAndPostz.Domain.Models.DbEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.Comments.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.SubComments.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.SubComments.ResponseDtos;

namespace PeopleActzAndPostz.Domain.Application.AutoMapper.AutoMapperProfiles
{
    public class SubCommentProfile:Profile
    {
        public SubCommentProfile()
        {
            CreateMap<SubComment, CreateSubCommentRequest>().ReverseMap();
            CreateMap<SubComment, UpdateCommentRequest>().ReverseMap();
            CreateMap<SubComment, SubCommentDetailResponse>().ReverseMap();
        }
    }
}
