using FFP.CoreUtilities;
using FFP.Validations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ApiTestValidationFilter.Filters
{

    public class ValidationActionFilter : IActionFilter
    {
        public ValidationActionFilter()
        {
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            foreach (string key in context.ActionArguments.Keys)
            {
                if (!context.ActionArguments[key].GetType().IsValueType)
                {
                    IEnumerable<IBrokenRule> broke = ValidationPackages.Validate(context.ActionArguments[key]);
                    if (broke.IsNotEmpty())
                        context.Result = new BadRequestObjectResult(broke);
                }
            }
        }
    }

    //public class ValidationAsyncActionFilter : IAsyncActionFilter
    //{
    //    public async Task OnActionExecutionAsync(
    //        ActionExecutingContext context,
    //        ActionExecutionDelegate next)
    //    {
    //        Task<BadRequestObjectResult> task = CheckRules(context);

    //        var resultContext = await next();

    //    }

    //    async Task<BadRequestObjectResult> CheckRules(ActionExecutingContext context)
    //    {
    //        BadRequestObjectResult bor = await
    //        foreach (string key in context.ActionArguments.Keys)
    //        {
    //            if (!context.ActionArguments[key].GetType().IsValueType)
    //            {
    //                IEnumerable<IBrokenRule> broke = ValidationPackages.Validate(context.ActionArguments[key]);
    //                if (broke.IsNotEmpty())
    //                    return new BadRequestObjectResult(broke);
    //            }
    //        }
    //    }
    //}
}


