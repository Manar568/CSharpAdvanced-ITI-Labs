using Microsoft.EntityFrameworkCore;

namespace Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyDbContext db=new MyDbContext();


            var offc = db.SalesOffices;

            foreach (var off in offc)
            {

                Console.WriteLine(off);


                if (off.Employee != null)
                {
                    foreach (var row in off.Employees)
                    {
                        Console.WriteLine(row);
                    }
                }

                else Console.WriteLine("not exsit");
            }
            //////////////////////////////////////
            ///
            var offmang=db.SalesOffices.Include(x=> x.Employee);

            foreach(var item in offmang)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Employee.EmployeeName);
            }

            //////////////////////////////
            ///
            var empoff = db.Employees.Include(e => e.SalesOffice);

            foreach(var item in empoff)
            {


                Console.WriteLine(item);
                Console.WriteLine(item.SalesOffice.OfficeNumber);
            }











            ////////////////////////////////////////////////////

            var off3 = db.SalesOffices.Include(x => x.Properties).FirstOrDefault();


            foreach (var item in offc)
            {
                Console.WriteLine(item);
                if (item.Properties != null)
                {
                    foreach (var i in item.Properties)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("not found");
            }
            ///////////////////////
            ///
            /// 
            var counoff = db.SalesOffices.Include(s => s.Properties).Include(s => s.Employees);
          //  var counoffEMP= db.SalesOffices.Include(s => s.Employees);


            foreach (var item in counoff) {



                var x = item.Employees.Count();
                Console.WriteLine($" num employees for office {item.OfficeNumber} is : {x}");
                var y = item.Properties.Count();
                Console.WriteLine($" num properits for office {item.OfficeNumber} is : {y}");
            
            
            }






            //  var offMang = db.SalesOffices.Join(Employee){

            //}













        }
    }
}
