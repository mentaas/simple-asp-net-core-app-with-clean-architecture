using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbcTestApp.Web.Extensions
{
    public class RedirectIfSignInMiddleware
    {
        private readonly RequestDelegate _next;

        public RedirectIfSignInMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path;
            var query = context.Request.QueryString;


            //    var controllerActionDescriptor = context
            //.GetEndpoint();
            ////.Metadata
            ////.GetMetadata<ControllerActionDescriptor>();

            //    var controllerName = controllerActionDescriptor.ControllerName;
            //    var actionName = controllerActionDescriptor.ActionName;

            //    if (controllerName.ToLowerInvariant().Equals("users"))
            //        if (actionName.ToLowerInvariant().Equals("signin") || actionName.ToLowerInvariant().Equals("signup"))
            //            context.Response.Redirect("/");

            if (context.User.Identity.IsAuthenticated)
                if (path.ToString().ToLowerInvariant().Contains("/users/signin") || path.ToString().ToLowerInvariant().Contains("/users/signup"))
                    context.Response.Redirect("/");

            // Call the next delegate/middleware in the pipeline
            await _next(context);
        }
    }
}
