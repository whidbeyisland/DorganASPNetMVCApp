﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DorganASPNetFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dorgandbEntities : DbContext
    {
        public dorgandbEntities()
            : base("name=dorgandbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<PartType> PartTypes { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TestEntity> TestEntities { get; set; }
        public virtual DbSet<TestBEntity> TestBEntities { get; set; }
        public virtual DbSet<TestCEntity> TestCEntities { get; set; }
    }
}
