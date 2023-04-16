namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.UpdateSubComment
{
    public class UpdateSubCommentValidator:AbstractValidator<UpdateSubCommentCommand>
    {
        public UpdateSubCommentValidator()
        {
            RuleFor(s => s.UpdateSubCommentRequest.Title)
              .NotEmpty()
              .NotNull()
              .Length(5, 50);
            RuleFor(s => s.UpdateSubCommentRequest.ContentBody)
                .NotEmpty()
                .NotNull()
                .Length(1, 250);
        }
    }
}
