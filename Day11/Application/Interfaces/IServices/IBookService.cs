using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.BookDtos;
using Domain.Entities;

namespace Application.Interfaces.IServices
{
   public interface IBookService
    {
        public List<GetUpdatBookDto> GetAllBooks();
        public GetUpdatBookDto GetBook(int id);
        public GetBookByAuthorDto GetBookByAuthor(string authorName);
        public void AddNewBook(AddBookDto newBook);
        public void DeleteBook(int id);
        public void UpdateBook(GetUpdatBookDto book);

    }
}
