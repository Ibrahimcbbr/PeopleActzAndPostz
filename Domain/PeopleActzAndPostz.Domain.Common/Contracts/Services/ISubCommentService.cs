using PeopleActzAndPostz.Domain.Models.DTOs.SubComments.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.SubComments.ResponseDtos;

namespace PeopleActzAndPostz.Application.Common.Contracts.Services
{
    public interface ISubCommentService
    {
        Task<bool> CreateSubCommentAsync(CreateSubCommentRequest request);
        Task<bool> UpdateSubCommentAsync(UpdateSubCommentRequest request);

        Task<bool> DeleteSubCommentAsync(string id);

        Task<SubCommentDetailResponse> GetSubCommentDetailById(string id);
    }
}
