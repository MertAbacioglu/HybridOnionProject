using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.ResultModels;
using NLayer.Core.Wrappers;
using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IService<T1,T2> where T1 : BaseEntity where T2 : BaseDto
    {
        //Find Command
        Task<Response<T2>> FindAsync(params object[] values);

        //Linq 
        Task<Response<IEnumerable<T2>>> Where(Expression<Func<T1, bool>> expression);
        Task<Response<bool>> AnyAsync(Expression<Func<T1, bool>> expression);
        Task<Response<T2>> FirstOrDefault(Expression<Func<T1, bool>> exp);
        Task<Response<object>> Select(Expression<Func<T1, object>> exp); //toDo : usage ?
        Task<Response<IEnumerable<X>>> SelectViaClass<X>(Expression<Func<T1, X>> exp); //toDo : usage ?

        //List Commands
        Task<Response<IEnumerable<T2>>> GetAll();
        Task<Response<IEnumerable<T2>>> GetActives();
        Task<Response<IEnumerable<T2>>> GetPassives();
        Task<Response<IEnumerable<T2>>> GetModifieds();

        //Modify Commands
        Task<Response<NoContent>> AddAsync(T2 dto);
        Task<Response<NoContent>> AddRangeAsync(IEnumerable<T2> dtos);
        Task<Response<NoContent>> UpdateAsync(T2 dto);
        Task<Response<NoContent>> RemoveAsync(int id);
        Task<Response<NoContent>> RemoveRangeAsync(IEnumerable<T2> dtos);
        Task<Response<NoContent>> DestroyAsync(T2 dto);
        Task<Response<NoContent>> DestroyRangeAsync(IEnumerable<T2> dtos);
    }
}