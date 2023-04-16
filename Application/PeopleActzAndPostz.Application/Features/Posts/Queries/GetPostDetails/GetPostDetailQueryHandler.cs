using PeopleActzAndPostz.Application.Common.ContractsMessaging;

namespace PeopleActzAndPostz.Application.Features.Posts.Queries.GetPostDetails
{
    public class GetPostDetailQueryHandler
        : IQueryHandler<GetPostDetailQuery, GetPostDetailQueryResponse>
    {
        private readonly IPostService _postService;

        public GetPostDetailQueryHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<GetPostDetailQueryResponse> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {
            var postDetailResponse = await _postService.GetPostByIdAsync(request.id);
            return new GetPostDetailQueryResponse
            {
                PostDetailResponse = postDetailResponse
            };
        }
    }
}
