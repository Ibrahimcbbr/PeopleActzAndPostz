namespace PeopleActzAndPostz.Application.Features.SubComments.Queries.GetSubCommentDetail
{
    public sealed record GetSubCommentDetailQuery(string id)
        :IQuery<GetSubCommentDetailQueryResponse>
    {
    }
}
