using System;
using System.Web;
using System.Web.Mvc;
using ControlTask2.Interfaces;
using ControlTask2.Models;
using Microsoft.AspNet.Identity.Owin;

namespace ControlTask2.Attributes
{
    public class CustomActionFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var manager = filterContext.HttpContext.GetOwinContext().Get<IQueriesManager>();

            bool auth = filterContext.HttpContext.User.Identity.IsAuthenticated;
            if (auth)
            {
                manager.CreateQuery(new ApplicationQuery()
                {
                    UserName = filterContext.HttpContext.User.Identity.Name,
                    ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                    ActionName = filterContext.RouteData.Values["action"].ToString(),
                    DateTime = DateTime.Now
                });
            }
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
    }
}