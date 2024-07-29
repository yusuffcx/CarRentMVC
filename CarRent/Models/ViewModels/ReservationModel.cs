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

        public int VehicleID { get; set; }
        public int ImageID { get; set; }
        public string ImagePath { get; set; }
        //Images
        public int UserID { get; set; }

        public int ReservationID { get; set; }

        public string PickUpLocation { get; set; }

        public string DropoffLocation { get; set; }
        public string ReservationStatus { get; set; }
        //Reservation

      
            public IEnumerable<VehicleImages> VehicleImages { get; set; }
            public IEnumerable<Company> Companies { get; set; }
            public IEnumerable<Reservations> Reservations { get; set; }
        



    }
}



