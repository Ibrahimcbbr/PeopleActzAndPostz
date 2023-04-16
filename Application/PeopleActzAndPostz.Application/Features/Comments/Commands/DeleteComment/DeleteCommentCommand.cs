namespace PeopleActzAndPostz.Application.Features.Comments.Commands.DeleteComment
{
    public sealed record DeleteCommentCommand(string id ):
        ICommand<DeleteCommentCommandResponse>
    {
    }
}
