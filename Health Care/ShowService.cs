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
    
    public partial class ShowService
    {
        public int ServiceID { get; set; }
        public string Service_Name { get; set; }
        public decimal Service_Price { get; set; }
        public Nullable<int> RelatedServiceID { get; set; }
        public string Related_Service_Name { get; set; }
        public Nullable<decimal> Related_Service_Price { get; set; }
    }
}