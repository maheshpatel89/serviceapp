using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceApp
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {

        public string RedirectToController { get; set; }
        public string RedirectToAction { get; set; }
        public string RedirectToPage { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new RedirectToRouteResult(ConstructRouteValueDictionary());
            }
        }

        private RouteValueDictionary ConstructRouteValueDictionary()
        {
            var dictionary = new RouteValueDictionary();

            if (!string.IsNullOrWhiteSpace(RedirectToPage))
            {
                dictionary.Add("page", RedirectToPage);
            }
            // Assuming RedirectToController & RedirectToAction are set
            else
            {
                dictionary.Add("controller", RedirectToController);
                dictionary.Add("action", RedirectToAction);
            }

            return dictionary;
        }

    }
}
