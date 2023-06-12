using Quizer.Models.Common;

namespace Quizer.Models.Entities
{
    public class Question : BaseEntity<Guid>
    {
        public string Text { get; set; }
        public Guid QuestionSetId { get; set; }
        public byte Point { get; set; }

    }
}
