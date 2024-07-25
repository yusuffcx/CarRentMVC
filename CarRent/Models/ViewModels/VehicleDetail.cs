using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CarRent.Models.ViewModels
{
    public class VehicleDetail
    {
        public int VehicleID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyRate { get; set; }
        public int ImageID { get; set; }
        public string ImagePath { get; set; }
        public string TransmissionType { get; set; }
        public string FuelType { get; set; }
        public int MileAge { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }
        public string LocationName { get; set; }
    }
}



