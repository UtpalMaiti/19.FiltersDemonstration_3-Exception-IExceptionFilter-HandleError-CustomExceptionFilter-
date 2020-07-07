using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersDemonstration_3.UtilityClasses
{
    public class CustomExceptionFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string controllerName = filterContext.RouteData.Values["controller"].ToString();

            string actionName = filterContext.RouteData.Values["action"].ToString();

            Exception ex = filterContext.Exception;

            //Write the Code to Log this Exception...

            filterContext.Result = new ViewResult
            {
                ViewName = "CustomErrorView"
            };

            filterContext.ExceptionHandled = true;
        }
    }
}