namespace PeopleActzAndPostz.Application.Features.Posts.Commands.CreatePost
{
    public sealed record CreatePostCommand(CreatePostRequest CreatePostRequest):
        ICommand<CreatePostCommandResponse>
    {
    }
}
