namespace PeopleActzAndPostz.Application.Implementations
{
    public class PostService : IPostService
    {

        #region DI properties and ctor 
        private readonly IMapper _mapper;
        private readonly ICurrentUserProvider _currentUserProvider;
        private readonly IUnitOfWork _uOw;
        private readonly UserManager<AppUser> _userManager;

        public PostService(IMapper mapper, ICurrentUserProvider currentUserProvider, IUnitOfWork uOw, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _currentUserProvider = currentUserProvider;
            _uOw = uOw;
            _userManager = userManager;
        }

        #endregion

        #region Post CRUD Operations


        public async Task<bool> CreatePostAsync(CreatePostRequest request)
        {
            var postPayload = MapToDbPostCreateModel(request);
            var payloaduser = await CurrentUser();
            postPayload.AppUser = payloaduser;
            postPayload.CreatedAt = request.CreatedAt = DateTime.UtcNow;
            postPayload.CreatedBy = payloaduser.UserName;

            _mapper.Map<UserDetailResponse>(postPayload.AppUser);


            if (postPayload is not null)
            {
                await _uOw.Post.AddAsync(postPayload);
                await _uOw.Save();
            }
            return postPayload is null ? false : true;


            //if (postPayload is null)
            //{
            //    return false;
            //}
            //return true;

        }

        public async Task<bool> UpdatePostAsync(UpdatePostRequest request)
        {

            var postFromDb = await GetPostDetail(request.Id);
            var postPayload = MapToDbPostUpdateModel(request);
            if (postFromDb is null) throw new NotFoundException();

            if (postFromDb is not null)
            {
                var postUserPayload = await CurrentUser();
                postPayload.AppUser = postUserPayload;
                _mapper.Map(postFromDb, postPayload);
                postPayload.ModifiedAt = DateTime.UtcNow;
                postPayload.ModifiedBy = postUserPayload.UserName;
               
                
                await _uOw.Post.Update(postPayload);
                await _uOw.Save();
            }
            return postPayload is null ? false : true;
        }

        public async Task<PostDetailResponse> GetPostByIdAsync(string id)
        {
            var postFromDb = await _uOw.Post.GetPostDetailById(id);

            if (postFromDb is null) throw new NotFoundException();

            var postPayload = MapToPostResponseModel(postFromDb);

            postPayload.User = _mapper.Map<UserDetailResponse>(postFromDb.AppUser);

            return postPayload;


        }


        public async Task<bool> DeletePostAsync(string id)
        {
            var postFromDb = await GetPostDetail(id);

            if (postFromDb is null) throw new NotFoundException();

            var postPayload = MapToDbModelForRemove(postFromDb);

            if (postPayload is not null)
            {
                await _uOw.Post.DeleteAsync(postFromDb);

                await _uOw.Save();
            }
            return postPayload is null ? false : true;

        }
        #endregion

        #region My Private Methods
        private async Task<AppUser> GetUserByIdAsync(string id) => await _userManager.FindByIdAsync(id);
      
        private async Task<AppUser> CurrentUser() =>await _currentUserProvider.GetCurrentUser();
        private async Task<Post> GetPostDetail(string id) => await _uOw.Post.GetPostDetailById(id);

        #endregion

        #region My DTO Mapping operations
        private Post MapToDbPostCreateModel(CreatePostRequest post) => (_mapper.Map<Post>(post));
        private Post MapToDbPostUpdateModel(UpdatePostRequest post) => (_mapper.Map<Post>(post));
        private Post MapToDbModelForRemove(Post post) => (_mapper.Map<Post>(post));
        private PostDetailResponse MapToPostResponseModel(Post post) => (_mapper.Map<PostDetailResponse>(post));

     

        #endregion
    }
}
