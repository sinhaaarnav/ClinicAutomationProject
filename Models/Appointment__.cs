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
    
    public partial class Appointment__
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public Nullable<System.DateTime> AppointmentDate { get; set; }
        public string Criticality { get; set; }
        public string AppointmentReason { get; set; }
        public string AppointmentStatus { get; set; }
    }
}