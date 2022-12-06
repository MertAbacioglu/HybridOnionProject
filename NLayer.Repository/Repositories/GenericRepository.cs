using Microsoft.EntityFrameworkCore;
using NLayer.Core.Enums;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using System.Linq.Expressions;

namespace NLayer.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {

            await _dbSet.AddAsync(entity);


        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public IQueryable<T> GetAllAsIQueryable()
        {
            return _dbSet.AsNoTracking().AsQueryable();

        }
        public IQueryable<T> GetActivesAsIQueryable()
        {
            return GetAllAsIQueryable().Where(x => x.Status != DataStatus.Deleted);
        }

        public IQueryable<T> GetPassivesAsIQueryable()
        {
            return GetAllAsIQueryable().Where(x => x.Status == DataStatus.Deleted);
        }

        public IQueryable<T> GetModifiedsAsIQueryable()
        {
            return GetAllAsIQueryable().Where(x => x.Status == DataStatus.Updated);
        }
        
        public void Remove(T entity)
        {
            entity.Status = DataStatus.Deleted;
            _dbSet.Update(entity);
        }
        
        public void Destroy(T entity)
        {
            _dbSet.Remove(entity);

        }
        
        public void DestroyRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            foreach (T item in entities)
            {
                item.Status = DataStatus.Deleted;
            }
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            entity.Status = DataStatus.Updated;
            _dbSet.Update(entity);
        }
        
        public void UpdateRange(IEnumerable<T> entities)
        {
            foreach (T item in entities)
            {
                item.Status = DataStatus.Updated;
            }
            _dbSet.UpdateRange(entities);
        }
        
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public async Task<T> FindAsync(params object[] values)
        {
            T entity = await _dbSet.FindAsync(values);
            //_dbSet.Entry(entity).State = EntityState.Detached; //toDo : alternative
            return entity;            
        }

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return await _dbSet.FirstOrDefaultAsync(exp);
        }

        public async Task<object> Select(Expression<Func<T, object>> exp)
        {
            return await _dbSet.Select(exp).ToListAsync();
        }

        public IQueryable<X> SelectViaClass<X>(Expression<Func<T, X>> exp)
        {
            return _dbSet.Select(exp);
        }

    }
}