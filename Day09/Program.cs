using Microsoft.EntityFrameworkCore;
namespace Day09

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            MyDbContext db = new MyDbContext();

            var courses = db.Courses.ToList();

            Console.WriteLine("==================1111===========================");
            foreach (var course in courses) {

                Console.WriteLine(course.Name);
                foreach (var course2 in course.Students)
                {

                    Console.WriteLine(course2?.Name ??"NO Students");
                }
            }



            Console.WriteLine("==================444===========================");

            var stud2 = db.Courses.Select(c=>c.Students).Take(2);


            foreach (var stud in stud2) {

                foreach (var student in stud) { 
                
                    Console.WriteLine(student.GPA);
                    student.GPA += 0.5f;
                
                
                }            
            }





            foreach (var stud in stud2) {

                foreach (var student in stud) { 
                
                    Console.WriteLine(student.GPA);
                  //  student.GPA += 0.5f;
                
                
                }            
            }
            db.SaveChanges();

            Console.WriteLine("==================5555555===========================");

            var stu5=db.Students.ToList().Skip(1).Take(2);
            foreach (var student in stu5) {
                Console.WriteLine(student.Name);
            
            
            }





           // var fromPrecudeure= db.Students.FromSqlRaw($"EXEC SP_Students 1").ToList();
            var fromPrecudeure= db.Students.FromSqlRaw($"select * from Students").ToList();
            var courid = db.Courses.FirstOrDefault();

            var fromPrecudeureinter= db.Students.FromSqlInterpolated($"EXEC SP_Students {courid.Id}").ToList();
            foreach (var student in fromPrecudeure)
            {

                Console.WriteLine(student.Name);
            }


            foreach (var student in fromPrecudeureinter)
            {

                Console.WriteLine(student.Name);
            }
            ///////////////////////////////////////////////
            ///


            var fromView = db.StudentCoursesViewes.ToList();

            foreach (var student in fromView)
            {


                Console.WriteLine($"{student.StudentName}: {student.CourseName}");
            }

        }
    }
}
