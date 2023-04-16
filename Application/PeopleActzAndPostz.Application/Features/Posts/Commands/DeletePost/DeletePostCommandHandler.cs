namespace PeopleActzAndPostz.Application.Features.Posts.Commands.DeletPost
{
    public class DeletePostCommandHandler :
        ICommandHandler<DeletePostCommand, DeletePostCommandResponse>
    {
        private readonly IPostService _postService;

        public DeletePostCommandHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<DeletePostCommandResponse> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var postDeleteResult = await _postService.DeletePostAsync(request.id);
            return new DeletePostCommandResponse
            {
                DeletePostRespose = postDeleteResult
            };
        }
    }
}
