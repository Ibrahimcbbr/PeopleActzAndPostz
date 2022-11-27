using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Requests.SubComment
{
    public class CreateSubCommentRequest
    {
        public string Title { get; set; }
        public string ContentBody { get; set; }
        //4ba94cf3-878c-427d-a9fa-5970e81bb164
        public string CommentId { get; set; }

        [JsonIgnore]
        public CommentDetailResponse? Comment { get; set; }
         [JsonIgnore]
        public DateTime? CreatedAt { get; set; }
        [JsonIgnore]
        public string? CreatedBy { get; set; }
        [JsonIgnore]
        public UserDetailResponse?  User { get; set; } 
    }
}
