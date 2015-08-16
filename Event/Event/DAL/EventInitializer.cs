using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Event.Models;

namespace Event.DAL
{
    public class EventInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var events = new List<Events>
            {
            new Events{ID=1,UserID=11,Event="Birthday",Date=DateTime.Parse("2005-09-01")},
            new Events{ID=2,UserID=11,Event="Wedding",Date=DateTime.Parse("2025-09-01")},
            new Events{ID=3,UserID=12,Event="Funeral",Date=DateTime.Parse("2075-09-01")}
            };

            var users = new List<Users>
            {
            new Users{ID=1,FirstName="Julius",LastName="Caesar",UserName="July",Password="Brute",Email="JollyJuly@parliament.roma",Birthday=DateTime.Parse("01/06/0100")},
            new Users{ID=1,FirstName="Marie",LastName="Antoinette",UserName="Mary",Password="Cake",Email="BloodyMary@head.off",Birthday=DateTime.Parse("02/09/1755")}
           };

        }
    }
}