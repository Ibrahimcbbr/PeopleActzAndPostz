using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.ResponseDtos;
using PeopleActzAndPostz.Domain.Models.DTOs.Comments.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.SubComments.ResponseDtos
{
    public class SubCommentDetailResponse
    {
        public string Title { get; set; }
        public string ContentBody { get; set; }

        public string CommentId { get; set; }
        public CommentDetailResponse? Comment { get; set; }

        public UserDetailResponse? User { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
