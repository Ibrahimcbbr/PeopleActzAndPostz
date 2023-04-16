namespace PeopleActzAndPostz.Application.Features.Posts.Commands.UpdatePost
{
    public sealed record UpdatePostCommand(UpdatePostRequest UpdatePostRequest):
        ICommand<UpdatePostCommandResponse>
    {
    }
}
