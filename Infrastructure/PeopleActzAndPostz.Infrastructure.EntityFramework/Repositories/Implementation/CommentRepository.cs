using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PeopleActzAndPostz.Domain.Models.DbEntities;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;
using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Implementation
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly AppDbContext _context;
        public CommentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Comment> GetCommentDetail(string id)
        {
            var comment = await _context.Comments.Where(c => c.Id == id)
                .Include(c => c.Post)
                .ThenInclude(c => c.AppUser)
                .SingleOrDefaultAsync();

         

            if (comment is null)
            {
                throw new FileNotFoundException();
            }

            return comment;

        }
    }
}
