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
    public class StaffPersonalInformationsController : Controller
    {
        private DataContext db = new DataContext("Server=tcp:unep.database.windows.net,1433;Initial Catalog=unep_test;Persist Security Info=False;User ID=smuwanguzi;Password=Password.01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        // GET: StaffPersonalInformations
        public async Task<ActionResult> Index()
        {
            return View(await db.StaffPersonalInformation.ToListAsync());
        }

        // GET: StaffPersonalInformations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffPersonalInformation staffPersonalInformation = await db.StaffPersonalInformation.FindAsync(id);
            if (staffPersonalInformation == null)
            {
                return HttpNotFound();
            }
            return View(staffPersonalInformation);
        }

        // GET: StaffPersonalInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StaffPersonalInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IndexNumber,FullNames,Email,CurrentLocation,HighestLevelOfEducation,DutyStation,AvailabilityForRemoteWork")] StaffPersonalInformation staffPersonalInformation)
        {
            if (ModelState.IsValid)
            {
                db.StaffPersonalInformation.Add(staffPersonalInformation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(staffPersonalInformation);
        }

        // GET: StaffPersonalInformations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffPersonalInformation staffPersonalInformation = await db.StaffPersonalInformation.FindAsync(id);
            if (staffPersonalInformation == null)
            {
                return HttpNotFound();
            }
            return View(staffPersonalInformation);
        }

        // POST: StaffPersonalInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IndexNumber,FullNames,Email,CurrentLocation,HighestLevelOfEducation,DutyStation,AvailabilityForRemoteWork")] StaffPersonalInformation staffPersonalInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staffPersonalInformation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(staffPersonalInformation);
        }

        // GET: StaffPersonalInformations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StaffPersonalInformation staffPersonalInformation = await db.StaffPersonalInformation.FindAsync(id);
            if (staffPersonalInformation == null)
            {
                return HttpNotFound();
            }
            return View(staffPersonalInformation);
        }

        // POST: StaffPersonalInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StaffPersonalInformation staffPersonalInformation = await db.StaffPersonalInformation.FindAsync(id);
            db.StaffPersonalInformation.Remove(staffPersonalInformation);
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
