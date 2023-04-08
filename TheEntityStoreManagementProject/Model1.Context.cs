﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheEntityStoreManagementProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InventoryEntities : DbContext
    {
        public InventoryEntities()
            : base("name=InventoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<ExchangePermit> ExchangePermits { get; set; }
        public virtual DbSet<ImportPermit> ImportPermits { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransferItem> TransferItems { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }
    
        public virtual ObjectResult<ForItem_Result> ForItem()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ForItem_Result>("ForItem");
        }
    
        public virtual ObjectResult<ForStore_Result> ForStore()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ForStore_Result>("ForStore");
        }
    
        public virtual ObjectResult<ListExport_Result> ListExport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListExport_Result>("ListExport");
        }
    
        public virtual ObjectResult<ListImport_Result> ListImport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListImport_Result>("ListImport");
        }
    }
}
