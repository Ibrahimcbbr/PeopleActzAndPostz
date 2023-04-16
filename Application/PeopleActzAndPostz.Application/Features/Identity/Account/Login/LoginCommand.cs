namespace PeopleActzAndPostz.Application.Features.Identity.Account.Login
{
    public sealed record LoginCommand(LoginRequest LoginRequest):ICommand<LoginCommandResponse>
    {
    }
}
