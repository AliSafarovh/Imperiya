using Imperiya.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imperiya.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnersController : ControllerBase
    {
        private readonly IPartnerService _partnerService;

        public PartnersController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _partnerService.TGetAllAsync();
            return Ok(values);
        }
    }
}
