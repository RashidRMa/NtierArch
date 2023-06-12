namespace Quizer.Models.DTOs.Questions.Create
{
    public class QuestionCreateDto
    {
        public Guid QuestionSetId { get; set; }
        public string Text { get; set; }
        public byte Point { get; set; }

    }
}
