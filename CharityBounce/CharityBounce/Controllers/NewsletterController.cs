using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharityBounce.Controllers
{
    public class NewsletterController : Controller //This is normal
    {
        [HttpGet]
        public ViewResult Register() //ViewResult is not completely normal, but better than void
        {
            var result = new ViewResult();
            result.ViewName = "Register";
            return result;
        }

        [HttpPost]
        public void Register(string name, string email)
        {
            string message2 = string.Format("{0} has been registered at {1} on {2:d}", name, email, DateTime.Now);

            string message = $"{name} has been registered at {email} on {DateTime.Now:d}"; //String interpolation

            Response.Write(message);
        }
    }
}