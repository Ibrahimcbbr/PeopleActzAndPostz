using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Application.Contracts
{
    public interface IUserService
    {

        Task<UserDetailResponse> GetUserDetail(string id);
    }
}
