﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicDatabaseEntities3 : DbContext
    {
        public ClinicDatabaseEntities3()
            : base("name=ClinicDatabaseEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment__> Appointment__ { get; set; }
        public virtual DbSet<DoctorsAdvice> DoctorsAdvices { get; set; }
        public virtual DbSet<DoctorsPrescription> DoctorsPrescriptions { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugRequest> DrugRequests { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Physician> Physicians { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
