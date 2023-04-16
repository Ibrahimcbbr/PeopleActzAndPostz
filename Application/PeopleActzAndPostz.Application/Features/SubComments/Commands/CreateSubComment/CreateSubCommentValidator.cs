namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.CreateSubComment
{
    internal class CreateSubCommentValidator : AbstractValidator<CreateSubCommentCommand>
    {
        public CreateSubCommentValidator()
        {
            RuleFor(s => s.CreateSubCommentRequest.Title)
                .NotEmpty()
                .NotNull()
                .Length(5, 50);
            RuleFor(s => s.CreateSubCommentRequest.ContentBody)
                .NotEmpty()
                .NotNull()
                .Length(1, 250);
        }
    }
}
