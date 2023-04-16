namespace PeopleActzAndPostz.Application.Features.Comments.Commands.CreateComment
{
    public class CreateCommentCommandHandler :
        ICommandHandler<CreateCommentCommand, CreateCommentCommandResponse>
    {
        private readonly ICommentService _commentService;

        public CreateCommentCommandHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<CreateCommentCommandResponse> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var createCommentResult = await _commentService.CreateCommentAsync(request.CreateCommentRequest);
            return new CreateCommentCommandResponse
            {
                CreateCommentResponse = createCommentResult,
            };
        }
    }
}