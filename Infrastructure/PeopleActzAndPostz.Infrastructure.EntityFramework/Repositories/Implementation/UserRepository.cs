using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext;
using PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.Repositories.Implementation
{
    public class UserRepository : Repository<AppUser>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
