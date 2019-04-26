using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Ebay.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;

        public Repository(DbContext dataContext)
        {
            _dbSet = dataContext.Set<T>();
        }

        #region IRepository<T> Members

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetUserById(int id)
        {
            return _dbSet.Find(id);
        }

        #endregion IRepository<T> Members
    }
}