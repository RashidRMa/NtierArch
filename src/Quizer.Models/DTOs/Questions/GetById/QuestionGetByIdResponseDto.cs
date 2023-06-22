using Quizer.Models.Entities;

namespace Quizer.Models.DTOs.Questions.GetById
{
    public class QuestionGetByIdResponseDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public static QuestionGetByIdResponseDto Create(Question model)
        {
            return new QuestionGetByIdResponseDto
            {
                Id = model.Id,
                Text = model.Text,
            };
        }
    }
}
