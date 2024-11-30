using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IoT_Solution_Web_Application.Models;

namespace IoT_Solution_Web_Application.Controllers
{
    public class TemperatureDataTableController : Controller
    {
        private TemperatureDataRasPiEntities db = new TemperatureDataRasPiEntities();

        // GET: TemperatureDataTable
        public ActionResult Index()
        {
            return View(db.TemperatureDataTables.ToList());
        }

        // GET: TemperatureDataTable/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TemperatureDataTable temperatureDataTable = db.TemperatureDataTables.Find(id);
            if (temperatureDataTable == null)
            {
                return HttpNotFound();
            }
            return View(temperatureDataTable);
        }

        // GET: TemperatureDataTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TemperatureDataTable/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Environment,SetPoint,Output,Voltage,Time")] TemperatureDataTable temperatureDataTable)
        {
            if (ModelState.IsValid)
            {
                db.TemperatureDataTables.Add(temperatureDataTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(temperatureDataTable);
        }

        // GET: TemperatureDataTable/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TemperatureDataTable temperatureDataTable = db.TemperatureDataTables.Find(id);
            if (temperatureDataTable == null)
            {
                return HttpNotFound();
            }
            return View(temperatureDataTable);
        }

        // POST: TemperatureDataTable/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Environment,SetPoint,Output,Voltage,Time")] TemperatureDataTable temperatureDataTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(temperatureDataTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(temperatureDataTable);
        }

        // GET: TemperatureDataTable/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TemperatureDataTable temperatureDataTable = db.TemperatureDataTables.Find(id);
            if (temperatureDataTable == null)
            {
                return HttpNotFound();
            }
            return View(temperatureDataTable);
        }

        // POST: TemperatureDataTable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TemperatureDataTable temperatureDataTable = db.TemperatureDataTables.Find(id);
            db.TemperatureDataTables.Remove(temperatureDataTable);
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
