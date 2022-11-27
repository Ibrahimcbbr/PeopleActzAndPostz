using Microsoft.EntityFrameworkCore;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;
using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts;
using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Lazy<IPostRepository> _postRepository;
        private readonly Lazy<ICommentRepository> _commentRepository;
        private readonly Lazy<ISubCommentRepository> _subCommentRepository;
        public UnitOfWork(AppDbContext context)
        {
            _postRepository = new Lazy<IPostRepository>(() => new PostRepository(context));
            _commentRepository = new Lazy<ICommentRepository>(() => new CommentRepository(context));
            _subCommentRepository = new Lazy<ISubCommentRepository>(() => new SubCommentRepository(context));
            _context = context;
        }

        public IPostRepository Post => _postRepository.Value;

        public ICommentRepository Comment => _commentRepository.Value;

        public ISubCommentRepository SubComment => _subCommentRepository.Value;

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
