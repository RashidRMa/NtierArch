using Quizer.Models.Entities;

namespace Quizer.Models.DTOs.QuestuinSets.Create
{
    public class QuestionSetCreateResponseDto 
    {
        public Guid Id { get; set; }

        public string Subject { get; set; }


        public static QuestionSetCreateResponseDto Create(QuestionSet model)
        {
            return new QuestionSetCreateResponseDto
            {
                Id = model.Id,
                Subject = model.Subject,
            };
        }
    }
}
