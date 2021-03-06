//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class HMS_Outlet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HMS_Outlet()
        {
            this.HMS_AdvanceControl = new HashSet<HMS_AdvanceControl>();
            this.HMS_TaxControl = new HashSet<HMS_TaxControl>();
        }
    
        public int Id { get; set; }
        public string OutletName { get; set; }
        public int GRCNo { get; set; }
        public int ControlId { get; set; }
        public string Address { get; set; }
        public string AlternateAddress { get; set; }
        public string MobileNo { get; set; }
        public string AlternateMobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string AlternatePhoneNo { get; set; }
        public string EmailId { get; set; }
        public string AlternateEmailId { get; set; }
        public int GraceHours { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HMS_AdvanceControl> HMS_AdvanceControl { get; set; }
        public virtual HMS_Control HMS_Control { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HMS_TaxControl> HMS_TaxControl { get; set; }
    }
}
