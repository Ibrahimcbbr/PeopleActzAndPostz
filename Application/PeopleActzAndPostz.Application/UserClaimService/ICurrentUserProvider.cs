using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Application.UserClaimService
{
    public interface ICurrentUserProvider
    {
        Task<AppUser> GetCurrentUser();

        Task<string> GetCurrentUserIdAsync();
    }
}
