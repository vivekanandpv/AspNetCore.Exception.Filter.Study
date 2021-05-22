using AspNetCore.Exception.Filter.Study.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Exception.Filter.Study.Filters
{
    public class GeneralExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order => Int32.MaxValue - 10;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is DomainValidationException)
            {
                context.Result = new ObjectResult(new { Message = "Validations are failing" })
                {
                    StatusCode = 400
                };

                context.ExceptionHandled = true;
            }

            if (context.Exception is AuthException)
            {
                context.Result = new ObjectResult(new { Message = "Unauthorized" })
                {
                    StatusCode = 401
                };

                context.ExceptionHandled = true;
            }

            //  wild-card or catch-all
            if (!context.ExceptionHandled && context.Exception != null)
            {
                context.Result = new ObjectResult(new { Message = "Cannot process..." })
                {
                    StatusCode = 400
                };

                context.ExceptionHandled = true;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
