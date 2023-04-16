namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.CreateSubComment
{
    public sealed record CreateSubCommentCommand(CreateSubCommentRequest CreateSubCommentRequest) :
        ICommand<CreateSubCommentCommandResponse>
    {
    }
}
