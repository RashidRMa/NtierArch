namespace Quizer.Models.DTOs.Questions.Create
{
    public class QuestionCreateResponseDto
    {
        public string Text { get; set; }
        public Guid Id { get; set; }
        public byte Point { get; set; }
    }
}
