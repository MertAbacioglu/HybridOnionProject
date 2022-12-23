using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.ResultModels;
using NLayer.Core.Wrappers;
using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IService<T1, T2> where T1 : BaseEntity where T2 : IBaseDto
    {
        //Find Command
        Task<Response<T2>> FindAsync(bool tracking = true, params object[] values);

        //Linq 
        Task<Response<IEnumerable<T2>>> Where(Expression<Func<T1, bool>> expression, bool tracking = true);
        Task<Response<bool>> AnyAsync(Expression<Func<T1, bool>> expression, bool tracking = true);
        Task<Response<T2>> FirstOrDefault(Expression<Func<T1, bool>> expression, bool tracking = true);
        Task<Response<object>> Select(Expression<Func<T1, object>> expression, bool tracking = true); //toDo : usage ?

        //List Commands
        Task<Response<IEnumerable<T2>>> GetAll(bool tracking = true);
        Task<Response<IEnumerable<T2>>> GetActives(bool tracking = true);
        Task<Response<IEnumerable<T2>>> GetPassives(bool tracking = true);
        Task<Response<IEnumerable<T2>>> GetModifieds(bool tracking = true);

        //Modify Commands
        Task<Response<NoContent>> AddAsync(T2 dto);
        Task<Response<NoContent>> AddRangeAsync(IEnumerable<T2> dtos);
        Task<Response<NoContent>> UpdateAsync(T2 dto);
        Task<Response<NoContent>> RemoveAsync(T2 dto);
        Task<Response<NoContent>> RemoveRangeAsync(IEnumerable<T2> dtos);
        Task<Response<NoContent>> DestroyAsync(T2 dto);
        Task<Response<NoContent>> DestroyRangeAsync(IEnumerable<T2> dtos);
    }
}