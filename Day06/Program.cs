namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var Dept = SampleData.Departments.Select(d=>new {Name=d.DeptName , d.Address });

            foreach (var dept in Dept) {

                Console.WriteLine(dept);
            
            }
            Console.WriteLine("===================================222222==============================");


            ////////////////222222/////////////////////////////////////
            ///


            var prod = SampleData.Products.Where(p => p.UnitsInStock == 0);


            var prod2= SampleData.Products.Where(P=>P.UnitsInStock > 0 && P.UnitPrice>100);


            foreach (var product in prod) {
                Console.WriteLine(product);
            
            }
            Console.WriteLine("====================================33333333=============================");


            foreach (var product in prod2)
            {
                Console.WriteLine(product);

            }


            Console.WriteLine("============================================44444444444444444444444444444=====================");

            var emp=SampleData.Employees.Count(e => e.Salary > 20000);

            Console.WriteLine(emp);


            Console.WriteLine("============================================5555555555555555555555555=====================");

            var cours = SampleData.Courses.Where(c => c.Hours > 55).Take(3);

            foreach (var cour in cours) {

                Console.WriteLine(cour);
            
            }


            Console.WriteLine("============================================66666666666666666666=====================");

            var cors2 = SampleData.Courses.OrderBy(c => c.SubjectId).ThenByDescending(c => c.Hours);

            foreach (var c in cors2)
            {
                Console.WriteLine(c);
            }


            Console.WriteLine("============================================7777777777777777777777777=====================");

            var pro3 = SampleData.Products.OrderBy(p => p.ProductName);


            foreach (var product in pro3) {

                Console.WriteLine(product);
            
            }


            Console.WriteLine("============================================8888888888888888=====================");

            var empDep = SampleData.Employees.Join(
               SampleData.Departments,
                e=>e.EmpId,
                d=>d.DeptId,
                (e, d) => new {e.EmpName,d.DeptName}
         
                );

            foreach(var c in empDep)
            {
                Console.WriteLine(c);
            }


            Console.WriteLine("============================================99999999999999999999999=====================");

            var subCourse = SampleData.Courses.GroupJoin(
                SampleData.Subjects,
                c => c.SubjectId,
                s => s.SubjectId,
                (c, g) =>new  { c.CourseName , Subjects = g}
                );

            foreach(var c in subCourse)
            {
                    Console.WriteLine(c.CourseName);

                foreach (var c2 in c.Subjects)
                {
                    Console.WriteLine(c2);
                }


            }


            Console.WriteLine("============================================100000000000000000000=====================");


            var cors10 = SampleData.Courses.GroupBy(c => new { c.SubjectId ,c.CourseId });

            foreach (var c in cors10) {

               Console.WriteLine($"{c.Key.SubjectId}");

                foreach (var item in c)
                {
                    Console.WriteLine($"item :{item.CourseName}");
                }


            }



            Console.WriteLine("============================================1111111111111111111111111111=====================");

            var pro11 = SampleData.Products.GroupBy(p => p.Category);  /////note use linq

            foreach (var c in pro11) { 
            
                var summm=c.Sum(p=>p.UnitsInStock);
              //  var minnn = c.Min(p => p.UnitPrice);
                Console.WriteLine($"{c.Key} : {summm}");
            
            
            }


            Console.WriteLine("============================================121212222222=====================");


            var pro12 = SampleData.Products.GroupBy(p => p.Category);

            foreach (var c in pro12)
            {

                //var summm = c.Sum(p => p.UnitPrice);
                var minnn = c.Min(p => p.UnitPrice);
                Console.WriteLine($"{c.Key} : {minnn} $");


            }

            Console.WriteLine("===========================13=================13=====================");

            var cust = SampleData.Customers.Select(c=>new { c.CustomerName , c.Orders.Count});

            foreach (var item in cust)
            {
                Console.WriteLine(item);
                
            }


            Console.WriteLine("===========================14=================14=====================");

            var pro14 = SampleData.Products.Select(p => p.Category).Distinct();
            foreach (var c in pro14) {

                Console.WriteLine(c);
            
            
            }


            Console.WriteLine("===========================15=================15=====================");

            var pro15 = SampleData.Products.GroupBy(p => p.Category);

            foreach (var c in pro15)
            {

                var maxx = c.Max(p => p.UnitPrice);
                var maxx2 = c.MaxBy(p => p.UnitPrice);
                //var summm = c.Sum(p => p.UnitPrice);

                Console.WriteLine($"{c.Key} : ({maxx2.ProductName}) {maxx}$");




            }

            Console.WriteLine("===========================16=================16=====================");


            var Fprod = SampleData.Products.Where(p => p.UnitsInStock == 0).FirstOrDefault();

            Console.WriteLine(Fprod);
        
        
            Console.WriteLine("===========================17=================17=====================");


            var prod17 = SampleData.Products.Select(p => p.ProductName);
            foreach (var c in prod17)
            {
                Console.WriteLine(c);

            }
            
            
            Console.WriteLine("===========================18=================18=====================");
            var prod18 = SampleData.Products.Select(p => new { Name = p.ProductName, Price = p.UnitPrice });
            foreach (var item in prod18)
            {
                Console.WriteLine(item);
            }






            
            
            
            Console.WriteLine("============================================11111111=====================");

            var ordCustoms = SampleData.Customers.Where(c => c.City == "Seattle").Select(c=>c.Orders).Take(3);

            foreach(var c in ordCustoms)
            {
                foreach (var c2 in c)
                {
                    Console.WriteLine(c2);

                }
            }

            
            
            
            
            
            
            
            Console.WriteLine("===========================222222=================");

            var prodB2 = SampleData.Products.GroupBy(p => p.Category).Where(g=>g.Any(p => p.UnitsInStock == 0));

            foreach (var c in prodB2) {

                Console.WriteLine(c.Key);


            }


            Console.WriteLine("===========================33333333333333=================");






        }
    }
}
