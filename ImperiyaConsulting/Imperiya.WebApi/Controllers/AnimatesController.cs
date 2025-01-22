using Imperiya.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imperiya.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimatesController : ControllerBase
    {
        private readonly IAnimatedService _animatedService;

        public AnimatesController(IAnimatedService animatedService)
        {
            _animatedService = animatedService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _animatedService.TGetAllAsync();
            return Ok(values);
        }
    }
}
