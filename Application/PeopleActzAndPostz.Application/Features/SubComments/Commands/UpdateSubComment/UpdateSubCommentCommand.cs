namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.UpdateSubComment
{
    public sealed record UpdateSubCommentCommand(UpdateSubCommentRequest UpdateSubCommentRequest):
        ICommand<UpdateSubCommentCommandResponse>
        
    {
    }
}
