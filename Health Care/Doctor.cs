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
    
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            this.Doctor_Clinic_Shifts = new HashSet<Doctor_Clinic_Shifts>();
            this.Doctor_Services = new HashSet<Doctor_Services>();
        }
    
        public int DoctorID { get; set; }
        public string Specialization { get; set; }
        public int EmployeeID { get; set; }
        public string LoginID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor_Clinic_Shifts> Doctor_Clinic_Shifts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor_Services> Doctor_Services { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual UserLogin UserLogin { get; set; }
    }
}