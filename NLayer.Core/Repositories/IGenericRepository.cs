using NLayer.Core.ModelInterfaces;
using NLayer.Core.Models;
using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {

        //Find Command
        Task<T> FindAsync(params object[] values);

        //Linq 
        IQueryable<T> Where(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> exp, bool tracking = true);
        Task<object> Select(Expression<Func<T, object>> exp, bool tracking = true); //toDo : usage ?

        //List Commands
        IQueryable<T> GetAllAsIQueryable(bool tracking = true);
        IQueryable<T> GetActivesAsIQueryable(bool tracking = true);
        IQueryable<T> GetPassivesAsIQueryable(bool tracking = true);
        IQueryable<T> GetModifiedsAsIQueryable(bool tracking = true);

        //Modify Commands
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Destroy(T entity);
        void DestroyRange(IEnumerable<T> entities);
    }
}