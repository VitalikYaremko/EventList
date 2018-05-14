using EventList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 

namespace EventList.Controllers
{
    public class HomeController : Controller
    {
        EventContext db = new EventContext();
        public ActionResult Event()
        {
            IEnumerable<EventModel> events = db.Events;
            ViewBag.Events = events;
            return View();
        }

        public ActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Event(EventModel model)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(new EventModel { Type = model.Type, Name = model.Name, Details = model.Details, IsViewed = false, CreatedBy = model.CreatedBy, CreatedOn =  DateTime.Now.ToString() });
                db.SaveChanges();
            }
            return RedirectToAction("Event","Home");
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            EventModel e = db.Events.Find(Id);
            if (e != null)
            {
                db.Events.Remove(e);
                db.SaveChanges();
            }
            return RedirectToAction("Event", "Home");
        }

        [HttpGet]
        public ActionResult EditEvent(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            EventModel e = db.Events.Find(id);
 
            if (e == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("IsViewed","Home");
        }
        [HttpPost]
        public ActionResult IsViewed(EventModel model)
        {
  
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Event", "Home");
        }
    }
}