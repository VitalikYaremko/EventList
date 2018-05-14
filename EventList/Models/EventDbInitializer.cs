using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventList.Models
{
    public class EventDbInitializer : CreateDatabaseIfNotExists<EventContext>
    {
        protected override void Seed(EventContext db)
        {
            base.Seed(db);
        }
    }
}