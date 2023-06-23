using Quizer.Models.Entities;

namespace Quizer.Models.DTOs.Questions.SaveAnswer
{
    public class QuestionSaveAnswerResonseDto
    {
        public Guid Id { get; set; }

        public bool IsCorrect { get; set; }

        public string Text { get; set; }

        public static QuestionSaveAnswerResonseDto Create(Answer model)
        {
            return new QuestionSaveAnswerResonseDto
            {
                Id = model.Id,
                Text = model.Text,
                IsCorrect = model.IsCorrect,

            };
        }

    }
}
