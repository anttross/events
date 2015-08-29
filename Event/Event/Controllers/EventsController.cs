using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Event.Models;
using Event.DAL;

namespace Event.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        private EventContext db = new EventContext();

        // GET: /Events/
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            return View(user.EventsList); 
        }

        // GET: /Events/Details/5
        public ActionResult Details(int? id)
         {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Events events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        // GET: /Events/Create
        public ActionResult Create()
        {
            var model = new EventCreateViewModel();

            return View(model);
        }

        // POST: /Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.Other))
                    model.EventItem.Event = model.Other;
                var user = db.Users.Find(User.Identity.GetUserId());
                user.EventsList.Add(model.EventItem);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: /Events/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Events");//new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Events events = db.Events.Find(id);
            if (events == null)
            {
                return RedirectToAction("Index", "Events");//HttpNotFound();
            }
            var model = new EventCreateViewModel();
            model.EventItem = events;
            if (model.Subjects.Find(x => x.Text.Equals(model.EventItem.Event)) == null)
            {
                model.Other = model.EventItem.Event;
                model.EventItem.Event = "אחר";
            }
            return View(model);
        }

        // POST: /Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EventCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(model.Other))
                    model.EventItem.Event = model.Other;
                db.Entry(model.EventItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: /Events/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Events events = db.Events.Find(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }

        // POST: /Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Events events = db.Events.Find(id);
            db.Events.Remove(events);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
