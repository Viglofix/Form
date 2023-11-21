﻿using DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Services.Service;

namespace FormAPI.Controllers
{
    [Authorize]
    [EnableRateLimiting("fixed")]
    [Route("[controller]")]
    //[DisableCors]
    [ApiController]
    public class QuizController : ControllerBase
    {
        // Dependency Injection Section
        private readonly FormDbContext _dbContext;
        private readonly IQuizService _quizService;
        private readonly IClickUpService _clickUpService;
        private readonly IConfiguration _configuration;
        public QuizController(IClickUpService clickUpService, FormDbContext dbContext, IConfiguration configuration,IQuizService quiz)
        {
            _quizService = quiz;
            _clickUpService = clickUpService;
            _dbContext = dbContext;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpGet("GetQuestion")]
        public async Task<IActionResult> GetQuestion(string specialization)
        {
            var obj = _quizService.GetQuestion(specialization);
            if (obj is null)
            {
                return NotFound();
            }
            return Ok(await obj);
        }
    }
}