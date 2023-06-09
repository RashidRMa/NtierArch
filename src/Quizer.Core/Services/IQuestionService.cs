using Quizer.Models.DTOs.Questions.Create;
using Quizer.Models.DTOs.Questions.GetById;

namespace Quizer.Core.Services
{
    public interface IQuestionService
    {
        public QuestionCreateResponseDto Create(QuestionCreateDto request);

        public QuestionGetByIdResponseDto GetById(int id);
    }
}
