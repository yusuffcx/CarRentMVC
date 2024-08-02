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
    using System.ComponentModel;

    public partial class Vehicles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicles()
        {
            this.Locations = new HashSet<Locations>();
            this.Rentals = new HashSet<Rentals>();
            this.Reservations = new HashSet<Reservations>();
            this.VehicleFeaturesDetails = new HashSet<VehicleFeaturesDetails>();
            this.VehicleImages = new HashSet<VehicleImages>();
            this.VehicleReviews = new HashSet<VehicleReviews>();
        }
    
        public int VehicleID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        [DisplayName("Marka")]
        public string Brand { get; set; }
        [DisplayName("Model")]

        public string Model { get; set; }
        [DisplayName("Renk")]

        public string Color { get; set; }
        [DisplayName("Model Y�l�")]

        public Nullable<int> Year { get; set; }
        [DisplayName("G�nl�k �cret")]

        public Nullable<decimal> DailyRate { get; set; }
        [DisplayName("Plaka")]

        public string LicensePlate { get; set; }
        [DisplayName("En Erken m�saitlik")]

        public Nullable<System.DateTime> AvailableFrom { get; set; }
        [DisplayName("En Ge� m�saitlik")]

        public Nullable<System.DateTime> AvailableTo { get; set; }
        [DisplayName("Yak�t")]
        public string FuelType { get; set; }
        [DisplayName("Vites")]

        public string TransmissionType { get; set; }
        [DisplayName("Kilometre")]

        public Nullable<int> MileAge { get; set; }
        [DisplayName("�irket Ad�")]

        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locations> Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rentals> Rentals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservations> Reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleFeaturesDetails> VehicleFeaturesDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleImages> VehicleImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleReviews> VehicleReviews { get; set; }
    }
}
