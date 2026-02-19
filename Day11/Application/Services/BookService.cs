using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.BookDtos;
using Application.Interfaces.IRepositories;
using Application.Interfaces.IServices;
using Domain.Entities;
using Mapster;

namespace Application.Services
{
    public class BookService : IBookService
    {
       public IGenericRebository<Book> _bookRebository;

        public BookService(IGenericRebository<Book> bookRebository)
        {
            _bookRebository = bookRebository;

        }

        public List<GetUpdatBookDto> GetAllBooks()
        {
            var books=_bookRebository.GetAll().ToList();
            var resBooks = books.Adapt<List<GetUpdatBookDto>>();
            return resBooks;

        }

        public GetUpdatBookDto GetBook(int id)
        {
           var book =_bookRebository.GetAll().FirstOrDefault(b=>b.Id== id);
            var resBook = book.Adapt<GetUpdatBookDto>();
            return resBook; 
        }

        public GetBookByAuthorDto GetBookByAuthor(string authorName)
        {
            var book=_bookRebository.GetAll().FirstOrDefault(b=>b.Author.FirstName== authorName);
            var resBook= book.Adapt<GetBookByAuthorDto>();
            return resBook;
        }

        public void AddNewBook(AddBookDto book)
        {
            var resBook = book.Adapt<Book>();
            _bookRebository.Update(resBook);

        }

        public void DeleteBook(int id)
        {
            var book=_bookRebository.GetAll().FirstOrDefault(b=>b.Id==id);
            _bookRebository.Delete(book);

        }

        public void UpdateBook(GetUpdatBookDto book)
        {
            var resBook=book.Adapt<Book>();
            _bookRebository.Update(resBook);
        }
    }
}
