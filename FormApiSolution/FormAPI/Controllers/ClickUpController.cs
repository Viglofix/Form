﻿using DataBase;
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
using Microsoft.AspNetCore.RateLimiting;

namespace FormAPI.Controllers
{
    [Authorize]
    [EnableRateLimiting("fixed")]
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

        /*  [AllowAnonymous]
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
          [AllowAnonymous]
          [HttpGet("GetAllEnglishLevels")]
          public async Task<IActionResult> GetAllEnglishLevels()
          {
              var englishObj = _clickUpService.GetAllEnglishLevel();
              if(englishObj is null)
              {
                  return NotFound();
              }
              return Ok(await englishObj);
          } */
        [HttpPost("CreateDropFile")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateDropFile(List<IFormFile> files)
        {
            var obj = _clickUpService.CreateDropFile(files);
            if(obj is null)
            {
                return NotFound();
            }
            return Ok(await obj);
        }
        [HttpGet("GetAllSchools")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllSchools(){
            var obj = _clickUpService.GetAllSchools();
            if(obj is null) {
                return NotFound();
            }
            return Ok(await obj);
        }
        [HttpGet("GetAllUsers")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllUsers()
        {
            var obj = _clickUpService.GetAllUsers();
            if(obj is null)
            {
                return NotFound();
            }
            return Ok(await obj);
        }
        [HttpPost("CreateUser")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromForm] ClickUpRequiredDataModelRequest clickUp) 
        {
            var obj = await _clickUpService.CreateUser(clickUp);
            if(obj is null || obj.ResponseCode == 404)
            {
                return NotFound(obj);
            }
            return Created("",obj);
        }
        [HttpGet("GetAllMembers")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllMembers(){
            var obj = await _clickUpService.GetAllMembers();
            if(obj is null)
            {
                return NotFound(obj);
            }
            return Ok(obj);
        }
    }
}
