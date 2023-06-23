using Microsoft.AspNetCore.Mvc;
using Quizer.Core.Services;
using Quizer.Models.DTOs.Questions.Create;
using Quizer.Models.DTOs.Questions.Save;
using Quizer.Models.DTOs.Questions.SaveAnswer;

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

        [HttpPost]
        public IActionResult Create(QuestionCreateDto request)
        {
            var response = questionService.Create(request);
            return Ok(response);


        }

        [HttpPost("save")]
        public IActionResult Save(QuestionSaveDto request)
        {
            questionService.Save(request);
            return NoContent();
        } 
        
        [HttpPost("save-answer")]
        public IActionResult SaveAnswer(QuestionSaveAnswerDto request)
        {
           var response =  questionService.SaveAnswer(request);
            return Ok(response);
        }

        [HttpPost("{id}")]
        public IActionResult GetById(Guid id)
        {
            var response = questionService.GetById(id);
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            questionService.Remove(id);
            return NoContent();
        }

        [HttpDelete("remove-answer{id}")]
        public IActionResult RemoveAnswer(Guid id)
        {
            questionService.RemoveAnswer(id);
            return NoContent();
        }
    }
}
