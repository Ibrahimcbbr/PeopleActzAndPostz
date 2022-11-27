using PeopleActzAndPostz.Domain.Models.DTOs.Requests.Post;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Post;

namespace PeopleActzAndPostz.Application.Contracts
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(CreatePostRequest request);
        Task<bool> UpdatePostAsync(UpdatePostRequest request,string id);
        Task<bool> DeletePostAsync(string id);
        Task<PostDetailResponse> GetPostByIdAsync(string id);
    }
}
