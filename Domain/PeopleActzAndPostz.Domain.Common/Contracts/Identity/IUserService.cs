using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.ResponseDtos;

namespace PeopleActzAndPostz.Application.Common.Contracts.Identity
{
    public interface IUserService
    {

        Task<UserDetailResponse> GetUserDetail(string id);
    }
}
