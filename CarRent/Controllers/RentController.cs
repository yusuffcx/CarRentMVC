using CarRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarRent.Controllers
{
    public class rentController : Controller
    {
        private readonly rentalEntities1 _context;

        public rentController(rentalEntities1 context)
        {
            _context = context;
        }

        [HttpPost]
        public void AddRent(int userID, string startDate, string endDate,int vehicleID)
        {
            DateTime start = DateTime.ParseExact(startDate, "dd.MM.yyyy", null);
            DateTime end = DateTime.ParseExact(endDate, "dd.MM.yyyy", null);

            Rentals newRental = new Rentals
                {
                    UserID = userID,
                    RentalDate = start,
                    ReturnDate = end,
                    VehicleID = vehicleID,
                    Status = "Kiralandı"
                };
                _context.Rentals.Add(newRental);
                _context.SaveChanges();
        }
    }

}






