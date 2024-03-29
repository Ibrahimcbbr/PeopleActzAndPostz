﻿using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Domain.Models.DTOs.AppUsers.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Domain.Models.DTOs.Posts.RequestDtos
{
    public class UpdatePostRequest
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string BodyContent { get; set; }
        [JsonIgnore]
        public string? ModifiedBy { get; set; }
        [JsonIgnore]
        public DateTime? ModifiedAt { get; set; }
        [JsonIgnore]
        public UserDetailResponse? User { get; set; }
    }
}
