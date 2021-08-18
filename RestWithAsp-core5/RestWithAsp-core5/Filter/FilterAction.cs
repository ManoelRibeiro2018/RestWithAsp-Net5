using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Filter
{
    public class FilterAction : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var msg = context.ModelState.SelectMany(erro => erro.Value.Errors).Select(msg => msg.ErrorMessage);

                context.Result = new BadRequestObjectResult(msg);
            }
        }
    }
}
