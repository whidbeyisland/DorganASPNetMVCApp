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
    public class TestCEntitiesController : Controller
    {
        private dorgandbEntities db = new dorgandbEntities();

        // GET: TestCEntities
        public ActionResult Index()
        {
            var testCEntities = db.TestCEntities.Include(t => t.TestBEntity);
            return View(testCEntities.ToList());
        }

        // GET: TestCEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestCEntity testCEntity = db.TestCEntities.Find(id);
            if (testCEntity == null)
            {
                return HttpNotFound();
            }
            return View(testCEntity);
        }

        // GET: TestCEntities/Create
        public ActionResult Create()
        {
            ViewBag.TestBEntityId = new SelectList(db.TestBEntities, "Id", "Name");
            return View();
        }

        // POST: TestCEntities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TestBEntityId,Name")] TestCEntity testCEntity)
        {
            if (ModelState.IsValid)
            {
                db.TestCEntities.Add(testCEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TestBEntityId = new SelectList(db.TestBEntities, "Id", "Name", testCEntity.TestBEntityId);
            return View(testCEntity);
        }

        // GET: TestCEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestCEntity testCEntity = db.TestCEntities.Find(id);
            if (testCEntity == null)
            {
                return HttpNotFound();
            }
            ViewBag.TestBEntityId = new SelectList(db.TestBEntities, "Id", "Name", testCEntity.TestBEntityId);
            return View(testCEntity);
        }

        // POST: TestCEntities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TestBEntityId,Name")] TestCEntity testCEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testCEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TestBEntityId = new SelectList(db.TestBEntities, "Id", "Name", testCEntity.TestBEntityId);
            return View(testCEntity);
        }

        // GET: TestCEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestCEntity testCEntity = db.TestCEntities.Find(id);
            if (testCEntity == null)
            {
                return HttpNotFound();
            }
            return View(testCEntity);
        }

        // POST: TestCEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestCEntity testCEntity = db.TestCEntities.Find(id);
            db.TestCEntities.Remove(testCEntity);
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
