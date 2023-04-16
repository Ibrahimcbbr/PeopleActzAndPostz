namespace PeopleActzAndPostz.Application.Features.Comments.Commands.UpdateComment
{
    public class UpdateCommentValidator:AbstractValidator<UpdateCommentCommand>
    {
        public UpdateCommentValidator()
        {
            RuleFor(c => c.UpdateCommentRequest.Title)
               .NotEmpty()
               .NotNull()
               .Length(25, 100);
            RuleFor(c => c.UpdateCommentRequest.BodyContent)
                .NotEmpty()
                .NotNull()
                .Length(50, 500);

        }
    }
}
