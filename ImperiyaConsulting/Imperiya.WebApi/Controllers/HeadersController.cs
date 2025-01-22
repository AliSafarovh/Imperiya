using Imperiya.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imperiya.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadersController : ControllerBase
    {
        private readonly IHeaderService _headerService;

        public HeadersController(IHeaderService headerService)
        {
            _headerService = headerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _headerService.TGetAllAsync();
            return Ok(values);
        }
    }
}
