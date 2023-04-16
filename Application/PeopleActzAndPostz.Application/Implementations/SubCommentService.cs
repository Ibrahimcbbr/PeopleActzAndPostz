namespace PeopleActzAndPostz.Application.Implementations
{
    public class SubCommentService : ISubCommentService
    {
        #region DI and CTOR
        private readonly IUnitOfWork _uOw;
        private readonly IMapper _mapper;
        private readonly ICurrentUserProvider _currentUserProvider;

        public SubCommentService(IUnitOfWork uOw, IMapper mapper, ICurrentUserProvider currentUserProvider)
        {
            _uOw = uOw;
            _mapper = mapper;
            _currentUserProvider = currentUserProvider;
        }



        #endregion



        #region SubComment CRUD Operations
        public async Task<bool> CreateSubCommentAsync(CreateSubCommentRequest request)
        {

            var subCommentPayload = MapToCreateRequest(request);
            var commentFromDb = await GetCommentDetail(subCommentPayload.CommentId);
            if (commentFromDb is null) throw new NotFoundException();
            var subCommentUser = await CurrentUser();


            if (subCommentPayload is not null)
            {
                subCommentPayload.Comment = _mapper.Map<Comment>(commentFromDb.SubComments);
                subCommentPayload.CreatedAt = request.CreatedAt = DateTime.UtcNow;
                subCommentPayload.CreatedBy = subCommentUser.UserName;
                subCommentPayload.User = _mapper.Map<AppUser>(subCommentUser);


                await _uOw.SubComment.AddAsync(subCommentPayload);
                await _uOw.Save();
            }
            return subCommentPayload is null ? false : true;


        }

        public async Task<bool> UpdateSubCommentAsync(UpdateSubCommentRequest request)
        {

            var subCommentPayload = MapToUpdateRequest(request);
            var subCommentFromDb = await GetSubCommentDetail(request.Id);

            _mapper.Map(subCommentFromDb, subCommentPayload);

            if (subCommentFromDb is null) throw new NotFoundException();
            var subCommentUser = await CurrentUser();

            if (subCommentPayload is not null)
            {
                subCommentPayload.Comment = _mapper.Map<Comment>(await GetCommentDetail(subCommentFromDb.CommentId));
                subCommentPayload.User = _mapper.Map<AppUser>(subCommentUser);
                subCommentPayload.ModifiedAt = request.ModifiedAt = DateTime.UtcNow;
                subCommentPayload.ModifiedBy = subCommentUser.UserName;

                await _uOw.SubComment.Update(subCommentPayload);
                await _uOw.Save();

            }
            return subCommentPayload is null ? false : true;
        }
        public async Task<SubCommentDetailResponse> GetSubCommentDetailById(string id)
        {
            var subCommentFromDb = await GetSubCommentDetail(id);
            if (subCommentFromDb is null) throw new NotFoundException();

            var subCommentPayload = MapToCommentResponseModel(subCommentFromDb);

            subCommentPayload.Comment = _mapper.Map<CommentDetailResponse>(subCommentFromDb.Comment);
            subCommentPayload.User = _mapper.Map<UserDetailResponse>(subCommentFromDb.User);

            return subCommentPayload;

        }


        public async Task<bool> DeleteSubCommentAsync(string id)
        {
            var subCommentFromDb = await GetSubCommentDetail(id);

            if (subCommentFromDb is null) throw new NotFoundException();

            var subCommentPayload = MapToDbModelForRemove(subCommentFromDb);

            if (subCommentPayload is not null)
            {
                await _uOw.SubComment.DeleteAsync(subCommentPayload);

                await _uOw.Save();
            }
            return subCommentPayload is null ? false : true;
        }

        #endregion


        #region My Private Methods
        private async Task<AppUser> CurrentUser() => await _currentUserProvider.GetCurrentUser();
        private async Task<SubComment> GetSubCommentDetail(string id) => await _uOw.SubComment.GetSubCommentDetailById(id);
        private async Task<Comment> GetCommentDetail(string id) => await _uOw.Comment.GetCommentDetail(id);
        #endregion

        #region AutoMapper Mapping Oprations

        
        private SubComment MapToCreateRequest(CreateSubCommentRequest request) => (_mapper.Map<SubComment>(request));
        private SubComment MapToUpdateRequest(UpdateSubCommentRequest request) => (_mapper.Map<SubComment>(request));
        private SubComment MapToDbModelForRemove(SubComment Subcomment) => (_mapper.Map<SubComment>(Subcomment));
        private SubCommentDetailResponse MapToCommentResponseModel(SubComment subComment) => (_mapper.Map<SubCommentDetailResponse>(subComment));

       


        #endregion
    }
}
