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
    
    public partial class Insurance
    {
        public int InsuranceID { get; set; }
        public Nullable<int> RentalID { get; set; }
        public string InsuranceType { get; set; }
        public Nullable<decimal> InsuranceCost { get; set; }
        public Nullable<System.DateTime> InsuranceStartDate { get; set; }
        public Nullable<System.DateTime> InsuranceFinishDate { get; set; }
        public string InsuranceStatus { get; set; }
    
        public virtual Rentals Rentals { get; set; }
    }
}
