using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventList.Models
{
    public class EventContext : DbContext
    {
        public DbSet<EventModel> Events { get; set; }
    }
}