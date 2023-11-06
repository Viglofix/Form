using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Container;
using Services.Service;

namespace FormAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class ClickUpController : ControllerBase
    {
        // Dependency Injection Section
        private readonly IClickUpService _clickUpService;
        public ClickUpController(IClickUpService clickUpService)
        {
            _clickUpService = clickUpService;
        }
        [HttpGet("GetAllSpecializations")]
        public async Task<IActionResult> GetAllSpecializations()
        {
            var specObj = _clickUpService.GetAllSpecialization();
            if(specObj is null)
            {
                return NotFound();
            }
            return Ok(await specObj);
        }
    }
}
