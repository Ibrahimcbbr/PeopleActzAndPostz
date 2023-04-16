namespace PeopleActzAndPostz.Application.Features.Identity.Account.Login
{
    public class LoginValidator:AbstractValidator<LoginCommand>
    {
        public LoginValidator()
        {
            RuleFor(x => x.LoginRequest.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.LoginRequest.Password).NotEmpty();
        }
    }
}
