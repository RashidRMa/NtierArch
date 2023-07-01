using Microsoft.EntityFrameworkCore;
using Quizer.Core.Repositories;
using Quizer.Core.Repositories.Special;
using Quizer.Models.Entities;

namespace Quizer.DataAccess.Repositories
{
    internal class QuestionSetRepository : Repository<QuestionSet>, IQuestionSetRepository
    {
        public QuestionSetRepository(DbContext db) : base(db)
        {

        }
    }
}
