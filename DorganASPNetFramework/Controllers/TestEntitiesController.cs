using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DorganASPNetFramework;

namespace DorganASPNetFramework.Controllers
{
    public class TestEntitiesController : Controller
    {
        private dorgandbEntities db = new dorgandbEntities();

        // GET: TestEntities
        public ActionResult Index()
        {
            return View(db.TestEntities.ToList());
        }

        // GET: TestEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestEntity testEntity = db.TestEntities.Find(id);
            if (testEntity == null)
            {
                return HttpNotFound();
            }
            return View(testEntity);
        }

        // GET: TestEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] TestEntity testEntity)
        {
            if (ModelState.IsValid)
            {
                db.TestEntities.Add(testEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testEntity);
        }

        // GET: TestEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestEntity testEntity = db.TestEntities.Find(id);
            if (testEntity == null)
            {
                return HttpNotFound();
            }
            return View(testEntity);
        }

        // POST: TestEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] TestEntity testEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testEntity);
        }

        // GET: TestEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestEntity testEntity = db.TestEntities.Find(id);
            if (testEntity == null)
            {
                return HttpNotFound();
            }
            return View(testEntity);
        }

        // POST: TestEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestEntity testEntity = db.TestEntities.Find(id);
            db.TestEntities.Remove(testEntity);
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
