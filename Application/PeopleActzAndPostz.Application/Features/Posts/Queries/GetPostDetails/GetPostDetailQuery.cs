namespace PeopleActzAndPostz.Application.Features.Posts.Queries.GetPostDetails
{
    public sealed record GetPostDetailQuery(string id
        ) : IQuery<GetPostDetailQueryResponse>
    {
    }
}
