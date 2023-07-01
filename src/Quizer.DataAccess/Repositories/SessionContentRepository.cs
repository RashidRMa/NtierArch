using Microsoft.EntityFrameworkCore;
using Quizer.Core.Repositories;
using Quizer.Core.Repositories.Special;
using Quizer.Models.Entities;

namespace Quizer.DataAccess.Repositories
{
    internal class SessionContentRepository : Repository<SessionContent>, ISessionContentRepository
    {
        public SessionContentRepository(DbContext db) : base(db)
        {
        }
    }
}
