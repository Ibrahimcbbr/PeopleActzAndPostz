using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;

namespace PeopleActzAndPostz.Application.Common.Contracts.Identity.UserClaimProvider
{
    public interface ICurrentUserProvider
    {
        Task<AppUser> GetCurrentUser();

        Task<string> GetCurrentUserIdAsync();
    }
}
