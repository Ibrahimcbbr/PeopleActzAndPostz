using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Domain.Models.DTOs.Requests.AppUser.Account;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Application.Contracts
{
    public interface IAccountService
    {
        Task<LoginResponse> Login(LoginRequest request);
        Task<IdentityResult> Register(RegisterRequest request);
    }
}
