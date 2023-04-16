namespace PeopleActzAndPostz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }


        [HttpPost("CreateComment")]
        //[Authorize]
        public async Task<ActionResult> CreatePost([FromBody] CreateCommentRequest request)
        {
            var comment = await _commentService.CreateCommentAsync(request);
            return Ok(comment);
        }
        [HttpPost("UpdateComment")]
        //[Authorize]
        public async Task<ActionResult> UpdateComment([FromBody] UpdateCommentRequest request)
        {
            var comment = await _commentService.UpdateCommentAsync(request);
            return Ok(comment);
        }
        [HttpGet("GetCommentById")]
        public async Task<ActionResult> GetCommentById(string id)
        {
            var comment = await _commentService.GetCommentDetailByIdAsync(id);
            return Ok(comment);
        }
        [HttpDelete("DeleteComment")]
        //[Authorize]
        public async Task<ActionResult> DeleteComment([FromBody] string id)
        {
            var comment = await _commentService.DeleteCommentAsync(id);
            return Ok(comment);
        }
    }
}
