using PeopleActzAndPostz.Domain.Models.DbEntities.AuditEntity;
using PeopleActzAndPostz.Domain.Models.DbEntities.BaseEntity;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;

namespace PeopleActzAndPostz.Domain.Models.DbEntities
{
    public class Comment : BaseEntity<string>, IAuditEntity
    {
        public string Title { get; set; }
        public string BodyContent { get; set; }
        public string PostId { get; set; }
        public string AppUserId { get; set; }
        public Post Post { get; set; }
        public AppUser appUser { get; set; }

        public ICollection<SubComment> SubComments { get; set; }

        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
