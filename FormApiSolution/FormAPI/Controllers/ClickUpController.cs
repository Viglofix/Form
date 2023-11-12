using DataBase;
using DataBase.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Container;
using Services.Service;
using Npgsql;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace FormAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    //[DisableCors]
    [ApiController]

    public class ClickUpController : ControllerBase
    {
        // Dependency Injection Section
        private readonly FormDbContext _dbContext;
        private readonly IClickUpService _clickUpService;
        private readonly IConfiguration _configuration;
        public ClickUpController(IClickUpService clickUpService, FormDbContext dbContext, IConfiguration configuration)
        {
            _clickUpService = clickUpService;
            _dbContext = dbContext;
            _configuration = configuration;
        }

        [AllowAnonymous]
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

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(ClickUpRequiredDataModel clickUp)
        {
            /*  var obj = _clickUpService.CreateUser(clickUp);
              if(obj is null)
              {
                  return NotFound();
              }
              return Ok(await obj); */
            /*   var query = "SELECT NEXTVAL('\"StatusOfRecruiterModel_id_status_of_recruiter_seq\"')";
              var nextval = _dbContext.status_of_recruiter.FromSqlRaw(query);
              string result = nextval.ToString(); */
            /* long? seq;
            using (var npqsqlConnection = new NpgsqlConnection(_configuration.GetConnectionString("FormDb")))
            {
                await npqsqlConnection.OpenAsync();
                using (var npgsqlCommand = new NpgsqlCommand("SELECT NEXTVAL('\"StatusOfRecruiterModel_id_status_of_recruiter_seq\"')",npqsqlConnection))
                {
                    seq = (long?)npgsqlCommand.ExecuteScalar();
                }
                await npqsqlConnection.CloseAsync();
            } */

            var obj = _clickUpService.CreateUser(clickUp);
            if(obj is null)
            {
                return NotFound();
            }
            return Ok(await obj);
        }
    }
}
