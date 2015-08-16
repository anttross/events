using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Event.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Event.DAL
{
    public class EventContext : DbContext
    {
        public EventContext()
            : base("DefaultConnection")
        {
        }
        
        public DbSet<Users> Users { get; set; }
        public DbSet<Events> Events { get; set; }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}