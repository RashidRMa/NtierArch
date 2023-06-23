using Quizer.Core.Extensions;
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
        private readonly IAnswerRepository answerRepository;

        public QuestionService(IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            this.questionRepository = questionRepository;
            this.answerRepository = answerRepository;
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
            var entity = questionRepository.GetFirst(x => x.Id == id);

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
            var entity = answerRepository.GetFirst(x => x.Id == id);

            answerRepository.Delete(entity);
        }


        public void Save(QuestionSaveDto request)
        {
            var question = questionRepository.GetFirst(x=>x.Id == request.Id);

            questionRepository.Update(question, entry =>
            {
                entry.SetValue(x => x.Text, request.Text)
                .SetValue(x => x.Point, request.Point)
                .SetValue(x => x.QuestionSetId, request.QuestionSetId);
            });

            var correctAnswer = answerRepository.GetFirst(x=> x.Id == request.CorrectAnswerId, false);

            if(correctAnswer != null)
            {
                answerRepository.Update(correctAnswer, entry => entry.SetValue(x => x.IsCorrect, true));

                var otherAnswers = answerRepository.GetAll(x => x.QuestionId == request.Id && x.Id != request.CorrectAnswerId).ToArray();

                foreach (var item in otherAnswers)
                {
                    answerRepository.Update(item, entry => entry.SetValue(x => x.IsCorrect, false));
                }
            }
        }


        public QuestionSaveAnswerResonseDto SaveAnswer(QuestionSaveAnswerDto request)
        {
            //todo: eger exception qaytarsa elave serte gerek olacaq.
            var answer = answerRepository.GetFirst(x => x.Id == request.Id, false);

            if (answer is null)
            {
                answer = request.ToModel();
                answerRepository.Add(answer);
            }
            else
            {
                answerRepository.Update(answer, entry =>
                {
                    entry.SetValue(x => x.IsCorrect, request.IsCorrect);
                    entry.SetValue(x => x.QuestionId, request.QuestionId);
                    entry.SetValue(x => x.Text, request.Text);
                });
            }

            if (request.IsCorrect)
            {
                var otherAnswers = answerRepository.GetAll(x => x.QuestionId == answer.QuestionId && x.Id != request.Id).ToArray();

                foreach (var item in otherAnswers)
                {
                    answerRepository.Update(item, entry => entry.SetValue(x => x.IsCorrect, false));
                }
            }

            answerRepository.Save();

            return QuestionSaveAnswerResonseDto.Create(answer);
        }
    }
}
