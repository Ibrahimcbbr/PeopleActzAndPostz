namespace PeopleActzAndPostz.Application.Features.Comments.Commands.DeleteComment
{
    public class DeleteCommentCommandHandler : ICommandHandler<DeleteCommentCommand, DeleteCommentCommandResponse>
    {
        private readonly ICommentService _commentService;

        public DeleteCommentCommandHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<DeleteCommentCommandResponse> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            var deleteCommentResult = await _commentService.DeleteCommentAsync(request.id);
            return new DeleteCommentCommandResponse
            {
                DeleteCommentResponse = deleteCommentResult
            };
        }
    }
}
