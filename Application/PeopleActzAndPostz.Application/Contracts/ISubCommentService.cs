using PeopleActzAndPostz.Domain.Models.DTOs.Requests.SubComment;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.SubComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Application.Contracts
{
    public interface ISubCommentService
    {
        Task<bool> CreateSubCommentAsync(CreateSubCommentRequest request);
        Task<bool> UpdateSubCommentAsync(UpdateSubCommentRequest request,string id);

        Task<bool> DeleteSubCommentAsync(string id);

        Task<SubCommentDetailResponse>GetSubCommentDetailById(string id);
    }
}
