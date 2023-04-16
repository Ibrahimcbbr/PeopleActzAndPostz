namespace PeopleActzAndPostz.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : ICommandHandler<UpdatePostCommand, UpdatePostCommandResponse>
    {
        private readonly IPostService _postService;

        public UpdatePostCommandHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<UpdatePostCommandResponse> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var updatePostResult = await  _postService.UpdatePostAsync(request.UpdatePostRequest);

            return new UpdatePostCommandResponse
            {
                UpdatePostResponse = updatePostResult
            };

        }
    }
}
