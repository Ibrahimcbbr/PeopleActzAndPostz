using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.ResponseDtos;

namespace PeopleActzAndPostz.Application.Common.Contracts.Identity
{
    public interface IAccountService
    {
        Task<LoginResponse> Login(LoginRequest request);
        Task<IdentityResult> Register(RegisterRequest request);
    }
}
