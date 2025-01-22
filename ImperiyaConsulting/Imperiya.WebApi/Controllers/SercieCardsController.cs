using Imperiya.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Imperiya.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCardsController : ControllerBase
    {
        private readonly IServiceCardService _serviceCardService;

        public ServiceCardsController(IServiceCardService serviceCardService)
        {
            _serviceCardService = serviceCardService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList() 
        {
            var values=await _serviceCardService.TGetAllAsync();
            return Ok(values);
        }
    }
}
