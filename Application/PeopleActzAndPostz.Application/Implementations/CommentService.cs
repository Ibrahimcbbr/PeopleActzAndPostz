    using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PeopleActzAndPostz.Application.Contracts;
using PeopleActzAndPostz.Application.UserClaimService;
using PeopleActzAndPostz.Domain.Common.Exceptions;
using PeopleActzAndPostz.Domain.Models.DbEntities;
using PeopleActzAndPostz.Domain.Models.DbEntities.IdentityEntities;
using PeopleActzAndPostz.Domain.Models.DTOs.Requests.Comment;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.AppUser;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Comment;
using PeopleActzAndPostz.Domain.Models.DTOs.Responses.Post;
using PeopleActzAndPostz.Infrastructure.EntityFramework.UnitOfWorks;

namespace PeopleActzAndPostz.Application.Implementations
{
    public class CommentService : ICommentService
    {

        #region DI and CTORs
        private readonly IUnitOfWork _uOw;
        private readonly IMapper _mapper;
        private readonly ICurrentUserProvider _currentUserProvider;
        private readonly UserManager<AppUser> _userManager;

        public CommentService(IUnitOfWork uOw, IMapper mapper, ICurrentUserProvider currentUserProvider, UserManager<AppUser> userManager)
        {
            _uOw = uOw;
            _mapper = mapper;
            _currentUserProvider = currentUserProvider;
            _userManager = userManager;
        }
        #endregion


        #region Comment CRUD Operations
        public async Task<bool> CreateCommentAsync(CreateCommentRequest request)
        {


            var postPayload = await GetPostDetail(request.PostId);
            var payloaduser = await CurrentUser();
            var commentPayload = MapToCommentCreateModel(request);
            if (postPayload is null) throw new NotFoundException();

            if (commentPayload is not null)
            {
                commentPayload.appUser = payloaduser;
                _mapper.Map<UserDetailResponse>(commentPayload.appUser);
                commentPayload.AppUserId = payloaduser.Id;
                commentPayload.Post = _mapper.Map<Post>(postPayload);
                commentPayload.CreatedAt = request.CreatedAt = DateTime.UtcNow;
                commentPayload.CreatedBy = payloaduser.UserName;
                await _uOw.Comment.AddAsync(commentPayload);
                await _uOw.Save();

            }
            return commentPayload is null ? false : true;

        }

        public async Task<bool> UpdateCommentAsync(UpdateCommentRequest request, string id)
        {
            var commentFromDb = await GetCommentDetail(id);

            var commentPayload = MapToCommentUpdateModel(request);
            if (commentPayload is null) throw new NotFoundException();

            if (commentPayload is not null)
            {
                var commentUserPayload = await CurrentUser();
                commentPayload.appUser = commentUserPayload;
                _mapper.Map<UserDetailResponse>(commentPayload.appUser);
                commentPayload.ModifiedAt = DateTime.UtcNow;
                commentPayload.ModifiedBy = commentUserPayload.UserName;
                commentPayload.Post = _mapper.Map<Post>(commentFromDb.Post);



                await _uOw.Comment.Update(commentPayload);
                await _uOw.Save();
            }
            return commentPayload is null ? false : true;
        }

        public async Task<bool> DeleteCommentAsync(string id)
        {
            var commentFromDb = await GetCommentDetail(id);

            if (commentFromDb is null) throw new NotFoundException();

            var commentPayload = MapToDbModelForRemove(commentFromDb);

            if (commentPayload is not null)
            {
                await _uOw.Comment.DeleteAsync(commentPayload);

                await _uOw.Save();
            }
            return commentPayload is null ? false : true;
        }

        public async Task<CommentDetailResponse> GetCommentDetailByIdAsync(string id)
        {
            var commentFromDb = await GetCommentDetail(id);

            if (commentFromDb is null) throw new NotFoundException();

            var commentPayload = MapToCommentResponseModel(commentFromDb);



            commentPayload.Post = _mapper.Map<PostDetailResponse>(commentFromDb.Post);

            commentPayload.Post.User = _mapper.Map<UserDetailResponse>(commentFromDb.appUser);


            return commentPayload;
        }
        #endregion



        #region My Private Methods
        private async Task<AppUser> CurrentUser() => await _currentUserProvider.GetCurrentUser();
        
        private async Task<Post> GetPostDetail(string id) => await _uOw.Post.GetPostDetailById(id);

        private async Task<Comment> GetCommentDetail(string id) => await _uOw.Comment.GetCommentDetail(id);
        #endregion


        #region AutoMapper Operations
        private Comment MapToCommentCreateModel(CreateCommentRequest request) => (_mapper.Map<Comment>(request));
        private Comment MapToCommentUpdateModel(UpdateCommentRequest comment) => (_mapper.Map<Comment>(comment));

        private Comment MapToDbModelForRemove(Comment comment) => (_mapper.Map<Comment>(comment));
        private CommentDetailResponse MapToCommentResponseModel(Comment comment) => (_mapper.Map<CommentDetailResponse>(comment));

       

        #endregion
    }
}
