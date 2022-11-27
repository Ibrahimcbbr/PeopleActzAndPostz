using PeopleActzAndPostz.Domain.Common.Exceptions;
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
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Post> GetPostDetailById(string id)
        {
            var post = await
                GetEntityAsync(predicate: x => id == x.Id,
                includeProperties: x => x.AppUser);
            if (post is null)
            {
                throw new NotFoundException();
            }
            return post;

        }
    }
}
