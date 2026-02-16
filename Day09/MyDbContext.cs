using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day09
{
  public class MyDbContext :DbContext

    {
        public DbSet<Student> Students { get; set; }    
        public DbSet <Course> Courses { get; set; }
        public DbSet<StudentsCoursesView>StudentCoursesViewes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source =DESKTOP-NQ7JL3H ; Initial Catalog = STudentSystem; Integrated Security = True; Encrypt = False;").EnableDetailedErrors(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentsCoursesView>().HasNoKey().ToView("vw_StudentCourses");

            modelBuilder.Entity<Course>().HasData(

                new Course { Id = 1, Name = "course1", Hours = 10 },
                new Course { Id = 2, Name = "course2", Hours = 20 },
                new Course { Id = 3, Name = "course3", Hours = 30 }

                );
            modelBuilder.Entity<Student>().HasData(

                new Student { Id=1,Name="stu1",GPA=1.5f,CourseId=1},
                new Student { Id=2,Name="stu2",GPA=2.5f,CourseId=2},
                new Student { Id=3,Name="stu3",GPA=3.5f,CourseId=1}
                
                
                );

        }
    }

    public class DbQuery<T>
    {
    }
}
