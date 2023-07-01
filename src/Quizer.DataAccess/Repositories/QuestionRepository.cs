using Microsoft.EntityFrameworkCore;
using Quizer.Core.Repositories;
using Quizer.Core.Repositories.Special;
using Quizer.Models.Entities;

namespace Quizer.DataAccess.Repositories
{
    internal class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(DbContext db) : base(db)
        {
        }

        public bool IsCorrect(Guid questionId, Guid answerId)
        {
            throw new NotImplementedException();
        }
    }
}
