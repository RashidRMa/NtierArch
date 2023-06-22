using Quizer.Models.DTOs.Questions.Create;
using Quizer.Models.DTOs.Questions.GetById;
using Quizer.Models.DTOs.Questions.Save;
using Quizer.Models.DTOs.Questions.SaveAnswer;

namespace Quizer.Core.Services
{
    public interface IQuestionService
    {
        public QuestionCreateResponseDto Create(QuestionCreateDto request);

        public void Save(QuestionSaveDto request);

        public QuestionGetByIdResponseDto GetById(Guid id);

        public QuestionSaveAnswerResonseDto SaveAnswer(QuestionSaveAnswerDto request);

        public void RemoveAnswer(Guid id);
        public void Remove(Guid id);
    }
}
