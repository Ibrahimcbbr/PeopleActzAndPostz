using System.Reflection;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PeopleActzAndPostz.Domain.Models.DbEntities;

namespace PeopleActzAndPostz.Infrastructure.EntityFramework.DbContext
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AppUserRole> UserRole { get; set; }
        public DbSet<Post> Posts { get; set; } 

        public DbSet<Comment> Comments { get; set; }

        public DbSet<SubComment> SubComments { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            builder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            builder.Entity<SubComment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
