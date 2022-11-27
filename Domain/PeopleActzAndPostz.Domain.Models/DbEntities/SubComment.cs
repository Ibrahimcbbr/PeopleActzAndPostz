using PeopleActzAndPostz.Domain.Models.DbEntities.AuditEntity;
using PeopleActzAndPostz.Domain.Models.DbEntities.BaseEntity;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DbEntities
{
    public class SubComment : BaseEntity<string>, IAuditEntity
    {

        public string Title { get; set; }
        public string ContentBody { get; set; }

        public string CommentId { get; set; }
        public Comment Comment { get; set; }

        public AppUser User { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
