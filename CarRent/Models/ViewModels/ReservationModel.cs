using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRent.Models.ViewModels
{
    public class ReservationModel
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        //Company 

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyRate { get; set; }
        
        public DateTime AvailableFrom{ get; set; }
        public DateTime AvailableTo { get; set; }

        public int VehicleID { get; set; }
        public int UserID { get; set; }

        public int ReservationID { get; set; }

        public string PickUpLocation { get; set; }

        public string DropoffLocation { get; set; }
        public string ReservationStatus { get; set; }
        //Reservation

      
           // public IEnumerable<VehicleImages> VehicleImages { get; set; }
            public IEnumerable<Company> Companies { get; set; }
            public IEnumerable<Reservations> Reservations { get; set; }
    }
}



