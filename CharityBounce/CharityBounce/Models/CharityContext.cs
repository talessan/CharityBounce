using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CharityBounce.Models
{
    public class CharityContext : DbContext
    {

        public DbSet<TeamMember> Members { get; set; }
        //Add any other "tables" that you might need
        // In the database?  Where?
    }
}