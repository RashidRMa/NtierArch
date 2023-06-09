using Microsoft.AspNetCore.Mvc;
using Quizer.Core.Services;
using Quizer.Models.DTOs.Questions.Create;

namespace Quizer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService questionService;

        public QuestionsController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        [HttpGet]
        public IActionResult Create(QuestionCreateDto request)
        {
            var response = questionService.Create(request);
            return Ok(response);
        }

        [HttpPost("{id}")]
        public IActionResult Create(int id)
        {
            var response = questionService.GetById(id);
            return Ok(response);
        }
    }
}
