using AwesomeGym.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGym.API.Filter
{
    public class ModelStateValidatorFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errosModel = context.ModelState
                    .Values
                    .SelectMany(x => x.Errors)
                    .Select(y => y.ErrorMessage);

                var errors = new ErrosViewModel(errosModel.ToList());

                context.Result = new BadRequestObjectResult(errors);
            }
        }
    }

}
