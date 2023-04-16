namespace PeopleActzAndPostz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCommentsController : ControllerBase
    {
        private readonly ISubCommentService _subCommentService;

        public SubCommentsController(ISubCommentService subCommentService)
        {
            _subCommentService = subCommentService;
        }

        [HttpPost("CreateSubComment")]
        //[Authorize]
        public async Task<ActionResult> CreateSubComment([FromBody] CreateSubCommentRequest request)
        {
            var subComment = await _subCommentService.CreateSubCommentAsync(request);
            return Ok(subComment);
        }
        [HttpPost("UpdateSubComment")]
        //[Authorize]
        public async Task<ActionResult> UpdateSubComment([FromBody] UpdateSubCommentRequest request)
        {
            var subComment = await _subCommentService.UpdateSubCommentAsync(request);
            return Ok(subComment);
        }
        [HttpGet("GetSubCommentById")]
        public async Task<ActionResult> GetSubCommentById(string id)
        {
            var subComment = await _subCommentService.GetSubCommentDetailById(id);
            return Ok(subComment);
        }
        [HttpDelete("DeleteSubComment")]
        //[Authorize]
        public async Task<ActionResult> DeleteSubComment([FromBody] string id)
        {
            var subComment = await _subCommentService.DeleteSubCommentAsync(id);
            return Ok(subComment);
        }

    }
}
