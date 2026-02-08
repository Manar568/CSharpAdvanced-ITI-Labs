using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C__Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Company company = new()
            { Name = "Camp1", Budget = 1000 };


            Employee employee = new Employee()
            { Name = "manar", Salary = 500 };

            company.AddEmployee(employee);

            employee.IncreaseSalary(200);
            Console.WriteLine(employee.Salary);
            Console.WriteLine(company.Budget);


            List<Employee> result = company.FilterEmployee(x => x > 500);
            foreach (Employee emp in result) {
                Console.WriteLine($"{emp.Name} : {emp.Salary}");
            }




            ///////////////////////
            ///


            Book b1 = new Book("manar", "1235", 200);
            Book b2 = new Book("manar222", "12558", 100);
            Book b3 = new Book("manar33", "991235", 300);

            b1.PublicationDate = new DateTime(2020, 3, 1);
            b2.PublicationDate = new DateTime(2021, 4, 1);
            b3.PublicationDate = new DateTime(2022,8 , 1);

            List<Book> books = new List<Book>();
            books.Add(b1);
            books.Add(b2);
            books.Add(b3);


            Console.WriteLine("using delegete");


            CheckBookfptr iSBNfptr = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, iSBNfptr);


            // Func<List<Book>, string> func = new Func<List<Book>, string>;


            Console.WriteLine("BCL");


            Func<Book, string> func = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooksBCL(books,func);




            Console.WriteLine("Annonymous");


            LibraryEngine.ProcessBooksBCL(books, delegate (Book b) { return $"{b.ISBN}"; });


            Console.WriteLine("Lambda");


            LibraryEngine.ProcessBooksBCL(books,b =>b.PublicationDate.ToString());







        }
    }
}
