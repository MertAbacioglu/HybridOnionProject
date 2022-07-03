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

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
           
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
            foreach (T entity in entities)
            {
                
                _dbSet.Update(entity);

            }
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }


    }
}
