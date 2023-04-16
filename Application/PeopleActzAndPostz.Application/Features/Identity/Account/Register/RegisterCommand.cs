namespace PeopleActzAndPostz.Application.Features.Identity.Account.Register
{
    public sealed record RegisterCommand(RegisterRequest RegisterRequest)
        :ICommand<IdentityResult>
    {
    }
}
