using Imperiya.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imperiya.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicitiesController : ControllerBase
    {
        private readonly IPublicityService _publicityService;

        public PublicitiesController(IPublicityService publicityService)
        {
            _publicityService = publicityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _publicityService.TGetAllAsync();
            return Ok(values);
        }
    }
}
