using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Event.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Event.DAL
{
    public class EventContext : IdentityDbContext<ApplicationUser>
    {
        public EventContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Events> Events { get; set; }

    }
}