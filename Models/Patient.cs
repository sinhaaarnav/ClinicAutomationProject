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
    
    public partial class Patient
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public Nullable<int> ContactNo { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string MedicalHistory { get; set; }
    }
}
