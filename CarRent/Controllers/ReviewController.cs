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
                var vehicleReviews = (from review in context.VehicleReviews join user
                                      in context.Users on review.UserID equals user.UserID
                                      join vehicle in context.Vehicles on review.VehicleID equals 
                                      vehicle.VehicleID
                                      join company in context.Company on vehicle.CompanyID equals company.CompanyID
                                      select new Review
                                      {
                                          VehicleID = (int)review.VehicleID,
                                          UserID = (int)review.UserID,
                                          ReviewDate = (DateTime)review.ReviewDate,
                                          ReviewText = (string)review.ReviewText,
                                          Username = user.Username,
                                          Brand = vehicle.Brand,
                                          Model = vehicle.Model,
                                          CompanyName = company.CompanyName
                                      }).ToList();

                return View(vehicleReviews);
            }
        }
    }
}


//public ActionResult Index()
//{
//    using (var context = new rentalEntities1())
//    {
//        var vehicleReviews = context.VehicleReviews
//            .Join(context.Users,
//            review => review.UserID,
//            user => user.UserID,
//            (review, user) => new Review
//            {
//                VehicleID = (int)review.VehicleID,
//                UserID = (int)review.UserID,
//                ReviewDate = (DateTime)review.ReviewDate,
//                ReviewText = review.ReviewText,
//                Username = user.Username
//            }).ToList();

//        return View(vehicleReviews);
//    }
//}