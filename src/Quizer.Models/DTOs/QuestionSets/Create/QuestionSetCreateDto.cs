using Quizer.Models.Entities;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Quizer.Models.DTOs.QuestuinSets.Create
{
    public class QuestionSetCreateDto
    {
        public string Subject { get; set; }

        public QuestionSet ToEntity()
        {
            return new QuestionSet
            {
                Id = Guid.NewGuid(),
                Subject = this.Subject
            };
        }
    }

    
}
