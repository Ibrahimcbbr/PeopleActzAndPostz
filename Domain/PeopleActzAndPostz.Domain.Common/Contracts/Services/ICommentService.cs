using PeopleActzAndPostz.Domain.Models.DTOs.Comments.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.Comments.ResponseDtos;

namespace PeopleActzAndPostz.Application.Common.Contracts.Services
{
    public interface ICommentService
    {

        public Task<bool> CreateCommentAsync(CreateCommentRequest request);
        public Task<bool> UpdateCommentAsync(UpdateCommentRequest request);
        public Task<bool> DeleteCommentAsync(string id);
        public Task<CommentDetailResponse> GetCommentDetailByIdAsync(string id);
    }
}
