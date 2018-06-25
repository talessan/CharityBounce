using CharityBounce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharityBounce.Controllers
{
    public class DemoController : Controller
    {

        public ActionResult Show()
        {
            var db = new CharityContext();
            //LINQ - Language INtegrated Query
            var members = from m in db.Members
                          orderby m.Name
                          select m;

            return View("Show", members.ToList());

        }


        public ActionResult Test()
        {
            var db = new CharityContext();

            var t1 = new TeamMember {Registered=DateTime.Today, Name = "Heather C", CharityPage = "https://example.com/hc", Token="heatherc" };
            var t2 = new TeamMember {Registered=DateTime.Today, Name = "Heather A", CharityPage = "https://example.com/ha", Token="heathera" };
            var t3 = new TeamMember {Registered=DateTime.Today, Name = "Heather B", CharityPage = "https://example.com/hb", Token="heatherb" };
            var t4 = new TeamMember {Registered=DateTime.Today, Name = "Donald Trump", CharityPage = "https://example.com/trump", Token="TheDonald" };
            var t5 = new TeamMember {Registered=DateTime.Today, Name = "Tom Hanks", CharityPage = "https://example.com/tom", Token="hanks" };
            var t6 = new TeamMember {Registered=DateTime.Today, Name = "Bill Gates", CharityPage = "https://example.com/gate", Token="billyg" };
            var t7 = new TeamMember {Registered=DateTime.Today, Name = "Colonel Sanders", CharityPage = "https://example.com/sanders", Token="TheColonel" };
            var t8 = new TeamMember {Registered=DateTime.Today, Name = "Oprah", CharityPage = "https://example.com/harpo", Token="oprah" };

            db.Members.Add(t1);
            db.Members.Add(t2);
            db.Members.Add(t3);
            db.Members.Add(t4);
            db.Members.Add(t5);
            db.Members.Add(t6);
            db.Members.Add(t7);
            db.Members.Add(t8);

            db.SaveChanges();

            return View("Test");
        }

    }
}