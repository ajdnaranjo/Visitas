﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Visits.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Common;
    using System.Data.Entity.Core.EntityClient;
    using System.Configuration;

    public partial class VisitsDatabaseEntities : DbContext
    {
        public VisitsDatabaseEntities() : base(GetSqlConnection(), true)
        {
        }


        public static DbConnection GetSqlConnection()
        {
            // Initialize the EntityConnectionStringBuilder. 
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            var connectionSettings = ConfigurationManager.ConnectionStrings["VisitsDatabaseEntities"];

            // Set the provider name. 
            entityBuilder.Provider = connectionSettings.ProviderName;

            // Set the provider-specific connection string. 
            entityBuilder.ProviderConnectionString = connectionSettings.ConnectionString;

            // Set the Metadata location. 
            entityBuilder.Metadata = "res://*/MVisits.csdl|res://*/MVisits.ssdl|res://*/MVisits.msl";
           
            return new EntityConnection(entityBuilder.ToString());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
    }
}
