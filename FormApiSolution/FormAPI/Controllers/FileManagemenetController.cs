using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Container;
using Services.Service;
using System.Formats.Asn1;

namespace FormAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FileManagemenetController : ControllerBase
    {
        private readonly IFileManagementService _fileManagementService;
        public FileManagemenetController(IFileManagementService fileManagementService)
        {
            _fileManagementService = fileManagementService;
        }
        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var obj = _fileManagementService.UploadFile(file);
            if(obj is null)
            {
                return NotFound();
            }
            return Ok(await obj); 
        }
    }
}
