using PeopleActzAndPostz.Domain.Models.DTOs.Posts.ResponseDtos;
using System.Text.Json.Serialization;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Comments.ResponseDtos
{
    public class CommentDetailResponse
    {
        public string Id { get; set; }
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


        public string? ModifiedBy { get; set; }

        [JsonIgnore]
        public DateTime? ModifiedAt { get; set; }
        //public UserDetailResponse? User { get; set; }

        public PostDetailResponse? Post { get; set; }
    }
}
