using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventList.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public bool IsViewed { get; set; }
        public string CreatedBy { get; set; }//ким створений
        public string CreatedOn { get; set; } //коли створений
    }
}