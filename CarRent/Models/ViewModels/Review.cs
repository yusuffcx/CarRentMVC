using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRent.Models.ViewModels
{
    public class Review
    {
        public int VehicleID { get; set; }
        public int ReviewID { get; set; }

        public int UserID { get; set; }

        public DateTime ReviewDate { get; set; }

        public string ReviewText { get; set; }

        public string Username { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string CompanyName { get; set; }

    }
}