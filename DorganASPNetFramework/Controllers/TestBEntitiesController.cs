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
    public class TestBEntitiesController : Controller
    {
        private dorgandbEntities db = new dorgandbEntities();

        // GET: TestBEntities
        public ActionResult Index()
        {
            return View(db.TestBEntities.ToList());
        }

        // GET: TestBEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestBEntity testBEntity = db.TestBEntities.Find(id);
            if (testBEntity == null)
            {
                return HttpNotFound();
            }
            return View(testBEntity);
        }

        // GET: TestBEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestBEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] TestBEntity testBEntity)
        {
            if (ModelState.IsValid)
            {
                db.TestBEntities.Add(testBEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testBEntity);
        }

        // GET: TestBEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestBEntity testBEntity = db.TestBEntities.Find(id);
            if (testBEntity == null)
            {
                return HttpNotFound();
            }
            return View(testBEntity);
        }

        // POST: TestBEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] TestBEntity testBEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testBEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testBEntity);
        }

        // GET: TestBEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestBEntity testBEntity = db.TestBEntities.Find(id);
            if (testBEntity == null)
            {
                return HttpNotFound();
            }
            return View(testBEntity);
        }

        // POST: TestBEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestBEntity testBEntity = db.TestBEntities.Find(id);
            db.TestBEntities.Remove(testBEntity);
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
