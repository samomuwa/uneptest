using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UnepProject.Models;
using UnpeTest.Models;

namespace UnpeTest.Controllers
{
    public class StaffExamplesofProjectsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: StaffExamplesofProjects
        public async Task<ActionResult> Index()
        {
            return View(await db.StaffExamplesofProjects.ToListAsync());
        }

        // GET: StaffExamplesofProjects/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffExamplesofProjects staffExamplesofProjects = await db.StaffExamplesofProjects.FindAsync(id);
            if (staffExamplesofProjects == null)
            {
                return HttpNotFound();
            }
            return View(staffExamplesofProjects);
        }

        // GET: StaffExamplesofProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffExamplesofProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,ProjectTitleAndLocation,LevelofResponsibility,BriefDescriptionOfRole,IndexNumber_staff")] StaffExamplesofProjects staffExamplesofProjects)
        {
            if (ModelState.IsValid)
            {
                db.StaffExamplesofProjects.Add(staffExamplesofProjects);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(staffExamplesofProjects);
        }

        // GET: StaffExamplesofProjects/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffExamplesofProjects staffExamplesofProjects = await db.StaffExamplesofProjects.FindAsync(id);
            if (staffExamplesofProjects == null)
            {
                return HttpNotFound();
            }
            return View(staffExamplesofProjects);
        }

        // POST: StaffExamplesofProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,ProjectTitleAndLocation,LevelofResponsibility,BriefDescriptionOfRole,IndexNumber_staff")] StaffExamplesofProjects staffExamplesofProjects)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staffExamplesofProjects).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(staffExamplesofProjects);
        }

        // GET: StaffExamplesofProjects/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffExamplesofProjects staffExamplesofProjects = await db.StaffExamplesofProjects.FindAsync(id);
            if (staffExamplesofProjects == null)
            {
                return HttpNotFound();
            }
            return View(staffExamplesofProjects);
        }

        // POST: StaffExamplesofProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StaffExamplesofProjects staffExamplesofProjects = await db.StaffExamplesofProjects.FindAsync(id);
            db.StaffExamplesofProjects.Remove(staffExamplesofProjects);
            await db.SaveChangesAsync();
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
