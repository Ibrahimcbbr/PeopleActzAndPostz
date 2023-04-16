namespace PeopleActzAndPostz.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostValidator:AbstractValidator<UpdatePostCommand>
    {
        public UpdatePostValidator()
        {
            RuleFor(p => p.UpdatePostRequest.Name)
               .NotEmpty()
               .NotNull()
               .Length(2, 50);
            RuleFor(p => p.UpdatePostRequest.Title)
                .NotEmpty()
                .NotNull()
                .Length(20, 100);
            RuleFor(p => p.UpdatePostRequest.BodyContent)
                .NotEmpty()
                .NotNull()
                .Length(20, 250);
        }
    }
}
