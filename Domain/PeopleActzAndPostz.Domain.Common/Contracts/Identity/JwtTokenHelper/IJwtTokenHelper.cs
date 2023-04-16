using Microsoft.IdentityModel.Tokens;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.ResponseDtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PeopleActzAndPostz.Application.Common.Contracts.Identity.JwtTokenHelper
{
    public interface IJwtTokenHelper
    {
        JwtSecurityToken GenerateAccessToken(List<Claim> claims);


        string WriteJwtToken(JwtSecurityToken jwtSecurityToken);


        SymmetricSecurityKey GenerateSymmetricSecurityKey();


        SigningCredentials GenerateSigningCredentials(SymmetricSecurityKey symmetricSecurityKey);


        DateTime GenerateTokenExpirationDate();


        Task<List<Claim>> GenerateJwtClaims(AppUser applicationUser);

        Task<LoginResponse> GenerateTokens(List<Claim> claims, AppUser applicationUser);
        Task InvalidateRefreshToken(AppUser applicationUser);
    }
}
