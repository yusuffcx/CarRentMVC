//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleImages
    {
        public int ImageID { get; set; }
        public Nullable<int> VehicleID { get; set; }
        public string ImagePath { get; set; }
    
        public virtual Vehicles Vehicles { get; set; }

        public virtual Locations Locations { get; set; }
    }
}
