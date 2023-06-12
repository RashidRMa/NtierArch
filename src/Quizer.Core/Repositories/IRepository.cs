using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Quizer.Core.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression = null); 
        T GetFirst(Expression<Func<T,bool>> expression = null);
        T Add (T entity);
        T Update (T entity, Action<EntityEntry<T>> rules = null);
        void Delete (T entity);
        int Save();


    }
}
