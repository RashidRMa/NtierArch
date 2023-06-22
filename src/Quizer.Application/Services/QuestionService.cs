using Quizer.Core.Repositories.Special;
using Quizer.Core.Services;
using Quizer.Models.DTOs.Questions.Create;
using Quizer.Models.DTOs.Questions.GetById;
using Quizer.Models.DTOs.Questions.Save;
using Quizer.Models.DTOs.Questions.SaveAnswer;

namespace Quizer.Application.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }


        public QuestionCreateResponseDto Create(QuestionCreateDto request)
        {
            var entity = request.ToEntity();

            questionRepository.Add(entity);
            questionRepository.Save();

            var response = QuestionCreateResponseDto.Create(entity);

            return response;
        }

        public QuestionGetByIdResponseDto GetById(Guid id)
        {
            var entity = questionRepository.GetFirst(x=> x.Id == id);

            return QuestionGetByIdResponseDto.Create(entity);
        }

        public void Remove(Guid id)
        {
            var entity = questionRepository.GetFirst(x => x.Id == id);

            questionRepository.Delete(entity);
            questionRepository.Save();
        }

        public void RemoveAnswer(Guid id)
        {
            //5 - 27:24
        }

        public void Save(QuestionSaveDto request)
        {
            throw new NotImplementedException();
        }

        public QuestionSaveAnswerResonseDto SaveAnswer(QuestionSaveAnswerDto request)
        {
            throw new NotImplementedException();
        }
    }
}
