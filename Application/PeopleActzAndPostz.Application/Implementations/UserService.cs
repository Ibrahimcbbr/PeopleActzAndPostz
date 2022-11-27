using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Application.Contracts;
using PeopleActzAndPostz.Application.UserClaimService;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleActzAndPostz.Application.Implementations
{
    public class UserService : IUserService
    {
        


        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly ICurrentUserProvider _currentUserProvider;

        public UserService(UserManager<AppUser> userManager, IMapper mapper, ICurrentUserProvider currentUserProvider = null)
        {
            _userManager = userManager;
            _mapper = mapper;
            _currentUserProvider = currentUserProvider;
        }

        public async Task<UserDetailResponse> GetUserDetail(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user is null)
            {
                throw new KeyNotFoundException(nameof(user));
            }

            var userPayload = MapToResponseModel(user);
            return userPayload;

        }

        #region My Private Methods
        /// AutoMapper Methods

        private UserDetailResponse MapToResponseModel(AppUser userFromDb) => _mapper.Map<UserDetailResponse>(userFromDb);



        #endregion




    }
}

