using Application.Dtos.AuthorDtos;
using Application.Dtos.BookDtos;
using Application.Interfaces.IRepositories;
using Application.Interfaces.IServices;
using Application.Mapper;
using Application.Services;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Rebositories;

namespace PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellllo");
            MapsterConfig.Config();

            MyDbContext context = new MyDbContext();

            IGenericRebository<Book> bookRebo =new GenericRebository<Book>(context);

            IBookService bookService= new BookService(bookRebo);

            IGenericRebository<Author> authorRebo =new GenericRebository<Author>(context);

            IAuthorService authorService =new AuthorService(authorRebo);

            AddAuthorDto newAuthor = new() { FirstName = "Author1" };
            AddAuthorDto newAuthor2 = new() { FirstName = "Author2" };
            AddAuthorDto newAuthor3 = new() { FirstName = "Author3" };

            AddBookDto newBook = new() { Title="Book1" ,AuthorId=1};
            AddBookDto newBook2 = new() { Title="Book2" ,AuthorId=2};
            AddBookDto newBook3 = new() { Title="Book3" ,AuthorId=3};



            //bookService.AddNewBook(newBook);
            //bookService.AddNewBook(newBook2);
            //bookService.AddNewBook(newBook3);

            //authorService.AddNewAuthor(newAuthor);
            //authorService.AddNewAuthor(newAuthor2);
            //authorService.AddNewAuthor(newAuthor3);


            var authors = authorService.GetAllAuthors();
           // var authors2 = authorService.GetAuthorWithBooks(1);
            foreach(var auth in authors)
            {
                Console.WriteLine(auth.FirstName);
            }

            authorService.DeleteAuthor(1);

            var authors2= authorService.GetAllAuthors();

            foreach (var auth in authors2)
            {
                Console.WriteLine(auth.FirstName);
            }

            //var books= bookService.GetAllBooks();
            //foreach(var book in books)
            //{
            //    Console.WriteLine(book.Title);
            //}
            var book= bookService.GetBookByAuthor("Auth1");
            Console.WriteLine(book.Title);





            //foreach(var book in books)
            //{
            //    Console.WriteLine(book.Title);
            //}




            // GenericRebository<Book> bookRebo = new(context);

           // BookService bookService = new BookService(bookRebo);
        }
    }
}
