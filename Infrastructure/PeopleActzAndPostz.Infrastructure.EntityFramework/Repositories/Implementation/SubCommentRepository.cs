using Microsoft.EntityFrameworkCore;
using PeopleActzAndPostz.Domain.Common.Exceptions;
using PeopleActzAndPostz.Domain.Models.DbEntities;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;
using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Implementation
{
    public class SubCommentRepository : Repository<SubComment>, ISubCommentRepository
    {
        private readonly AppDbContext _context;

        public SubCommentRepository(AppDbContext context) : base(context)
        {
            _context = context; 
        }

        public async Task<SubComment> GetSubCommentDetailById(string id)
        {
            var subComment = await _context.SubComments.Where(x => x.Id == id)
               .Include(x => x.Comment)
               .ThenInclude(x => x.appUser)
               .FirstOrDefaultAsync();

            if (subComment is null) throw new NotFoundException();

            return subComment;

        }
    }
}
