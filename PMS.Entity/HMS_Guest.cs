//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class HMS_Guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HMS_Guest()
        {
            this.HMS_CheckIn = new HashSet<HMS_CheckIn>();
        }
    
        public int Id { get; set; }
        public int PrefixId { get; set; }
        public string GuestName { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int Pincode { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string ImagePath { get; set; }
        public string DocumentPath { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HMS_CheckIn> HMS_CheckIn { get; set; }
        public virtual HMS_City HMS_City { get; set; }
        public virtual HMS_Country HMS_Country { get; set; }
        public virtual Prefix Prefix { get; set; }
        public virtual HMS_State HMS_State { get; set; }
    }
}
