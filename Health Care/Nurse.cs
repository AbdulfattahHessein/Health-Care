//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthCare
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nurse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nurse()
        {
            this.Nurse_Clinic_Shifts = new HashSet<Nurse_Clinic_Shifts>();
        }
    
        public int NurseID { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nurse_Clinic_Shifts> Nurse_Clinic_Shifts { get; set; }
    }
}
