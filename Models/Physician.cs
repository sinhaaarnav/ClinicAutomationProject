//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicAutomationProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Physician
    {
        public int PhysicianId { get; set; }
        public string FirstName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Specialization { get; set; }
        public string Gender { get; set; }
        public Nullable<int> ContactNo { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string DoctorsDesc { get; set; }
        public string LastName { get; set; }
    }
}
