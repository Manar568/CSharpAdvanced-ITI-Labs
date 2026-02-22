using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.AuthorDtos;
using Application.Interfaces.IRepositories;
using Application.Interfaces.IServices;
using Domain.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class AuthorService : IAuthorService

    {
        public IGenericRebository<Author> _authorRebository;

        public AuthorService(IGenericRebository<Author> authorRebository)
        {
            _authorRebository = authorRebository;
        }

        public List<GetUpdateAuthorDto> GetAllAuthors()
        {
            var authors = _authorRebository.GetAll();
            var returnAuthirs = authors.Adapt<List<GetUpdateAuthorDto>>();
            return returnAuthirs;


            
        }

        public GetUpdateAuthorDto GetAuthorById(int id)
        {
            var author = _authorRebository.GetAll().FirstOrDefault(a => a.Id == id);
                 GetUpdateAuthorDto res = author.Adapt<GetUpdateAuthorDto>();
            return res;


            //foreach (var auth in authlist)
            //{

            //    if (auth.Id == id)
            //    {

            //        GetUpdateAuthorDto res = auth.Adapt<GetUpdateAuthorDto>();

            //        return res;
            //    }


            //}
            /// return null;
        }

        public GetAuthorWithBookDto GetAuthorWithBooks(int id)
        {
            var authors = _authorRebository.GetAll().Include(a=>a.Books).FirstOrDefault(a => a.Id == id);
            var returnAuthirs = authors.Adapt<GetAuthorWithBookDto>();
            return returnAuthirs;
        }
        public void AddNewAuthor(AddAuthorDto authorDto)
        {
            var auth = authorDto.Adapt<Author>();
            _authorRebository.Add(auth);
          

        }

        public void DeleteAuthor(int id)
        {
            var auth=_authorRebository.GetAll().FirstOrDefault(a=>a.Id==id);
            if (auth != null)
                _authorRebository.Delete(auth);
        }

        public void UpdateAuthor(GetUpdateAuthorDto authorDto)
        {
            var auth =authorDto.Adapt<Author>();
            _authorRebository.Update(auth);
            
        }
    }
}
