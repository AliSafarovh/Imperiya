using Imperiya.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imperiya.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicsesController : ControllerBase
    {
        private readonly IPicsService _picsesService;

        public PicsesController(IPicsService picsesService)
        {
            _picsesService = picsesService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _picsesService.TGetAllAsync();
            return Ok(values);
        }
    }
}
