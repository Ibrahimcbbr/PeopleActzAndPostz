using FluentValidation;

namespace PeopleActzAndPostz.Application.Features.Identity.Account.Register
{
    public class RegisterValidator:AbstractValidator<RegisterCommand>
    {
        public RegisterValidator()
        {

            RuleFor(p => p.RegisterRequest.UserName).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(p => p.RegisterRequest.Email).NotEmpty().EmailAddress();
            RuleFor(p => p.RegisterRequest.ConfirmPassword).NotEmpty().MinimumLength(6).MaximumLength(50);
        }
    }
}
