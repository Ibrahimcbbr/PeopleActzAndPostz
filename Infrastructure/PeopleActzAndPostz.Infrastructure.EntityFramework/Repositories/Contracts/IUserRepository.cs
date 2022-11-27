using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts
{
    public interface IUserRepository:IRepository<AppUser>
    {
    }
}
