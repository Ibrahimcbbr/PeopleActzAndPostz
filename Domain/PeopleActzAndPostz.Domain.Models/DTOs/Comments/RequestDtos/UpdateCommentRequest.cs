using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.ResponseDtos;
using System.Text.Json.Serialization;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Comments.RequestDtos
{
    public class UpdateCommentRequest
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string BodyContent { get; set; }

        [JsonIgnore]

        public string? AppUserId { get; set; }
        [JsonIgnore]
        public string? postId { get; set; }


        [JsonIgnore]
        public string? ModifiedBy { get; set; }

        [JsonIgnore]
        public DateTime? ModifiedAt { get; set; }
        [JsonIgnore]

        public UserDetailResponse? User { get; set; }


    }
}
