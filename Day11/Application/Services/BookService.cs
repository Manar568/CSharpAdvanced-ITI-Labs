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
using Microsoft.EntityFrameworkCore;

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
            if (book == null)
                return null;
            var resBook = book.Adapt<GetUpdatBookDto>();
            return resBook; 
        }

        public GetBookByAuthorDto GetBookByAuthor(string authorName)
        {
            var book=_bookRebository.GetAll().Include(b=>b.Author).FirstOrDefault(b=>b.Author.FirstName== authorName);
            if (book == null)
                return null;
            var resBook= book.Adapt<GetBookByAuthorDto>();
            if (resBook == null)
                return null;
            return resBook;
        }

        public void AddNewBook(AddBookDto book)
        {
            if (book == null)
                return ;
            var resBook = book.Adapt<Book>();
            _bookRebository.Add(resBook);

        }

        public void DeleteBook(int id)
        {
            var book=_bookRebository.GetAll().FirstOrDefault(b=>b.Id==id);
            if (book == null)
                return ;
            _bookRebository.Delete(book);
           

        }

        public void UpdateBook(GetUpdatBookDto book)
        {
            var resBook=book.Adapt<Book>();
            _bookRebository.Update(resBook);
        }
    }
}
