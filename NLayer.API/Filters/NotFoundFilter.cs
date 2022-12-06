using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;
using NLayer.Core.Wrappers;

namespace NLayer.API.Filters
{
    public class NotFoundFilter<T1,T2> :IAsyncActionFilter where T1 : BaseEntity where T2 : BaseDto
    {

        private readonly IService<T1,T2> _service;

        public NotFoundFilter(IService<T1, T2> service)
        {
            _service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            object idValue = context.ActionArguments.Values.FirstOrDefault(); //bana ilk gelen değeri al

            if (idValue == null)
            {
                await next.Invoke(); //yola devam et
                return;
            }

            int id = (int)idValue;
            Response<bool> anyEntity = await _service.AnyAsync(x => x.Id == id);

            if (anyEntity.Data)
            {
                await next.Invoke();
                return;
            }

            context.Result = new NotFoundObjectResult(Response<NoContentResult>.Fail(404, $"{typeof(T1).Name}({id}) not found"));

        }
    }
}
