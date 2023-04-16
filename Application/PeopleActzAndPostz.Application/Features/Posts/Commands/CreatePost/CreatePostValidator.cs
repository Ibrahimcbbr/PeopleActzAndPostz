namespace PeopleActzAndPostz.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostValidator:AbstractValidator<CreatePostCommand>
    {
        public CreatePostValidator()
        {
            RuleFor(p => p.CreatePostRequest.Name)
                .NotEmpty()
                .NotNull()
                .Length(2, 50);
            RuleFor(p => p.CreatePostRequest.Title)
                .NotEmpty()
                .NotNull()
                .Length(20, 100);
            RuleFor(p => p.CreatePostRequest.BodyContent)
                .NotEmpty()
                .NotNull()
                .Length(20, 250);
        }
    }
}