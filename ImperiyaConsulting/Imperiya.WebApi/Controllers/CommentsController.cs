using Imperiya.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imperiya.WebApi.Controllers
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
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _commentService.TGetAllAsync();
            return Ok(values);
        }
    }
}
