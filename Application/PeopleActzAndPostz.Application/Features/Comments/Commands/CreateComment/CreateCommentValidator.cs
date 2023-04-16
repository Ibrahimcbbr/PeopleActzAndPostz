namespace PeopleActzAndPostz.Application.Features.Comments.Commands.CreateComment
{
    public class CreateCommentValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentValidator()
        {
            RuleFor(c => c.CreateCommentRequest.Title)
                .NotEmpty()
                .NotNull()
                .Length(25, 100);
            RuleFor(c => c.CreateCommentRequest.BodyContent)
                .NotEmpty()
                .NotNull()
                .Length(50, 500);

        }
    }
}