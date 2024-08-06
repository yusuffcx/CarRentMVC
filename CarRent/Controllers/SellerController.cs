using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarRent.Models;

namespace CarRent.Controllers
{
    public class SellerController : Controller
    {

        //        int x = Convert.ToInt32(Session["UserId"]);
        //int sId = Convert.ToInt32(Session["RoleID"]);
        //if (sId == 2)
        //{
        //    using (var context = new rentalEntities1())
        //    {
        //        var reservation = context.Vehicles
        //            .Where(v => v.VehicleID == Id)
        //            .Select(v => new ReservationModel
        //            {
        //                VehicleID = v.VehicleID,
        //                UserID = sId,
        //                Brand = v.Brand,
        //                Model = v.Model,
        //                DailyRate = (int)v.DailyRate,
        //                Year = (int)v.Year,
        //                AvailableFrom = (DateTime)v.AvailableFrom,
        //                AvailableTo = (DateTime)v.AvailableTo
        //            }).ToList();

        //        int userId = x;
        //        string username = (string)Session["Username"];
        //        ViewBag.UserID = userId;
        //        ViewBag.Username = username;
        //        return View(reservation);
        //    }
        //}


        private rentalEntities1 db = new rentalEntities1();

        // GET: Vehicles
        public ActionResult Index()
        {
            int x = Convert.ToInt32(Session["UserId"]);
            int sId = Convert.ToInt32(Session["RoleID"]);
            var vehicles = db.Vehicles.Include(v => v.Company);
            if(x == 4)
            {
                return View(vehicles.Where(v => v.CompanyID == 1).ToList());
            }
            else if(x == 5)
            {
                ;
                return View(vehicles.Where(v => v.CompanyID == 2));
            }

            else if(sId == 1)
            {
                return View(vehicles.ToList());
            }
            else
            {
                return RedirectToAction("notAllowed");
            }
        }

        public ActionResult notAllowed()
        {
            return View();
        }

        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicles vehicles = db.Vehicles.Find(id);
            if (vehicles == null)
            {
                return HttpNotFound();
            }
            return View(vehicles);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            ViewBag.CompanyID = new SelectList(db.Company, "CompanyID", "CompanyName");
            return View();
        }

        // POST: Vehicles/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VehicleID,CompanyID,Brand,Model,Color,Year,DailyRate,LicensePlate,AvailableFrom,AvailableTo,FuelType,TransmissionType,MileAge")] Vehicles vehicles)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyID = new SelectList(db.Company, "CompanyID", "CompanyName", vehicles.CompanyID);
            return View(vehicles);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicles vehicles = db.Vehicles.Find(id);
            if (vehicles == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyID = new SelectList(db.Company, "CompanyID", "CompanyName", vehicles.CompanyID);
            return View(vehicles);
        }

        // POST: Vehicles/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VehicleID,CompanyID,Brand,Model,Color,Year,DailyRate,LicensePlate,AvailableFrom,AvailableTo,FuelType,TransmissionType,MileAge")] Vehicles vehicles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyID = new SelectList(db.Company, "CompanyID", "CompanyName", vehicles.CompanyID);
            return View(vehicles);
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicles vehicles = db.Vehicles.Find(id);
            if (vehicles == null)
            {
                return HttpNotFound();
            }
            return View(vehicles);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicles vehicles = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicles);
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
