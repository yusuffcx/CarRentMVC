using CarRent.Models.ViewModels;
using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRent.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Index()
        {
            using (var context = new rentalEntities1())
            {
                var vehicleReviews = context.VehicleReviews
                .Select(r => new Review
                {
                    VehicleID = (int)r.VehicleID,
                    UserID = (int)r.UserID,
                    ReviewDate = (DateTime)r.ReviewDate,
                    ReviewText = r.ReviewText,
                }).ToList();

                return View(vehicleReviews);
            }
        }
    }
}