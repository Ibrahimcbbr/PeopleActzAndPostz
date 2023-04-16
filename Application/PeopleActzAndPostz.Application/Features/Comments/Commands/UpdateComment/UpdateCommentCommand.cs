namespace PeopleActzAndPostz.Application.Features.Comments.Commands.UpdateComment
{
    public sealed record UpdateCommentCommand(UpdateCommentRequest UpdateCommentRequest):
        ICommand<UpdateCommentCommandResponse>
    {
    }
}
