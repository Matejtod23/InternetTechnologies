using LAB1_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB1_A.Controllers
{
    public class EventController : Controller
    {

        private static List<Event> events = new List<Event>
        {
                new Event {Id = 1, ime = "SkpojeCalling", lokacija = "Skopje"},
                new Event {Id = 2, ime = "OhridCalling", lokacija = "Ohrid"}
        };
        // GET: Event
        public ActionResult DisplayEvents()
        {
            return View(events);
        }

        public ActionResult NewEvent()
        { 
            Event model = new Event();
            return View(model); 
        }

        [HttpPost]
        public ActionResult InsertNewEvent(Event model)
        {
            if (ModelState.IsValid == false)//vrakjame istoto view so istiot model nema da dozvoli da prodolzime ponatamu so nevaliden model
            {
                return View("NewEvent", model);
            }
            model.Id = events.Last().Id + 1;
            events.Add(model);
            return View("EventDetails", model);
        }

        public ActionResult EventDetails(Event model)
        {
            return View(model);
        }

        public ActionResult EditEvent(int id)
        {
            Event e = events.Where(s => s.Id == id).FirstOrDefault();
            return View(e);
        }
        [HttpPost]
        public ActionResult EditEvent(Event model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewEvemt", model);
            }
            var update = events.Where(s => s.Id == model.Id).FirstOrDefault();
            update.Id = model.Id;
            update.ime = model.ime; 
            update.lokacija = model.lokacija;
            return View("EventDetails", update);
        }

        public ActionResult DeleteEvent(int id)
        {
            var eventToDelete = events.Where(s => s.Id == id).FirstOrDefault();
            events.Remove(eventToDelete);
            foreach (var e in events)
            {
                e.Id -= 1;
            }
            return View("DisplayEvents", events);
        }
    }
}