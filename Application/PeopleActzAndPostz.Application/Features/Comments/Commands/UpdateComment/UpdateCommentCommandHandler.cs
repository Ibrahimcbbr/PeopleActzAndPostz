namespace PeopleActzAndPostz.Application.Features.Comments.Commands.UpdateComment
{
    public class UpdateCommentCommandHandler : ICommandHandler<UpdateCommentCommand, UpdateCommentCommandResponse>
    {
        private readonly ICommentService _commentService;

        public UpdateCommentCommandHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<UpdateCommentCommandResponse> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var updatecommentResult = await _commentService.UpdateCommentAsync(request.UpdateCommentRequest);
            return new UpdateCommentCommandResponse
            {
                UpdatedCommentResponse = updatecommentResult
            };
        }
    }
}
