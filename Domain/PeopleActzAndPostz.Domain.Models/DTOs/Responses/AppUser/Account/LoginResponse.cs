using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser.Account
{
    public class LoginResponse
    {
        public string AccessToken { get; init; }
        public string RefreshToken { get; init; }
        public DateTime Expiration { get; init; }
    }
}
