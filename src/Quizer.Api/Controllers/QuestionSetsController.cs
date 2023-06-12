using Microsoft.AspNetCore.Mvc;
using Quizer.Core.Services;
using Quizer.Models.DTOs.QuestuinSets.Create;

namespace Quizer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionSetsController : ControllerBase
    {
        private readonly IQuestionSetService questionSetService;

        public QuestionSetsController(IQuestionSetService questionSetService)
        {
            this.questionSetService = questionSetService;
        }

        [HttpPost]
        public IActionResult Create(QuestionSetCreateDto request)
        {
            var response = questionSetService.Create(request);

            return Ok(response);
        }
    }
}
