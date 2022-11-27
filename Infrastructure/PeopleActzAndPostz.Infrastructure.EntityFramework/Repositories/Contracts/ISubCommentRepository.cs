using PeopleActzAndPostz.Domain.Models.DbEntities;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts
{
    public interface ISubCommentRepository:IRepository<SubComment>
    {
        Task<SubComment> GetSubCommentDetailById(string id);
    }
}
