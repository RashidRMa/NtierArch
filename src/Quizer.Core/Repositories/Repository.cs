using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Quizer.Core.Extensions;
using System.Linq.Expressions;

namespace Quizer.Core.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly DbContext db;
        private readonly DbSet<T> table;


        public Repository(DbContext db)
        {
            this.db = db;
            this.table = db.Set<T>();
        }

        protected DbContext Db { get => this.db; }
        protected DbSet<T> Table { get => this.table; }

        public T Add(T entity)
        {
            this.table.Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            this.table.Remove(entity);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            var query = this.table.AsQueryable();
            if (expression is not null)
                query = query.Where(expression);
            return query;

        }

        public T GetFirst(Expression<Func<T, bool>> expression = null)
        {
            var query = this.table.AsQueryable();
            if (expression is not null)
                query = query.Where(expression);
            return query.FirstOrDefault();
        }

        public int Save()
        {
            return this.db.SaveChanges();
        }

        public T Update(T entity, Action<EntityEntry<T>> rules = null)
        {
            var entry = db.Entry(entity);

            if (rules == null) goto summary;

            foreach (var propertyInfo in typeof(T).GetProperties().Where(m => m.IsEditable()))
            {
                entry.Property(propertyInfo.Name).IsModified = false;

            }

            rules(entry);

        summary:
            entry.State = EntityState.Modified;

            return entity;

        }
    }
}
