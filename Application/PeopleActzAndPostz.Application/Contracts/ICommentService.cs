using PeopleActzAndPostz.Domain.Models.DTOs.Requests.Comment;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Application.Contracts
{
    public interface ICommentService
    {

        public Task<bool> CreateCommentAsync(CreateCommentRequest request);
        public Task<bool> UpdateCommentAsync(UpdateCommentRequest request, string id);
        public Task<bool> DeleteCommentAsync(string id);    
        public Task<CommentDetailResponse> GetCommentDetailByIdAsync(string id);
    }
}
