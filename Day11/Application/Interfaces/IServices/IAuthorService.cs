using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AuthorDtos;
using Domain.Entities;

namespace Application.Interfaces.IServices
{
    public  interface IAuthorService
    {
        public List<GetUpdateAuthorDto> GetAllAuthors();
        public GetAuthorWithBookDto GetAuthorWithBooks(int id);
        public GetUpdateAuthorDto GetAuthorById(int id);
        public void AddNewAuthor(AddAuthorDto newAuthor);
        public void UpdateAuthor(GetUpdateAuthorDto author);
        public void DeleteAuthor(int id);

    }
}
