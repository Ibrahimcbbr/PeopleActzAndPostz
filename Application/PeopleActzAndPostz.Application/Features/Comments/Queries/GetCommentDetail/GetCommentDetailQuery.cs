namespace PeopleActzAndPostz.Application.Features.Comments.Queries.GetCommentDetail
{
    public sealed record GetCommentDetailQuery(string id)
        : IQuery<GetCommentDetailQueryResponse>
    {
    }
}
