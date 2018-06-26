using CharityBounce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharityBounce.Controllers
{
    public class TeamMembersController : Controller
    {

        CharityContext db = new CharityContext();


        // GET: TeamMembers
        public ActionResult Index()
        {
            var members = db.Members.ToList(); // Select * from TeamMembers

            return View(members);
        }

        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(TeamMember member)
        {
            if (!ModelState.IsValid)
            {
                return View(member);
            }

            //This is the happy path
            member.Registered = DateTime.Today;

            db.Members.Add(member);
            db.SaveChanges();

            // ViewBag was fin when we were returning a ViewResult
            //ViewBag.message = $"{member.Name} has Signed up!";

            // TempData - Lasts until it is read (piggybacks on session)
            TempData["message"] = $"{member.Name} has Signed up!";


            return RedirectToAction("Index");
        }



        protected override void Dispose(bool disposing)
        {
            if (db != null) db.Dispose();

            base.Dispose(disposing);
        }
    }
}