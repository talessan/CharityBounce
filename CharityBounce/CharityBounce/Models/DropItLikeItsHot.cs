using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CharityBounce.Models
{
    public class DropItLikeItsHot : DropCreateDatabaseAlways<CharityContext>
    {

        //Override the Seed method
        protected override void Seed(CharityContext context)
        {
            var t1 = new TeamMember { Registered = DateTime.Today, Name = "Heather C", CharityPage = "https://example.com/hc", Token = "heatherc" };
            var t2 = new TeamMember { Registered = DateTime.Today, Name = "Heather A", CharityPage = "https://example.com/ha", Token = "heathera" };
            var t3 = new TeamMember { Registered = DateTime.Today, Name = "Heather B", CharityPage = "https://example.com/hb", Token = "heatherb" };
            var t4 = new TeamMember { Registered = DateTime.Today, Name = "Donald Trump", CharityPage = "https://example.com/trump", Token = "TheDonald" };
            var t5 = new TeamMember { Registered = DateTime.Today, Name = "Tom Hanks", CharityPage = "https://example.com/tom", Token = "hanks" };
            var t6 = new TeamMember { Registered = DateTime.Today, Name = "Bill Gates", CharityPage = "https://example.com/gate", Token = "billyg" };
            var t7 = new TeamMember { Registered = DateTime.Today, Name = "Colonel Sanders", CharityPage = "https://example.com/sanders", Token = "TheColonel" };
            var t8 = new TeamMember { Registered = DateTime.Today, Name = "Oprah", CharityPage = "https://example.com/harpo", Token = "oprah" };

            context.Members.Add(t1);
            context.Members.Add(t2);
            context.Members.Add(t3);
            context.Members.Add(t4);
            context.Members.Add(t5);
            context.Members.Add(t6);
            context.Members.Add(t7);
            context.Members.Add(t8);

            context.SaveChanges();


            base.Seed(context);
        }


    }
}