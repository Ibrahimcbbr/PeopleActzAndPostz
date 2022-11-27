using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Application.Contracts;
using PeopleActzAndPostz.Domain.Common.Exceptions;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.Requests.AppUser.Account;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser.Account;
using PostZUserZ.Application.Helpers.HelperServices.JwtTokenHelper;

namespace PeopleActzAndPostz.Application.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IJwtTokenHelper _jwtTokenHelper;
        private readonly IMapper _mapper;

        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtTokenHelper jwtTokenHelper, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenHelper = jwtTokenHelper;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user is null)
            {
               throw new NotFoundException();
            }

            var loginResult = await _signInManager.PasswordSignInAsync(user, request.Password, false, false);
            if (!loginResult.Succeeded)
            {
                throw new BadRequestException("Password or E-mail whrong");

            }

            var tokens = _jwtTokenHelper.GenerateTokens(await _jwtTokenHelper.GenerateJwtClaims(user), user);

            return tokens.Result;
        }

        public async Task<IdentityResult> Register(RegisterRequest request)
        {
            var user = _mapper.Map<AppUser>(request);

            if (user is null)
            {
                return IdentityResult.Failed(new IdentityError() { Description = "REGISTRATION ERROR" });
            }
            var userCreation = await _userManager.CreateAsync(user, request.Password);

            if (!userCreation.Succeeded)
            {
                return IdentityResult.Failed(new IdentityError() { Description = "REGISTRATION ERROR" });
            }
            await _userManager.AddToRoleAsync(user, request.Roles);

            return IdentityResult.Success;
        }
    }
}
