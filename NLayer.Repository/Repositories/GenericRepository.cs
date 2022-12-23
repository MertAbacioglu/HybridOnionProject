using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using NLayer.Core.Enums;
using NLayer.Core.ModelInterfaces;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using System.Linq;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NLayer.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        
        public void Add(T entity)
        {
            _dbSet.Add(entity);
           
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
                _dbSet.Add(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public void Remove(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                 entity.DeletedDate = DateTime.Now;
                _context.Attach(entity);
            }
            _dbSet.Update(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    entity.DeletedDate = DateTime.Now;
                    _context.Attach(entity);
                }          
            _dbSet.UpdateRange(entities);
        }

        public async Task<T> FindAsync(params object[] values)
        {
            return await _dbSet.FindAsync(values);
        }
        
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await GetAllAsIQueryable().FirstOrDefaultAsync(exp);
        }

        
        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> expression)
        {
            return  await _dbSet.Where(expression).ToListAsync();
        }
        
        public void Destroy(T entity)
        {
            throw new NotImplementedException();
        }

        public void DestroyRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<object> Select(Expression<Func<T, object>> exp)
        {
            return await GetAllAsIQueryable().Select(exp).ToListAsync();
        }

        public void Update(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                 entity.UpdatedDate = DateTime.Now;
                _context.Attach(entity);
            }
            _dbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    entity.UpdatedDate = DateTime.Now;
                    _context.Attach(entity);
                }
            _dbSet.UpdateRange(entities);
        }

        public async Task<IEnumerable<T>> GetDeletedAsync()
        {
            return await GetAllAsIQueryable().Where(x => x.Status == DataStatus.Deleted).ToListAsync();
        }

        public IQueryable<T> GetAllAsIQueryable()
        {
            return _dbSet.AsNoTracking();
        }
    }
}