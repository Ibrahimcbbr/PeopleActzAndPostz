namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.DeleteSubComment
{
    public class DeleteSubCommenetCommandHandler : ICommandHandler<DeleteSubCommentCommand, DeleteSubCommentCommandResponse>
    {
        private readonly ISubCommentService _subCommentService;

        public DeleteSubCommenetCommandHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<DeleteSubCommentCommandResponse> Handle(DeleteSubCommentCommand request, CancellationToken cancellationToken)
        {
            var deleteSubCommentResult = await _subCommentService.DeleteSubCommentAsync(request.id);
            return new DeleteSubCommentCommandResponse
            {
                DeleteSubCommentResponse = deleteSubCommentResult
            };
        }
    }
}
