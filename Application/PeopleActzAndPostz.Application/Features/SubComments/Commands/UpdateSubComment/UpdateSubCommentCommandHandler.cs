namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.UpdateSubComment
{
    public class UpdateSubCommentCommandHandler : ICommandHandler<UpdateSubCommentCommand, UpdateSubCommentCommandResponse>
    {
        private readonly ISubCommentService _subCommentService;

        public UpdateSubCommentCommandHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<UpdateSubCommentCommandResponse> Handle(UpdateSubCommentCommand request, CancellationToken cancellationToken)
        {
            var updateSubCommentResult = await _subCommentService.UpdateSubCommentAsync(request.UpdateSubCommentRequest);
            return new UpdateSubCommentCommandResponse
            {
                UpdateSubCommentResponse = updateSubCommentResult
            };
        }
    }
}
