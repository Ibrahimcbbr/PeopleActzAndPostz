using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Posts.RequestDtos
{
    public class CreatePostRequest
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string BodyContent { get; set; }
        [JsonIgnore]
        public DateTime? CreatedAt { get; set; }
        [JsonIgnore]
        public string? CreatedBy { get; set; }
        [JsonIgnore]
        public UserDetailResponse? User { get; set; }
    }
}
