using System.Net;
using BIL;
using BIL.Model;

namespace C__Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            AuthorManager authorManager = new AuthorManager();

            List<Author> authors = authorManager.GetAllAuthors();
            foreach (Author author in authors)
            {
                Console.WriteLine(author);
            }

             string delete =authorManager.DeleteAuthor("999-99-9999");

            Console.WriteLine(delete);

          /* string add= authorManager.AddAuthor(new Author
            {
                Id = "999-99-9999",
                FName = "John",
                LName = "Doe",
                Phone = "123-456-7890",
                Address = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345",
                Contract = true
            });

            Console.WriteLine(add);*/


            AuthorManager authorManager2 = new AuthorManager();

            List<Author> authors2 = authorManager2.GetAllAuthors();
            foreach (Author author in authors2)
            {
                Console.WriteLine(author);
            }






        }
    }
}
