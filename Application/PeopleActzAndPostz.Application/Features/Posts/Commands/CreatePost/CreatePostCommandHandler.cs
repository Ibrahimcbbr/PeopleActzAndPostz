namespace PeopleActzAndPostz.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler :
        ICommandHandler<CreatePostCommand, CreatePostCommandResponse>
    {
        private readonly IPostService _postService;

        public CreatePostCommandHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<CreatePostCommandResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var createPostResult = await _postService.CreatePostAsync(request.CreatePostRequest);

            return new CreatePostCommandResponse
            {
                CreatePostResponse= createPostResult
            };
        }
    }
}
