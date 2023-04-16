namespace PeopleActzAndPostz.Application.Features.SubComments.Commands.CreateSubComment
{
    public class CreateSubCommentCommandHandler : ICommandHandler<CreateSubCommentCommand, CreateSubCommentCommandResponse>
    {
        private readonly ISubCommentService _subCommentService;

        public CreateSubCommentCommandHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<CreateSubCommentCommandResponse> Handle(CreateSubCommentCommand request, CancellationToken cancellationToken)
        {
            var createSubCommentResult = await _subCommentService.CreateSubCommentAsync(request.CreateSubCommentRequest);
            return new CreateSubCommentCommandResponse
            {
                CreateSubCommentResponse = createSubCommentResult
            };
        }
    }
}
