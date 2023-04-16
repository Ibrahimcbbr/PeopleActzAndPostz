namespace PeopleActzAndPostz.Application.Features.Identity.Account.Register
{
    public class RegisterCommandHandler : ICommandHandler<RegisterCommand, IdentityResult>
    {
        private readonly IAccountService _accountService;

        public RegisterCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<IdentityResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var registerResult = await _accountService.Register(request.RegisterRequest);
            return registerResult;
        }
    }
}
