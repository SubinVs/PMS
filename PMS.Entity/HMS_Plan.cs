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
    
    public partial class HMS_Plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HMS_Plan()
        {
            this.HMS_CheckIn = new HashSet<HMS_CheckIn>();
        }
    
        public int Id { get; set; }
        public string PlanType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HMS_CheckIn> HMS_CheckIn { get; set; }
    }
}
