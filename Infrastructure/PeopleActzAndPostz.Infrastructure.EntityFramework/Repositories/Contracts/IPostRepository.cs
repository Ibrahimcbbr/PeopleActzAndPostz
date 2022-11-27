using PeopleActzAndPostz.Domain.Models.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts
{
    public interface IPostRepository:IRepository<Post> 
    {

        Task<Post> GetPostDetailById(string id);

        
    }
}
