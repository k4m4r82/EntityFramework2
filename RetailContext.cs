using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using EntityFramework2.Models;
using EntityFramework2.Mapping;

namespace EntityFramework2
{
    public class RetailContext : DbContext
    {
        static RetailContext()
        {
            // menonaktifkan inisialisasi database
            // karena kita menggunakan database yang sudah ada
            Database.SetInitializer<RetailContext>(null);
        }

        public RetailContext()
            : base("Name=RetailContext")
        {

        }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // mendaftarkan konfigurasi mapping via Code First’s Fluent API
            modelBuilder.Configurations.Add(new SupplierMap());
        }
    }
}
