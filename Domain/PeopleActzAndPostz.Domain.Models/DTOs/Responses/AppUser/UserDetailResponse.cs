using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser
{
    public class UserDetailResponse
    {
        public string Id { get; set; }
        public string  UserName { get; set; }
        public string Email { get; set; }
        
        public PostDetailResponse? Post { get; set; }

    }
}
