using Event.Models;
using System.Data.Entity;
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