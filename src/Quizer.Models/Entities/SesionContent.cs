namespace Quizer.Models.Entities
{
    public class SesionContent
    {
        public Guid SessionId { get; set; }
        public Guid SubscriberId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid AnswerId { get; set; }
        public bool Success { get; set; }
    }
}
