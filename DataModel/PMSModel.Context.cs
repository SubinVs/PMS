﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PMSEntities : DbContext
    {
        public PMSEntities()
            : base("name=PMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HMS_AdvanceControl> HMS_AdvanceControl { get; set; }
        public virtual DbSet<HMS_Agent> HMS_Agent { get; set; }
        public virtual DbSet<HMS_CheckIn> HMS_CheckIn { get; set; }
        public virtual DbSet<HMS_City> HMS_City { get; set; }
        public virtual DbSet<HMS_Company> HMS_Company { get; set; }
        public virtual DbSet<HMS_Control> HMS_Control { get; set; }
        public virtual DbSet<HMS_Country> HMS_Country { get; set; }
        public virtual DbSet<HMS_Floor> HMS_Floor { get; set; }
        public virtual DbSet<HMS_Guest> HMS_Guest { get; set; }
        public virtual DbSet<HMS_Outlet> HMS_Outlet { get; set; }
        public virtual DbSet<HMS_Plan> HMS_Plan { get; set; }
        public virtual DbSet<HMS_Purpose> HMS_Purpose { get; set; }
        public virtual DbSet<HMS_Rate> HMS_Rate { get; set; }
        public virtual DbSet<HMS_Room> HMS_Room { get; set; }
        public virtual DbSet<HMS_RoomType> HMS_RoomType { get; set; }
        public virtual DbSet<HMS_State> HMS_State { get; set; }
        public virtual DbSet<HMS_TaxControl> HMS_TaxControl { get; set; }
        public virtual DbSet<Prefix> Prefixes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
    }
}
