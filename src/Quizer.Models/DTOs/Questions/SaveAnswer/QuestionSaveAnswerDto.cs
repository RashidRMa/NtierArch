using Quizer.Models.Entities;

namespace Quizer.Models.DTOs.Questions.SaveAnswer
{
    public class QuestionSaveAnswerDto
    {

        public Guid? Id { get; set; }
        public Guid QuestionId { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public Answer ToModel()
        {
            return new Answer
            {
                Id = Guid.NewGuid(),
                Text = this.Text,
                IsCorrect = this.IsCorrect,
                QuestionId = this.QuestionId

            };
        }

        
    }
}
