using Quizer.Models.Entities;

namespace Quizer.Models.DTOs.Questions.Create
{
    public class QuestionCreateResponseDto
    {
        public string Text { get; set; }
        public Guid Id { get; set; }
        public byte Point { get; set; }


        public static QuestionCreateResponseDto Create(Question model)
        {
            return new QuestionCreateResponseDto
            { Id = model.Id, Text = model.Text, Point = model.Point };
        }
    }
}
