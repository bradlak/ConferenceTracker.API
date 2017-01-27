using ConferenceTracker.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ConferenceTracker.API.Repositories
{
    public class GenericRepository<TContext,TEntity>
        where TContext : DbContext
        where TEntity : BaseEntity
    {
        private TContext context;

        public GenericRepository(TContext context)
        {
            this.context = context;
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate != null)
            {
                return context.Set<TEntity>().Where(predicate).SingleOrDefault();
            }
            else
            {
                return null;
            }
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return context.Set<TEntity>().Where(predicate);
            }
            else
            {
                return context.Set<TEntity>();
            }
        }
    }
}
