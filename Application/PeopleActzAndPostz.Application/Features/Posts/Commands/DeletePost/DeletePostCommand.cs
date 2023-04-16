namespace PeopleActzAndPostz.Application.Features.Posts.Commands.DeletPost
{
    public sealed record DeletePostCommand(string id):
        ICommand<DeletePostCommandResponse>
    {
    }
}
