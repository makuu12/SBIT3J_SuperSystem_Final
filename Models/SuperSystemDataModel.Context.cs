﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBIT3J_SuperSystem_Final.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseEntitiesConnection : DbContext
    {
        public DatabaseEntitiesConnection()
            : base("name=DatabaseEntitiesConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
        public virtual DbSet<EmployeeInformation> EmployeeInformations { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<Loss_Damages> Loss_Damages { get; set; }
        public virtual DbSet<Loss_Fraud> Loss_Fraud { get; set; }
        public virtual DbSet<Other_Services> Other_Services { get; set; }
        public virtual DbSet<Product_Info> Product_Info { get; set; }
        public virtual DbSet<Sales_Transaction> Sales_Transaction { get; set; }
        public virtual DbSet<Sales_Transaction_Details> Sales_Transaction_Details { get; set; }
    }
}
