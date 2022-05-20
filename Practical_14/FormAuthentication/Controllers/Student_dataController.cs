using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FormAuthentication;

namespace FormAuthentication.Controllers
{
    [Authorize]
    public class Student_dataController : Controller
    {
        private FormAuthenticationEntities db = new FormAuthenticationEntities();

        // GET: Student_data
        public ActionResult Index()
        {
            return View(db.Student_data.ToList());
        }

        // GET: Student_data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_data student_data = db.Student_data.Find(id);
            if (student_data == null)
            {
                return HttpNotFound();
            }
            return View(student_data);
        }

        // GET: Student_data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_data/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Department,Enrollment_No_")] Student_data student_data)
        {
            if (ModelState.IsValid)
            {
                db.Student_data.Add(student_data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_data);
        }

        // GET: Student_data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_data student_data = db.Student_data.Find(id);
            if (student_data == null)
            {
                return HttpNotFound();
            }
            return View(student_data);
        }

        // POST: Student_data/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Department,Enrollment_No_")] Student_data student_data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_data);
        }

        // GET: Student_data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_data student_data = db.Student_data.Find(id);
            if (student_data == null)
            {
                return HttpNotFound();
            }
            return View(student_data);
        }

        // POST: Student_data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_data student_data = db.Student_data.Find(id);
            db.Student_data.Remove(student_data);
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
