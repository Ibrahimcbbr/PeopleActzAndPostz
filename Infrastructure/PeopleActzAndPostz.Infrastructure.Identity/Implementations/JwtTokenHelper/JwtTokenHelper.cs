
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PeopleActzAndPostz.Application.Common.Contracts.Identity.JwtTokenHelper;
using PeopleActzAndPostz.Domain.Common.Settings;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.ResponseDtos;
using PeopleActzAndPostz.Infrastructure.EntityFramework.UnitOfWorks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PeopleActzAndPostz.Infrastructure.Identity.Implementations.JwtTokenHelper
{
    public class JwtTokenHelper : IJwtTokenHelper
    {
        private readonly IOptions<JwtSettings> _jwtSettings;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUnitOfWork _uOw;

        public JwtTokenHelper(IOptions<JwtSettings> jwtSettings, UserManager<AppUser> userManager, IUnitOfWork uOw)
        {
            _jwtSettings = jwtSettings;
            _userManager = userManager;
            _uOw = uOw;
        }
        /// <summary>
        /// Genereting user claims 
        /// </summary>
        /// <param name="applicationUser"></param>
        /// <returns></returns>
        public async Task<List<Claim>> GenerateJwtClaims(AppUser applicationUser)
        {
            var claims = new List<Claim>
            {

                new Claim(
                    JwtRegisteredClaimNames.Jti,
                    Guid.NewGuid().ToString()),
                new Claim(
                    ClaimTypes.NameIdentifier,
                  applicationUser.Id.ToString()),
                new Claim(
                    ClaimTypes.Email,
                    applicationUser.Email),
                new Claim(
                    ClaimTypes.System,
                    Environment.MachineName)


            };

            var roles = await _userManager.GetRolesAsync(applicationUser);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
        /// <summary>
        /// This part I created access-token
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        public JwtSecurityToken GenerateAccessToken(List<Claim> claims)
        {
            return new JwtSecurityToken(
                issuer: _jwtSettings.Value.JwtIssuer,
                audience: null,
                claims: claims,
                expires: GenerateTokenExpirationDate(),
                signingCredentials: GenerateSigningCredentials(GenerateSymmetricSecurityKey())
                );
        }
        /// <summary>
        /// We wrapt our token whit security algoritm
        /// </summary>
        /// <param name="symmetricSecurityKey"></param>
        /// <returns></returns>
        public SigningCredentials GenerateSigningCredentials(SymmetricSecurityKey symmetricSecurityKey)
        {
            return new SigningCredentials(symmetricSecurityKey,
                                        SecurityAlgorithms.HmacSha256);
        }
        /// <summary>
        /// This part create Key value
        /// </summary>
        /// <returns></returns>
        public SymmetricSecurityKey GenerateSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Value.JwtKey));
        }
        /// <summary>
        /// Token life time
        /// </summary>
        /// <returns></returns>
        public DateTime GenerateTokenExpirationDate()
        {

            var minutes = _jwtSettings.Value.AccessTokenExpirationInMinutes = 180;
            var expiry = DateTime.Now.AddMinutes(minutes);

            return expiry;
        }
        /// <summary>
        /// Write our token 
        /// </summary>
        /// <param name="jwtSecurityToken"></param>
        /// <returns></returns>
        public string WriteJwtToken(JwtSecurityToken jwtSecurityToken) => new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        /// <summary>
        /// Cteate RefreshToken
        /// </summary>
        /// <returns></returns>
        private static string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        public async Task<LoginResponse> GenerateTokens(List<Claim> claims, AppUser applicationUser)
        {
            var accessToken = GenerateAccessToken(claims);
            var refreshToken = GenerateRefreshToken();
            var expiry = _jwtSettings.Value.RefreshTokenExpirationInDays = 30;

            // update refresh token on the usee
            applicationUser.RefreshToken = refreshToken;
            applicationUser.RefreshTokenExpiryTime = DateTime.Now.AddDays(expiry);
            await  _userManager.UpdateAsync(applicationUser);
            await _uOw.Save();

            return new()
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(accessToken),
                RefreshToken = refreshToken,
                Expiration = accessToken.ValidTo
            };
        }

        public async Task InvalidateRefreshToken(AppUser applicationUser)
        {
            applicationUser.RefreshToken = null;
            applicationUser.RefreshTokenExpiryTime = DateTime.MinValue;

            await _userManager.UpdateAsync(applicationUser);
            await _uOw.Save();
        }

       
    }
}
