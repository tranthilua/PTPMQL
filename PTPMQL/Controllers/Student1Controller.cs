using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class Student1Controller : Controller
    {
        private DemoDbContext db = new DemoDbContext();

        // GET: Student1
        public ActionResult Index()
        {
            return View(db.Student1.ToList());
        }

        // GET: Student1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student1 student1 = db.Student1.Find(id);
            if (student1 == null)
            {
                return HttpNotFound();
            }
            return View(student1);
        }

        // GET: Student1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CCCD,Address,University,FullName")] Student1 student1)
        {
            if (ModelState.IsValid)
            {
                db.Student1.Add(student1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student1);
        }

        // GET: Student1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student1 student1 = db.Student1.Find(id);
            if (student1 == null)
            {
                return HttpNotFound();
            }
            return View(student1);
        }

        // POST: Student1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CCCD,Address,University,FullName")] Student1 student1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student1);
        }

        // GET: Student1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student1 student1 = db.Student1.Find(id);
            if (student1 == null)
            {
                return HttpNotFound();
            }
            return View(student1);
        }

        // POST: Student1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Student1 student1 = db.Student1.Find(id);
            db.Student1.Remove(student1);
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
