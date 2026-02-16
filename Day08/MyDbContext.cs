using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day08
{
   public class MyDbContext :DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<SalesOffice> SalesOffices { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-NQ7JL3H ; Initial Catalog = RealEstateFirm; Integrated Security = True; Encrypt = False;").EnableDetailedErrors(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesOffice>().HasKey(s => s.OfficeNumber);
            modelBuilder.Entity<SalesOffice>().Property(s=>s.Location).HasMaxLength(10);
            modelBuilder.Entity<SalesOffice>().HasOne(s => s.Employee).WithOne().HasForeignKey<SalesOffice>(s=>s.MangerId);
            modelBuilder.Entity<Employee>().HasOne(e=>e.SalesOffice).WithMany(s => s.Employees).HasForeignKey(e=>e.SalesOfficeId);

            modelBuilder.Entity<SalesOffice>().HasData(

                new SalesOffice { OfficeNumber = 1, Location = "loc1", MangerId = 1 },
                 new SalesOffice { OfficeNumber = 2, Location = "loc2", MangerId = 2 },
                 new SalesOffice { OfficeNumber = 3, Location = "loc3", MangerId = 3 }

                );
            modelBuilder.Entity<Employee>().HasData(

                new Employee { EmployeeId = 1, EmployeeName = "Emp1",SalesOfficeId=1},
                new Employee { EmployeeId = 2, EmployeeName = "Emp2" ,SalesOfficeId=2},
                new Employee { EmployeeId = 3, EmployeeName = "Emp3", SalesOfficeId = 3 }

                );
            modelBuilder.Entity<Property>().HasData(
                
                new Property { PropertyId =1,Address="add1",City="city1",State="stat1",ZipCode="zib1", SalesOfficeId=1}
                
                );
            modelBuilder.Entity<Owner>().HasData(
                
                new Owner { OwnerId=1,OwnerName="owner1"},
                new Owner { OwnerId=2,OwnerName="owner2"}
                
                );

        }

    }
}
