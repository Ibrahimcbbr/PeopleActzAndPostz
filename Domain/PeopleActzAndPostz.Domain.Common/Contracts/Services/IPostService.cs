using PeopleActzAndPostz.Domain.Models.DTOs.Posts.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.Posts.ResponseDtos;

namespace PeopleActzAndPostz.Application.Common.Contracts.Services
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(CreatePostRequest request);
        Task<bool> UpdatePostAsync(UpdatePostRequest request);
        Task<bool> DeletePostAsync(string id);
        Task<PostDetailResponse> GetPostByIdAsync(string id);
    }
}
