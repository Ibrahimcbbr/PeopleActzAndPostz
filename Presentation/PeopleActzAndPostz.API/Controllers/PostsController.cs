namespace PeopleActzAndPostz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }


        [HttpPost("CreatePost")]
        //[Authorize]
        public async Task<ActionResult> CreatePost([FromBody] CreatePostRequest request)
        {
            var post = await _postService.CreatePostAsync(request);
            return Ok(post);
        }
        [HttpPost("UpdatePost")]
        //[Authorize]
        public async Task<ActionResult> UpdatePost([FromBody] UpdatePostRequest request)
        {
            var post = await _postService.UpdatePostAsync(request);
            return Ok(post);
        }
        [HttpGet("GetPostById")]
        public async Task<ActionResult> GetPostById(string id)
        {
            var post = await _postService.GetPostByIdAsync(id); 
            return Ok(post);
        }
        [HttpPost("DeletePost")]
        //[Authorize]
        public async Task<ActionResult> DeletePost([FromBody] string id)
        {
            var post = await _postService.DeletePostAsync( id);
            return Ok(post);
        }
    }
}
