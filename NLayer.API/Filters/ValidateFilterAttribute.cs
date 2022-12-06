using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.ResultModels;
using NLayer.Core.Wrappers;

namespace NLayer.API.Filters
{
 
    public class ValidateFilterAttribute :ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
           if(!context.ModelState.IsValid)
            {
                List<string> errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();

                context.Result = new BadRequestObjectResult(Response<NoContent>.Fail(400, errors));


            }
        }
    }
}
