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
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> exp);
        Task<object> Select(Expression<Func<T, object>> exp); //toDo : usage ?
        IQueryable<X> SelectViaClass<X>(Expression<Func<T, X>> exp); //toDo : usage ?

        //List Commands
        IQueryable<T> GetAllAsIQueryable();
        IQueryable<T> GetActivesAsIQueryable();
        IQueryable<T> GetPassivesAsIQueryable();
        IQueryable<T> GetModifiedsAsIQueryable();

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