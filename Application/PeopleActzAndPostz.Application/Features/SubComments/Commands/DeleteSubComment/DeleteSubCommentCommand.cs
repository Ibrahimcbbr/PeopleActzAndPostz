namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.DeleteSubComment
{
    public sealed record DeleteSubCommentCommand(string id)
        :ICommand<DeleteSubCommentCommandResponse>
    {
    }
}
