using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Responses.Post
{
    public class PostDetailResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string BodyContent { get; set; }
     
        public DateTime? CreatedAt { get; set; }
     
        public string? CreatedBy { get; set; }
    
        public string? ModifiedBy { get; set; }
        
        public DateTime? ModifiedAt { get; set; }
        public UserDetailResponse? User { get; set; }

    }
}
