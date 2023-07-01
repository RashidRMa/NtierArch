using Microsoft.EntityFrameworkCore;
using Quizer.Core.Repositories;
using Quizer.Core.Repositories.Special;
using Quizer.Models.Entities;

namespace Quizer.DataAccess.Repositories
{
    internal class SessionRepository : Repository<Session>, ISessionRepository
    {
        public SessionRepository(DbContext db) : base(db)
        {
        }
    }
}
