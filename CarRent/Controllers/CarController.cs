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
        public ActionResult Index()
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
                            }).ToList();

                return View(vehicleDetails);
            }
        }

        public ActionResult Rezervation(int Id)
        {
            using (var context = new rentalEntities1())
            {
                var vehicleImages = context.VehicleImages
                    .Where(vi => vi.VehicleID == Id)
                    .ToList();

                var companies = context.Company.ToList();

                var reservations = context.Reservations
                    .Where(r => r.VehicleID == Id)
                    .ToList();

                var viewModel = new ReservationModel
                {
                    VehicleImages = vehicleImages,
                    Companies = companies,
                    Reservations = reservations,
                    ImagePath = vehicleImages.ToArray()[0].ToString()
                };

                return View(viewModel);
            }


        }
    }
}


