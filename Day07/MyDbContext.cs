using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day07
{
    public class MyDbContext : DbContext
    {
        public DbSet<CoffeeBean> CoffeeBeans { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-NQ7JL3H ; Initial Catalog = CoffeSystem; Integrated Security = True; Encrypt = False;").EnableDetailedErrors(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeBean>().HasData(

                new CoffeeBean { Id = 1, Name = "caf1", OriginCountry = "cou1", RoastLevel = 2, PricePerKg = 30.03m, SupplierID = 1 },
                new CoffeeBean { Id = 2, Name = "caf2", OriginCountry = "cou2", RoastLevel = 2, PricePerKg = 30.03m, SupplierID = 1 },
                new CoffeeBean { Id = 3, Name = "caf3", OriginCountry = "cou3", RoastLevel = 2, PricePerKg = 30.03m, SupplierID = 1 }
           );
            
            modelBuilder.Entity<Batch>().HasData(
                new Batch { Id=1,RoastDate = new DateTime(2021,1,6), QuantityKg = 50, CoffeeBeanId = 1 }

           );

            modelBuilder.Entity<Supplier>().HasData(


                 new Supplier {Id=1, Name = "Sup1", ContactNumber = "0115121581", Email = "Manar@gmial.com" }



                );
            
        }



    }
}
