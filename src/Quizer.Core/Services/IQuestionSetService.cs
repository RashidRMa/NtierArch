using Quizer.Models.DTOs.QuestuinSets.Create;

namespace Quizer.Core.Services
{
    public interface IQuestionSetService
    {
        public QuestionSetCreateResponseDto Create(QuestionSetCreateDto request);

    }
}
