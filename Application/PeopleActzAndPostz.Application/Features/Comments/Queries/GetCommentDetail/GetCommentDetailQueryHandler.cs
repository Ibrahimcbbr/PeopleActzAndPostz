using PeopleActzAndPostz.Application.Common.ContractsMessaging;

namespace PeopleActzAndPostz.Application.Features.Comments.Queries.GetCommentDetail
{
    public class GetCommentDetailQueryHandler : IQueryHandler<GetCommentDetailQuery, GetCommentDetailQueryResponse>
    {
        private readonly ICommentService _commentService;

        public GetCommentDetailQueryHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<GetCommentDetailQueryResponse> Handle(GetCommentDetailQuery request, CancellationToken cancellationToken)
        {
            var getCommentDetailResult = await _commentService.GetCommentDetailByIdAsync(request.id);
            return new GetCommentDetailQueryResponse
            {
                CommentDetailResponse = getCommentDetailResult
            };
        }
    }
}
