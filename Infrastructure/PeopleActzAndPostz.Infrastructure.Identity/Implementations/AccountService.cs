

using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Application.Common.Contracts.Email;
using PeopleActzAndPostz.Application.Common.Contracts.Identity;
using PeopleActzAndPostz.Application.Common.Contracts.Identity.JwtTokenHelper;
using PeopleActzAndPostz.Domain.Common.Exceptions;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.RequestDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.Accounts.ResponseDtos;
using System.Net;

namespace PeopleActzAndPostz.Infrastructure.Identity.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMailService _mailService; 
        private readonly IJwtTokenHelper _jwtTokenHelper;
        private readonly IMapper _mapper;

        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IJwtTokenHelper jwtTokenHelper, IMapper mapper, IMailService mailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenHelper = jwtTokenHelper;
            _mapper = mapper;
            _mailService = mailService;
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

            await SendConfirmationEmail(user);

            return IdentityResult.Success;

        }

        private async Task SendConfirmationEmail(AppUser user)
        {
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var encoded = WebUtility.UrlEncode(token);
            EmailRequest request = new()
            {
                To = user.Email,
                Subject = "Confirm Email",
            };
            await _mailService.SendEmailConfirmationMail(request, encoded);
        }
    }
}
