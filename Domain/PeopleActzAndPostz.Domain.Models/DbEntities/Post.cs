using PeopleActzAndPostz.Domain.Models.DbEntities.AuditEntity;
using PeopleActzAndPostz.Domain.Models.DbEntities.BaseEntity;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DbEntities
{
    public class Post : BaseEntity<string>,IAuditEntity
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string BodyContent { get; set; }




        public ICollection<Comment> Comments { get; set; }

        public ICollection<SubComment> SubComments { get; set; }
       
        public AppUser  AppUser { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
