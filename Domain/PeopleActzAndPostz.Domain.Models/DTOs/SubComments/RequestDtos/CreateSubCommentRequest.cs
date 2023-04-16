using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.ResponseDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.Comments.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.SubComments.RequestDtos
{
    public class CreateSubCommentRequest
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ContentBody { get; set; }

        public string CommentId { get; set; }

        [JsonIgnore]
        public CommentDetailResponse? Comment { get; set; }
        [JsonIgnore]
        public DateTime? CreatedAt { get; set; }
        [JsonIgnore]
        public string? CreatedBy { get; set; }
        [JsonIgnore]
        public UserDetailResponse? User { get; set; }
    }
}
