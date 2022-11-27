using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Requests.Comment
{
    public class CreateCommentRequest
    {

        public string Title { get; set; }
        public string BodyContent { get; set; }
        public string PostId { get; set; }
        [JsonIgnore]
        public string? AppUserId { get; set; }
     
      
        [JsonIgnore]
        public DateTime? CreatedAt { get; set; }
        [JsonIgnore]
        public string? CreatedBy { get; set; }
        [JsonIgnore]
        public UserDetailResponse? User { get; set; }
        [JsonIgnore]
        public PostDetailResponse? Post { get; set; }
    }
}
