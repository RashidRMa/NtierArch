using Quizer.Core.Repositories.Special;
using Quizer.Core.Services;
using Quizer.Models.DTOs.QuestuinSets.Create;
using Quizer.Models.Entities;

namespace Quizer.Application.Services
{
    public class QuestionSetService : IQuestionSetService
    {
        private readonly IQuestionSetRepository questionSetRepository;

        public QuestionSetService(IQuestionSetRepository questionSetRepository)
        {
            this.questionSetRepository = questionSetRepository;
        }

        public QuestionSetCreateResponseDto Create(QuestionSetCreateDto request)
        {
            var entity = request.ToEntity();

            entity = questionSetRepository.Add(entity);

            questionSetRepository.Save();

            var response = QuestionSetCreateResponseDto.Create(entity);

            return response;
        }
    }
}
