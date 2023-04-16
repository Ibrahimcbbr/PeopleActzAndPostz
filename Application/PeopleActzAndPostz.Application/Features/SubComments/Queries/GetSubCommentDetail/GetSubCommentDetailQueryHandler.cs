using PeopleActzAndPostz.Application.Common.ContractsMessaging;

namespace PeopleActzAndPostz.Application.Features.SubComments.Queries.GetSubCommentDetail
{
    public class GetSubCommentDetailQueryHandler : IQueryHandler<GetSubCommentDetailQuery, GetSubCommentDetailQueryResponse>
    {
        private readonly ISubCommentService _subCommentService;

        public GetSubCommentDetailQueryHandler(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        public async Task<GetSubCommentDetailQueryResponse> Handle(GetSubCommentDetailQuery request, CancellationToken cancellationToken)
        {
            var subCommentDetailResposne = await _subCommentService.GetSubCommentDetailById(request.id);
            return new GetSubCommentDetailQueryResponse
            {
                SubCommentDetailResponse = subCommentDetailResposne
            };
        }
    }
}