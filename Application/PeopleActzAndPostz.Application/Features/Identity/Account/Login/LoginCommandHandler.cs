using PeopleActzAndPostz.Application.Common.Contracts.Identity;
using PeopleActzAndPostz.Application.Common.Contracts.Identity.JwtTokenHelper;
using PeopleActzAndPostz.Application.Common.Contracts.Messaging;

namespace PeopleActzAndPostz.Application.Features.Identity.Account.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IAccountService _accountService;
        public LoginCommandHandler(IAccountService accountService, IJwtTokenHelper jwtTokenHelper)
        {
            _accountService = accountService;
  
        }
        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var loginResult = await _accountService.Login(request.LoginRequest);
            return new LoginCommandResponse
            {
                LoginResponse= loginResult,
            };
        }
    }
}
