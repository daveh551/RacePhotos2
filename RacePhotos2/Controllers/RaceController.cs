using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhotoServer.Domain;
using RacePhotos2.App_Architecture.Services.Data;
using Highway.Data;

namespace RacePhotos2.Controllers
{
    public class RaceController : Controller
    {
        public RaceController(IRepository repository)
        {

            repo = repository;
        }

        private IRepository repo;
        // GET: /Race/
        public ActionResult Index()
        {
            var races = repo.Execute()
                .Races.Include(r => r.Distance).Include(r => r.Event);
            return View(races.ToList());
        }

        // GET: /Race/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Race race = db.Races.Find(id);
            if (race == null)
            {
                return HttpNotFound();
            }
            return View(race);
        }

        // GET: /Race/Create
        public ActionResult Create()
        {
            ViewBag.DistanceId = new SelectList(db.Distances, "Id", "RaceDistance");
            ViewBag.EventId = new SelectList(db.Events, "Id", "EventName");
            return View();
        }

        // POST: /Race/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,EventId,DistanceId,ReferenceTime")] Race race)
        {
            if (ModelState.IsValid)
            {
                db.Races.Add(race);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DistanceId = new SelectList(db.Distances, "Id", "RaceDistance", race.DistanceId);
            ViewBag.EventId = new SelectList(db.Events, "Id", "EventName", race.EventId);
            return View(race);
        }

        // GET: /Race/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Race race = db.Races.Find(id);
            if (race == null)
            {
                return HttpNotFound();
            }
            ViewBag.DistanceId = new SelectList(db.Distances, "Id", "RaceDistance", race.DistanceId);
            ViewBag.EventId = new SelectList(db.Events, "Id", "EventName", race.EventId);
            return View(race);
        }

        // POST: /Race/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,EventId,DistanceId,ReferenceTime")] Race race)
        {
            if (ModelState.IsValid)
            {
                db.Entry(race).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DistanceId = new SelectList(db.Distances, "Id", "RaceDistance", race.DistanceId);
            ViewBag.EventId = new SelectList(db.Events, "Id", "EventName", race.EventId);
            return View(race);
        }

        // GET: /Race/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Race race = db.Races.Find(id);
            if (race == null)
            {
                return HttpNotFound();
            }
            return View(race);
        }

        // POST: /Race/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Race race = db.Races.Find(id);
            db.Races.Remove(race);
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
