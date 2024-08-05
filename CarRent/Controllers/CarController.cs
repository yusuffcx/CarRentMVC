using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRent.Models;
using CarRent.Models.ViewModels;
using System.Data.Entity;



namespace CarRent.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index(int id = 0)
        {
            using (var context = new rentalEntities1())
            {
                var vehicleImagesWithDetails = context.VehicleImages
                .Select(vi => new VehicleDetail
                {
                    ImagePath = vi.ImagePath,
                    VehicleID = (int)vi.VehicleID,
                    Model = vi.Vehicles.Model,
                    Brand = vi.Vehicles.Brand,
                    TransmissionType = vi.Vehicles.TransmissionType,
                    FuelType = vi.Vehicles.FuelType,
                    Year = (int)vi.Vehicles.Year
                }).ToList();

                return View(vehicleImagesWithDetails);
            }
        }
        public ActionResult CarDetails(int Id)
        {
            using (var context = new rentalEntities1())
            {

                IEnumerable<VehicleDetail> vehicleDetails = context.VehicleImages
                          .Where(vi => vi.VehicleID == Id)
                          .Select(vi => new VehicleDetail
                          {
                              ImagePath = vi.ImagePath,
                              VehicleID = (int)vi.VehicleID,
                              Model = vi.Vehicles.Model,
                              Brand = vi.Vehicles.Brand,
                              TransmissionType = vi.Vehicles.TransmissionType,
                              FuelType = vi.Vehicles.FuelType,
                              Year = (int)vi.Vehicles.Year,
                              MileAge = (int)vi.Vehicles.MileAge,
                              Color = vi.Vehicles.Color,
                              DailyRate = (decimal)vi.Vehicles.DailyRate,
                              CompanyName = vi.Vehicles.Company.CompanyName,
                              LicensePlate = vi.Vehicles.LicensePlate,
                          }).ToList();

                return View(vehicleDetails);
            }
        }

        public ActionResult Rezervation(int Id)
        {
            int x = Convert.ToInt32(Session["UserId"]);
            int sId = Convert.ToInt32(Session["RoleID"]);
            if (sId == 2)
            {
                using (var context = new rentalEntities1())
                {
                    var reservation = context.Vehicles
                        .Where(v => v.VehicleID == Id)
                        .Select(v => new ReservationModel
                        {
                            VehicleID = v.VehicleID,
                            UserID = sId,
                            Brand = v.Brand,
                            Model = v.Model,
                            DailyRate = (int)v.DailyRate,
                            Year = (int)v.Year,
                            AvailableFrom = (DateTime)v.AvailableFrom,
                            AvailableTo = (DateTime)v.AvailableTo
                        }).ToList();

                    int userId = x;
                    string username = (string)Session["Username"];
                    ViewBag.UserID = userId;
                    ViewBag.Username = username;
                    return View(reservation);
                }
            }

            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult VehicleFeatures(int Id)
        {
          using (var context = new rentalEntities1())
          {
                   List<VehicleDetail>vehicleDetails = (from vi in context.VehicleImages
                              join v in context.VehicleFeaturesDetails on vi.VehicleID equals v.VehicleID
                              where vi.VehicleID == Id
                              select new VehicleDetail
                              {
                                  ImagePath = vi.ImagePath,
                                  VehicleID = (int)vi.VehicleID,
                                  Model = vi.Vehicles.Model,
                                  Brand = vi.Vehicles.Brand,
                                  detailDescription = v.detailDescription,
                              }).ToList();

                   return View(vehicleDetails);
          }
        }
    }
}


