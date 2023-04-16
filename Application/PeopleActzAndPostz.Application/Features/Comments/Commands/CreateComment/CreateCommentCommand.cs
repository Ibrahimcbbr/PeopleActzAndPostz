namespace PeopleActzAndPostz.Application.Features.Comments.Commands.CreateComment
{
    public sealed record CreateCommentCommand(CreateCommentRequest CreateCommentRequest)
        : ICommand<CreateCommentCommandResponse>
    {
    }
}
