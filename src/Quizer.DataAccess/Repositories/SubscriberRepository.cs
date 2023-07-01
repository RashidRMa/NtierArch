using Microsoft.EntityFrameworkCore;
using Quizer.Core.Repositories;
using Quizer.Core.Repositories.Special;
using Quizer.Models.Entities;

namespace Quizer.DataAccess.Repositories
{
    internal class SubscriberRepository : Repository<Subscriber>, ISubscriberRepository
    {
        public SubscriberRepository(DbContext db) : base(db)
        {
        }
    }
}
