using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CharityBounce.Controllers
{
    public class NewsletterDemoController : IController //You would not do this normally
    {
        private HttpRequestBase Request;
        private HttpResponseBase Response;

        public void Execute(RequestContext requestContext)
        {
            Request = requestContext.HttpContext.Request;
            Response = requestContext.HttpContext.Response;
            var actionName = requestContext.RouteData.Values["action"];

            switch (actionName)
            {
                case "register":
                    Register();
                    break;
                case "unregister":
                    Unregister();
                    break;
            }
        }

        private void Unregister()
        {
            Response.Write("<h1>You have unsubscribed from the newsletter</h1>");

        }

        private void Register()
        {
            Response.Write("<h1>Register Page</h1>");
            Response.Write("<p>...</p>");

        }
    }
}