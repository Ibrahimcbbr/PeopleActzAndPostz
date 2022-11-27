using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Post { get; }
        ICommentRepository Comment { get; }
        ISubCommentRepository SubComment { get; }
        IRepository<T> GetRepository<T>() where T : class, new();
        Task Save();
    }
}
